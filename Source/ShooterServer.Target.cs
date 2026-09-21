// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class ShooterServerTarget : TargetRules
{
	public ShooterServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V7;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ShooterGame");
	}
}
