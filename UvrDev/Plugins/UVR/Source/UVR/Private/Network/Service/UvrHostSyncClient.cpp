// Copyright 2016 Pixela Labs. All Rights Reserved.
#include "UvrPrivatePCH.h"
#include "UvrHostSyncClient.h"

#include "Network/UvrMessage.h"

UvrHostSyncClient::UvrHostSyncClient() :
	UvrClient(FString("CLN_HS"))
{	
}

UvrHostSyncClient::UvrHostSyncClient(const FString& name) :
	UvrClient(name)
{
}

void UvrHostSyncClient::SendDataToHost()
{	
	FString data = "entity:ownship:segmentId";
	SendString(data);
	// SendStringUDP(data);
}

