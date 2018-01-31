// Copyright 2016 Pixela Labs. All Rights Reserved.
#pragma once

#include "Misc/UvrBarrier.h"
#include "Network/Service/UvrService.h"
#include "Network/Protocol/IPUvrClusterSyncProtocol.h"
#include <vector>



class UvrHostSyncService :
	public  UvrService	
{
public:
	UvrHostSyncService(const FString& addr, const int32 port);	

protected:
	//////////////////////////////////////////////////////////////////////////////////////////////
	// IUvrSessionListener
	//////////////////////////////////////////////////////////////////////////////////////////////
	virtual void NotifySessionOpen(UvrSession* pSession) override;
	virtual void NotifySessionClose(UvrSession* pSession) override;
	virtual UvrMessage::Ptr ProcessMessage(UvrMessage::Ptr msg) override;

protected:
	virtual bool IsConnectionAllowed(FSocket* pSock, const FIPv4Endpoint& ep) override;

private:
	struct HostData {
		int counter;
		FString str;
	};

	void ProcessData(HostData hd);

public:
	void WaitForHost();

private:
	std::mutex m_dataMutex;
	std::mutex m_waitMutex;
	std::vector<HostData> m_HostDataArray;
	std::condition_variable m_cv;
};

