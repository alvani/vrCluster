// Copyright 2016 Pixela Labs. All Rights Reserved.
#include "UvrPrivatePCH.h"
#include "UvrHostSyncService.h"

#include "ClusterSync/UvrClusterSyncMsg.h"
#include "UvrPlugin.h"



UvrHostSyncService::UvrHostSyncService(const FString& addr, const int32 port) :
	UvrService(FString("SRV_HS"), addr, port)
{
	m_hostMode = true;
}

//////////////////////////////////////////////////////////////////////////////////////////////
// IUvrSessionListener
//////////////////////////////////////////////////////////////////////////////////////////////
void UvrHostSyncService::NotifySessionOpen(UvrSession* pSession)
{
	UvrService::NotifySessionOpen(pSession);
}

void UvrHostSyncService::NotifySessionClose(UvrSession* pSession)
{
	UvrService::NotifySessionClose(pSession);
}

UvrMessage::Ptr UvrHostSyncService::ProcessMessage(UvrMessage::Ptr msg)
{
	// Check the pointer
	if (msg.IsValid() == false)
	{
		UE_LOG(LogUvrNetworkMsg, Error, TEXT("%s - Couldn't process the message"), *GetName());
		return nullptr;
	}

	UE_LOG(LogUvrNetwork, Verbose, TEXT("%s - Processing message %s"), *GetName(), *msg->ToString());		

	// Dispatch the message
	const FString msgName = msg->GetName();
	
	if (msgName == "host")
	{
		FString str;
		msg->GetArg("str", str);
		UE_LOG(LogUvrNetwork, Log, TEXT("%s"), *str);

		HostData hd;
		hd.str = str;		
		std::unique_lock<std::mutex> lock{ m_dataMutex };
		m_HostDataArray.push_back(hd);
		lock.unlock();

		m_cv.notify_all();
	}

	// Being here means that we have no appropriate dispatch logic for this message
	UE_LOG(LogUvrNetworkMsg, Warning, TEXT("%s - A dispatcher for this message hasn't been implemented yet <%s>"), *GetName(), *msg->ToString());
	return nullptr;
}

bool UvrHostSyncService::IsConnectionAllowed(FSocket* pSock, const FIPv4Endpoint& ep)
{
	return true;
}

void UvrHostSyncService::ProcessData(HostData hd)
{	
	// UE_LOG(LogUvrNetworkMsg, Warning, TEXT("%s - A dispatcher for this message hasn't been implemented yet <%s>"), *GetName(), *hd.str);
	UvrPlugin::get().m_replyString = hd.str;
}

void UvrHostSyncService::WaitForHost()
{
	std::unique_lock<std::mutex> lock{ m_dataMutex };
	size_t count = m_HostDataArray.size();
	if (count > 0)
	{
		ProcessData(m_HostDataArray[0]);
		m_HostDataArray.erase(m_HostDataArray.begin());
		lock.unlock();
	}
	else
	{
		// Wait from server
		lock.unlock();
		std::unique_lock<std::mutex> waitLock{ m_waitMutex };
		m_cv.wait_for(waitLock, std::chrono::milliseconds(5000));

		lock.lock();
		count = m_HostDataArray.size();
		if (count > 0)
		{
			ProcessData(m_HostDataArray[0]);
			m_HostDataArray.erase(m_HostDataArray.begin());			
		}
		lock.unlock();
	}
}
