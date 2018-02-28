
// Copyright 2016 Pixela Labs. All Rights Reserved.
#include "UvrPrivatePCH.h"
#include "UvrClusterNodeCtrlMaster.h"

#include "UvrPlugin.h"



UvrClusterNodeCtrlMaster::UvrClusterNodeCtrlMaster(const FString& ctrlName, const FString& nodeName) :
	UvrClusterNodeCtrlSlave(ctrlName, nodeName)
{
}

UvrClusterNodeCtrlMaster::~UvrClusterNodeCtrlMaster()
{
}


//////////////////////////////////////////////////////////////////////////////////////////////
// IPUvrNodeController
//////////////////////////////////////////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////////////////////////////////////
// IPUvrNodeController
//////////////////////////////////////////////////////////////////////////////////////////////
void UvrClusterNodeCtrlMaster::GetSyncData(UvrMessage::DataType& data)
{
	// Override slave implementation with empty one.
	// There is no need to sync on master side since it have source data being synced.
}

void UvrClusterNodeCtrlMaster::GetInputData(UvrMessage::DataType& data)
{
	// Override slave implementation with empty one.
	// There is no need to sync on master side since it have source data being synced.
}


//////////////////////////////////////////////////////////////////////////////////////////////
// UvrNodeCtrlBase
//////////////////////////////////////////////////////////////////////////////////////////////
bool UvrClusterNodeCtrlMaster::InitializeServers()
{
	if (!UvrClusterNodeCtrlSlave::InitializeServers())
		return false;

	UE_LOG(LogUvrCluster, Log, TEXT("%s - initializing master servers..."), *GetControllerName());

	// Get config data
	SUvrConfigClusterNode masterCfg;
	if (UvrPlugin::get().ConfigMgr->GetMasterClusterNode(masterCfg) == false)
	{
		UE_LOG(LogUvrCluster, Error, TEXT("No master node configuration data found"));
		return false;
	}

	// Instantiate node servers
	UE_LOG(LogUvrCluster, Log, TEXT("Servers: addr %s, port_cs %d, port_ss %d"), *masterCfg.Addr, masterCfg.Port_CS, masterCfg.Port_SS);
	m_srvCS.Reset(new UvrClusterSyncService(masterCfg.Addr, masterCfg.Port_CS));
	m_srvSS.Reset(new UvrSwapSyncService(masterCfg.Addr, masterCfg.Port_SS));

	m_syncHost = FParse::Param(FCommandLine::Get(), TEXT("sync_host"));
	bool hsValid = true;
	if (m_syncHost)
	{
		m_srvHS.Reset(new UvrHostSyncService(masterCfg.Addr, masterCfg.Port_HS));
		hsValid = m_srvHS.IsValid();
	}

	return m_srvCS.IsValid() && m_srvSS.IsValid() && hsValid;
}

bool UvrClusterNodeCtrlMaster::StartServers()
{
	if (!UvrClusterNodeCtrlSlave::StartServers())
		return false;

	UE_LOG(LogUvrCluster, Log, TEXT("%s - starting master servers..."), *GetControllerName());

	// CS server start
	if (m_srvCS->Start())
	{
		UE_LOG(LogUvrCluster, Log, TEXT("%s started"), *m_srvCS->GetName());
	}
	else
	{
		UE_LOG(LogUvrCluster, Error, TEXT("%s failed to start"), *m_srvCS->GetName());
	}

	// SS server start
	if (m_srvSS->Start())
	{
		UE_LOG(LogUvrCluster, Log, TEXT("%s started"), *m_srvSS->GetName());
	}
	else
	{
		UE_LOG(LogUvrCluster, Error, TEXT("%s failed to start"), *m_srvSS->GetName());
	}

	bool hsRunning = true;
	if (m_syncHost)
	{
		// HS server start
		if (m_srvHS->Start())
		{
			UE_LOG(LogUvrCluster, Log, TEXT("%s started"), *m_srvHS->GetName());
		}
		else
		{
			UE_LOG(LogUvrCluster, Error, TEXT("%s failed to start"), *m_srvHS->GetName());
		}
		hsRunning = m_srvHS->IsRunning();
	}
	

	// Start the servers
	return m_srvCS->IsRunning() && m_srvSS->IsRunning() && hsRunning;
}

void UvrClusterNodeCtrlMaster::StopServers()
{
	UvrClusterNodeCtrlSlave::StopServers();

	m_srvCS->Shutdown();
	m_srvSS->Shutdown();

	if (m_syncHost)
	{
		m_srvHS->Shutdown();
	}
}

bool UvrClusterNodeCtrlMaster::InitializeClients()
{
	if (!UvrClusterNodeCtrlSlave::InitializeClients())
		return false;	

	bool hsValid = true;
	if (m_syncHost)
	{
		m_clnHS.Reset(new UvrHostSyncClient());
		hsValid = m_clnHS.IsValid();
	}

	return hsValid;
}

bool UvrClusterNodeCtrlMaster::StartClients()
{
	if (!UvrClusterNodeCtrlSlave::StartClients())
		return false;

	if (m_syncHost)
	{
		// Master config
		SUvrConfigClusterNode masterCfg;
		if (UvrPlugin::get().ConfigMgr->GetMasterClusterNode(masterCfg) == false)
		{
			UE_LOG(LogUvrCluster, Error, TEXT("No master node configuration data found"));
			return false;
		}

		// HS client
		if (m_clnHS->Connect(masterCfg.HostAddr, masterCfg.Port_Host))
		{
			UE_LOG(LogUvrCluster, Log, TEXT("%s connected to the server %s:%d"), *m_clnHS->GetName(), *masterCfg.Addr, masterCfg.Port_SS);
		}
		else
		{
			UE_LOG(LogUvrCluster, Error, TEXT("%s couldn't connect to the server %s:%d"), *m_clnHS->GetName(), *masterCfg.Addr, masterCfg.Port_SS);
			return false;
		}

		return m_clnHS->IsConnected();
	}

	return true;
}

void UvrClusterNodeCtrlMaster::StopClients()
{
	UvrClusterNodeCtrlSlave::StopClients();

	if (m_syncHost)
	{
		m_clnHS->Disconnect();
	}
}

void UvrClusterNodeCtrlMaster::WaitForFrameStart()
{			
	UvrClusterNodeCtrlSlave::WaitForFrameStart();	
}

//////////////////////////////////////////////////////////////////////////////////////////////
// IPUvrHostSyncProtocol
//////////////////////////////////////////////////////////////////////////////////////////////
void UvrClusterNodeCtrlMaster::SyncToHost()
{
	if (m_syncHost)
	{
		m_clnHS->SendDataToHost();		
		m_srvHS->WaitForHost();
		m_srvCS->EndWaitSyncData();
	}
}

