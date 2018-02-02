// Copyright 2016 Pixela Labs. All Rights Reserved.
#include "UvrPrivatePCH.h"
#include "UvrHostSyncClient.h"

#include "Network/UvrMessage.h"

UvrHostSyncClient::UvrHostSyncClient() :
	UvrClient(FString("CLN_HS"), UvrClient::ST_UDP)
{	
}

UvrHostSyncClient::UvrHostSyncClient(const FString& name) :
	UvrClient(name)
{
}

void UvrHostSyncClient::SendDataToHost()
{	
	FString data = "empty";	
	SendStringUDP(data);
}

