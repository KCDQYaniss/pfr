namespace EFT;

[Extension]
public static class PlayerSideExtension
{

	[Extension]
	public static bool Any(EPlayerSideMask mask, EPlayerSideMask side) { }

	[Extension]
	public static bool CheckSide(EPlayerSideMask mask, EPlayerSide side) { }

	[Extension]
	public static bool CheckSide(EPlayerSide side, EPlayerSideMask mask) { }

	[Extension]
	public static bool CheckSide(ETaskPlayerSide mask, EPlayerSide side) { }

	[Extension]
	public static bool Contain(EPlayerSideMask mask, EPlayerSide side) { }

	[Extension]
	public static bool Contain(ETaskPlayerSide mask, EPlayerSide side) { }

}

