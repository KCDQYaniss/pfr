namespace EFT;

[Extension]
public static class ShottypeExtension
{

	[Extension]
	public static EShotType ToShotType(EMalfunctionState malfunctionState) { }

	[Extension]
	public static EMalfunctionState ToWeaponMalfunctionState(EShotType eShotType) { }

}

