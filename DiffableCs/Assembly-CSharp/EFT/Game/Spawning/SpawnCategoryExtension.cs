namespace EFT.Game.Spawning;

[Extension]
public static class SpawnCategoryExtension
{

	[Extension]
	public static bool Any(ESpawnCategoryMask mask, ESpawnCategoryMask category) { }

	[Extension]
	public static bool Contain(ESpawnCategoryMask mask, ESpawnCategory category) { }

	[Extension]
	public static bool ContainBossCategory(ESpawnCategoryMask mask) { }

	[Extension]
	public static bool ContainBotCategory(ESpawnCategoryMask mask) { }

	[Extension]
	public static bool ContainBotPmcCategory(ESpawnCategoryMask mask) { }

	[Extension]
	public static bool ContainPlayerCategory(ESpawnCategoryMask mask) { }

	[Extension]
	public static bool ContainSeason01Category(ESpawnCategoryMask mask) { }

}

