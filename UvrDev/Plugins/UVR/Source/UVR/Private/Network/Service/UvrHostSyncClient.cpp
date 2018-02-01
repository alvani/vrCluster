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
	static TSharedPtr<UvrMessage> request(new UvrMessage("str", "", ""));
	FString data = "empty";
	request->SetArg("str", data);
	SendStringMsg(request);
}

