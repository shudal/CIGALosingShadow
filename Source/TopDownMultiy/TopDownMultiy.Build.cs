// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TopDownMultiy : ModuleRules
{
	public TopDownMultiy(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "NavigationSystem", "AIModule","OnlineSubsystem",
	        "OnlineSubsystemUtils" });
        PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore"});

        DynamicallyLoadedModuleNames.AddRange(
	        new string[] {
		        "OnlineSubsystemNull"
	        }
        );
    }
}
