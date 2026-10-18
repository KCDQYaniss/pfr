namespace EFT;

[Extension]
public static class PlayerGroupExtension
{

	[Extension]
	public static bool IsScav(EPlayerGroup playerGroup) { }

	[Extension]
	public static EPlayerGroup ToPlayerGroup(EPlayerSide playerSide) { }

	[Extension]
	public static EPlayerGroup ToPlayerGroup(ESideType playerSide) { }

}

