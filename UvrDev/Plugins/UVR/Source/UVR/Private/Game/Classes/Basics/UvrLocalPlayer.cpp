// Fill out your copyright notice in the Description page of Project Settings.

#include "UvrPrivatePCH.h"
#include "UvrLocalPlayer.h"

#include "Engine/LocalPlayer.h"
#include "Misc/FileHelper.h"
#include "EngineDefines.h"
#include "EngineGlobals.h"
#include "Engine/Scene.h"
#include "Camera/CameraTypes.h"
#include "GameFramework/Actor.h"
#include "GameFramework/Pawn.h"
#include "Engine/World.h"
#include "SceneView.h"
#include "UObject/UObjectAnnotation.h"
#include "Logging/LogScopedCategoryAndVerbosityOverride.h"
#include "UObject/UObjectIterator.h"
#include "GameFramework/OnlineReplStructs.h"
#include "GameFramework/PlayerController.h"
#include "Engine/SkeletalMesh.h"
#include "Components/SkeletalMeshComponent.h"
#include "UnrealEngine.h"
#include "EngineUtils.h"

#include "Matinee/MatineeActor.h"
#include "Matinee/InterpData.h"
#include "Matinee/InterpGroupInst.h"
#include "Net/OnlineEngineInterface.h"
#include "SceneManagement.h"
#include "PhysicsPublic.h"
#include "SkeletalMeshTypes.h"

#include "SceneViewExtension.h"
#include "Net/DataChannel.h"
#include "GameFramework/PlayerState.h"

#include "GameDelegates.h"

#include "UvrPlugin.h"

bool UUvrLocalPlayer::GetProjectionData(FViewport* Viewport, EStereoscopicPass StereoPass, FSceneViewProjectionData& ProjectionData) const
{
	//UE_LOG();
	// return ULocalPlayer::GetProjectionData(Viewport, StereoPass, ProjectionData);

	FVector ProjLoc;
	FRotator ProjRot;
	FVector2D ProjSize;
	
	bool UseUvr = false;
	if (UvrPlugin::get().GameMgr.IsValid())
	{
		auto Screen = UvrPlugin::get().GameMgr->GetActiveScreen();
		if (Screen)
		{
			ProjLoc = Screen->GetComponentLocation();
			ProjRot = Screen->GetComponentRotation();
			ProjSize = Screen->GetScreenSize();
			UseUvr = true;
		}		
	}

	// If the actor
	if ((Viewport == NULL) || (PlayerController == NULL) || (Viewport->GetSizeXY().X == 0) || (Viewport->GetSizeXY().Y == 0))
	{
		return false;
	}

	int32 X = FMath::TruncToInt(Origin.X * Viewport->GetSizeXY().X);
	int32 Y = FMath::TruncToInt(Origin.Y * Viewport->GetSizeXY().Y);
	uint32 SizeX = FMath::TruncToInt(Size.X * Viewport->GetSizeXY().X);
	uint32 SizeY = FMath::TruncToInt(Size.Y * Viewport->GetSizeXY().Y);

	FIntRect UnconstrainedRectangle = FIntRect(X, Y, X + SizeX, Y + SizeY);

	ProjectionData.SetViewRectangle(UnconstrainedRectangle);

	// Get the viewpoint.
	FMinimalViewInfo ViewInfo;
	GetViewPoint(/*out*/ ViewInfo, StereoPass);			

	// scale distances for cull distance purposes by the ratio of our current FOV to the default FOV
	PlayerController->LocalPlayerCachedLODDistanceFactor = ViewInfo.FOV / FMath::Max<float>(0.01f, (PlayerController->PlayerCameraManager != NULL) ? PlayerController->PlayerCameraManager->DefaultFOV : 90.f);

	FVector StereoViewLocation = ViewInfo.Location;	

	// Create the view matrix
	ProjectionData.ViewOrigin = StereoViewLocation;
	if (UseUvr)
	{
		ProjectionData.ViewRotationMatrix = FInverseRotationMatrix(ProjRot) * FMatrix(
			FPlane(0, 0, 1, 0),
			FPlane(1, 0, 0, 0),
			FPlane(0, 1, 0, 0),
			FPlane(0, 0, 0, 1));
	}
	else
	{
		ProjectionData.ViewRotationMatrix = FInverseRotationMatrix(ViewInfo.Rotation) * FMatrix(
			FPlane(0, 0, 1, 0),
			FPlane(1, 0, 0, 0),
			FPlane(0, 1, 0, 0),
			FPlane(0, 0, 0, 1));
	}	

	if (UseUvr)
	{
		ProjectionData.ProjectionMatrix = CalcProjectionMatrix(ProjSize, ProjLoc, ProjRot, ViewInfo.Location);		
	}
	else
	{
		// Create the projection matrix (and possibly constrain the view rectangle)
		FMinimalViewInfo::CalculateProjectionMatrixGivenView(ViewInfo, AspectRatioAxisConstraint, ViewportClient->Viewport, /*inout*/ ProjectionData);
	}	

	// ViewExtension may need to update the projection matrix when not using stereo rendering. for example when doing monocular AR.
	for (int ViewExt = 0; ViewExt < GEngine->ViewExtensions.Num(); ViewExt++)
	{
		GEngine->ViewExtensions[ViewExt]->SetupViewProjectionMatrix(ProjectionData);
	}

	return true;
}

FMatrix UUvrLocalPlayer::CalcProjectionMatrix(FVector2D ProjSize, FVector ProjLoc, FRotator ProjRot, FVector ViewLocation) const
{	
	const float n = GNearClippingPlane;	

	// Half-size
	const float hw = ProjSize.X / 2.f;
	const float hh = ProjSize.Y / 2.f;

	// Screen corners
	const FVector pa = ProjLoc + ProjRot.Quaternion().RotateVector(GetProjectionScreenGeometryLBC(hw, hh)); // left bottom corner
	const FVector pb = ProjLoc + ProjRot.Quaternion().RotateVector(GetProjectionScreenGeometryRBC(hw, hh)); // right bottom corner
	const FVector pc = ProjLoc + ProjRot.Quaternion().RotateVector(GetProjectionScreenGeometryLTC(hw, hh)); // left top corner
																																// Screen vectors
	FVector vr = pb - pa; // lb->rb normilized vector, right axis of projection screen
	vr.Normalize();
	FVector vu = pc - pa; // lb->lt normilized vector, up axis of projection screen
	vu.Normalize();
	FVector vn = -FVector::CrossProduct(vr, vu); // Projection plane normal. Use minus because of left-handed coordinate system
	vn.Normalize();
	
	const FVector pe = ViewLocation;
	const FVector va = pa - pe; // camera -> lb
	const FVector vb = pb - pe; // camera -> rb
	const FVector vc = pc - pe; // camera -> lt

	const float d = -FVector::DotProduct(va, vn); // distance from eye to screen
	const float ndifd = n / d;
	const float l = FVector::DotProduct(vr, va) * ndifd; // distance to left screen edge
	const float r = FVector::DotProduct(vr, vb) * ndifd; // distance to right screen edge
	const float b = FVector::DotProduct(vu, va) * ndifd; // distance to bottom screen edge
	const float t = FVector::DotProduct(vu, vc) * ndifd; // distance to top screen edge

	const float mx = 2.f * n / (r - l);
	const float my = 2.f * n / (t - b);
	const float ma = -(r + l) / (r - l);
	const float mb = -(t + b) / (t - b);	
	const float me = 1.f;

	// Normal LHS	
	const FMatrix pm = FMatrix(
		FPlane(mx, 0, 0, 0),
		FPlane(0, my, 0, 0),
		FPlane(ma, mb, 1, me),
		FPlane(0, 0, -n, 0));

	// Invert Z-axis (UE4 uses Z-inverted LHS)
	const FMatrix flipZ = FMatrix(
		FPlane(1, 0, 0, 0),
		FPlane(0, 1, 0, 0),
		FPlane(0, 0, -1, 0),
		FPlane(0, 0, 1, 1));

	const FMatrix result(pm * flipZ);

	return result;
}


