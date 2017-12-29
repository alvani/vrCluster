// Copyright 2016 Pixela Labs. All Rights Reserved.
#pragma once

#include "Render/Devices/UvrDeviceBase.h"


//////////////////////////////////////////////////////////////////////////////////////////////
// Generic device implementation
class UvrDeviceMonoGeneric : public UvrDeviceBase
{
	virtual void AdjustViewRect(enum EStereoscopicPass StereoPass, int32& X, int32& Y, uint32& SizeX, uint32& SizeY) const override;
	virtual bool Present(int32& InOutSyncInterval) override;
	virtual void CalculateStereoViewOffset(const enum EStereoscopicPass StereoPassType, const FRotator& ViewRotation, const float WorldToMeters, FVector& ViewLocation) override;
};


