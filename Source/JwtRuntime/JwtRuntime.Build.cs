// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class JwtRuntime : ModuleRules
{
	private string ThirdPartyPath
	{
		get {return Path.Combine(ModuleDirectory,"ThirdParty");}
	}

	public JwtRuntime(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
                
				// ... add other private include paths required here ...
			}
			);
        PublicSystemIncludePaths.AddRange(
            new string[]
            {
                Path.Combine(ThirdPartyPath),
                Path.Combine(ThirdPartyPath,"jwt-cpp")
            }
            );

        PublicDependencyModuleNames.AddRange(
			new string[]
			{
                "Engine",
                "Core",
                "CoreUObject",
                "Slate",
                "OpenSSL"
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);

        
        bEnableUndefinedIdentifierWarnings = false;
        bUseRTTI = true;
        bEnableExceptions = true;
        OptimizeCode = CodeOptimization.InShippingBuildsOnly;
    }
}
