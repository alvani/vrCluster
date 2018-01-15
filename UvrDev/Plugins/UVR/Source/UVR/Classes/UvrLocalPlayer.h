// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Engine/LocalPlayer.h"
#include "UvrLocalPlayer.generated.h"

/**
 * 
 */
UCLASS()
class UUvrLocalPlayer : public ULocalPlayer
{
	GENERATED_BODY()
	
	virtual bool GetProjectionData(FViewport* Viewport, EStereoscopicPass StereoPass, FSceneViewProjectionData& ProjectionData) const override;

private:
	// Left bottom corner (from camera point view)
	FVector GetProjectionScreenGeometryLBC(const float& hw, const float& hh) const
	{
		return FVector(0.f, -hw, -hh);
	}

	// Right bottom corner (from camera point view)
	FVector GetProjectionScreenGeometryRBC(const float& hw, const float& hh) const
	{
		return FVector(0.f, hw, -hh);
	}

	// Left top corner (from camera point view)
	FVector GetProjectionScreenGeometryLTC(const float& hw, const float& hh) const
	{
		return FVector(0.f, -hw, hh);
	}

	FMatrix CalcProjectionMatrix(FVector2D ProjSize, FVector ProjLoc, FRotator ProjRot, FVector ViewLocation) const;
};
