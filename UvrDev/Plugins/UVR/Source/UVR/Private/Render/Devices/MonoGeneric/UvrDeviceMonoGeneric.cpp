// Copyright 2016 Pixela Labs. All Rights Reserved.
#include "UvrPrivatePCH.h"
#include "UvrDeviceMonoGeneric.h"

#include "Render/Devices/UvrDeviceInternals.h"


void UvrDeviceMonoGeneric::AdjustViewRect(enum EStereoscopicPass StereoPass, int32& X, int32& Y, uint32& SizeX, uint32& SizeY) const
{	
	if (StereoPass == EStereoscopicPass::eSSP_RIGHT_EYE)
	{
		Y = SizeY;
		SizeY = 1;
	}
}

void UvrDeviceMonoGeneric::CalculateStereoViewOffset(const enum EStereoscopicPass StereoPassType, const FRotator& ViewRotation, const float WorldToMeters, FVector& ViewLocation)
{
	//UE_LOG(LogUvrRender, Log, TEXT("CalculateStereoViewOffset"));

	check(IsInGameThread());
	check(WorldToMeters > 0.f);

	// Make a little hack with view rotation according to off-axis projection matrix calculation.
	// View vector must be orthogonal to the projection plane.
	const_cast<FRotator&>(ViewRotation) = m_projRot;

	const int eyeIdx = (StereoPassType == EStereoscopicPass::eSSP_LEFT_EYE ? 0 : 1);
	m_eyeLoc[eyeIdx] = ViewLocation;
	m_eyeRot[eyeIdx] = ViewRotation;
}

bool UvrDeviceMonoGeneric::Present(int32& InOutSyncInterval)
{
	exec_BarrierWait();
	return true;
}
