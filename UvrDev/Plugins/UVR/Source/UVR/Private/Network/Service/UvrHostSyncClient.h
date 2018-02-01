// Copyright 2016 Pixela Labs. All Rights Reserved.
#pragma once

#include "Network/UvrClient.h"


class UvrHostSyncClient :
	public UvrClient	
{
public:
	UvrHostSyncClient();
	UvrHostSyncClient(const FString& name);

	void SendDataToHost();
};

