using UnrealBuildTool;

public class SteamMPTarget : TargetRules
{
	public SteamMPTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SteamMP");
	}
}
