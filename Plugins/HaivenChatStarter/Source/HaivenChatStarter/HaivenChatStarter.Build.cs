using UnrealBuildTool;

public class HaivenChatStarter : ModuleRules
{
	public HaivenChatStarter(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		CppStandard = CppStandardVersion.Cpp20;
		// The inline C++ SDK headers use exceptions even in Shipping targets.
		bEnableExceptions = true;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",
			"CoreUObject",
			"Engine",
			"DeveloperSettings",
			"Haiven",
			"UMG",
		});

		PrivateDependencyModuleNames.AddRange(new string[]
		{
			"InputCore",
			"Json",
			"Projects",
			"Slate",
			"SlateCore",
		});

		if (Target.bBuildEditor)
		{
			PrivateDependencyModuleNames.Add("UnrealEd");
		}
	}
}
