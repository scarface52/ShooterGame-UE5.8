// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ShooterGame : ModuleRules
{
	public ShooterGame(ReadOnlyTargetRules Target) : base(Target)
	{
		// This legacy sample consistently includes ShooterGame.h before each translation
		// unit's matching header. Keep that established include model during migration.
		IWYUSupport = IWYUSupport.None;
		PrivatePCHHeaderFile = "Public/ShooterGame.h";

		PublicDefinitions.Add("HOST_ONLINE_GAMEMODE_ENABLED=" + HostOnlineGameEnabled);
		PublicDefinitions.Add("JOIN_ONLINE_GAME_ENABLED=" + JoinOnlineGameEnabled);
		PublicDefinitions.Add("INVITE_ONLINE_GAME_ENABLED=" + InviteOnlineGameEnabled);
		PublicDefinitions.Add("ONLINE_STORE_ENABLED=" + OnlineStoreEnabled);

		PrivateIncludePaths.AddRange(
			new string[] { 
				"ShooterGame/Private",
				"ShooterGame/Private/UI",
				"ShooterGame/Private/UI/Menu",
				"ShooterGame/Private/UI/Style",
				"ShooterGame/Private/UI/Widgets",
            }
		);

		// Preserve the sample's pre-5.x flat public-header lookup convention.
		PublicIncludePaths.AddRange(
			new string[] {
				"ShooterGame/Public/Bots", "ShooterGame/Public/Effects",
				"ShooterGame/Public/Online", "ShooterGame/Public/Pickups",
				"ShooterGame/Public/Player", "ShooterGame/Public/Sound",
				"ShooterGame/Public/Tests", "ShooterGame/Public/UI",
				"ShooterGame/Public/Weapons",
			}
		);

        PublicDependencyModuleNames.AddRange(
			new string[] {
				"Core",
				"CoreUObject",
				"Engine",
				"OnlineSubsystem",
				"OnlineBase",
				"OnlineSubsystemUtils",
				"AssetRegistry",
				"NavigationSystem",
				"AIModule",
				"GameplayTasks",
				"Gauntlet",
			}
		);

        PrivateDependencyModuleNames.AddRange(
			new string[] {
				"InputCore",
				"Slate",
				"SlateCore",
				"ShooterGameLoadingScreen",
				"Json",
				"ApplicationCore",
				"ReplicationGraph",
				"NetCore",
				"PakFile",
				"RHI",
				"PhysicsCore",
				"GameplayCameras"
			}
		);

		DynamicallyLoadedModuleNames.AddRange(
			new string[] {
				"OnlineSubsystemNull",
				"NetworkReplayStreaming",
				"NullNetworkReplayStreaming",
				"HttpNetworkReplayStreaming",
				"LocalFileNetworkReplayStreaming"
			}
		);

		PrivateIncludePathModuleNames.AddRange(
			new string[] {
				"NetworkReplayStreaming"
			}
		);

		if (Target.bBuildDeveloperTools || (Target.Configuration != UnrealTargetConfiguration.Shipping && Target.Configuration != UnrealTargetConfiguration.Test))
        {
            PrivateDependencyModuleNames.Add("GameplayDebugger");
            PublicDefinitions.Add("WITH_GAMEPLAY_DEBUGGER=1");
        }
		else
		{
			PublicDefinitions.Add("WITH_GAMEPLAY_DEBUGGER=0");
		}
		
		if (Target.Version.MajorVersion >= 5 || (Target.Version.MajorVersion == 4 && Target.Version.MinorVersion >= 27))
		{
			PrivateDependencyModuleNames.Add("GameplayCameras");
		}
	}

	protected virtual int HostOnlineGameEnabled 
	{ 
		get 
		{ 
			return 1; 
		} 
	}

	protected virtual int JoinOnlineGameEnabled
    {
        get
        {
			return 1;
        }
    }

	protected virtual int InviteOnlineGameEnabled
    {
		get
        {
			return 1;
        }
    }

	protected virtual int OnlineStoreEnabled
	{
		get
		{
			return 1;
		}
	}
}
