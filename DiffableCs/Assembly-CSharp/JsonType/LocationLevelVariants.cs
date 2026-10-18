namespace JsonType;

[Extension]
public static class LocationLevelVariants
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Location location; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <IsHighLevelVariant>b__0(Location baseLocation) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Location location; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <GetBaseLocation>b__0(Location x) { }

	}


	[Extension]
	public static void ApplyLevelVariantResolution(RaidSettings raidSettings, LocationSettings locationSettings, int maxGroupLevel) { }

	[Extension]
	public static bool AreInSameLevelVariantGroup(Location first, Location second, LocationSettings locationSettings) { }

	[Extension]
	public static Location GetBaseLocation(Location location, LocationSettings locationSettings) { }

	[Extension]
	public static string GetEventLocationId(Location location, LocationSettings locationSettings) { }

	[Extension]
	public static Location GetQuestLockSource(Location location, LocationSettings locationSettings) { }

	[Extension]
	public static bool IsAvailableByPmcLevel(Location location, LocationSettings locationSettings, int minGroupLevel, int maxGroupLevel) { }

	[Extension]
	public static bool IsHighLevelVariant(Location location, LocationSettings locationSettings) { }

	[Extension]
	public static bool IsLaboratoryLocation(Location location, LocationSettings locationSettings) { }

	[Extension]
	public static bool IsLevelVariantLocation(Location location, LocationSettings locationSettings) { }

	private static bool IsLocationReferenceUnlocked(IEnumerable unlockedLocations, Location location) { }

	private static bool IsTaxonomyLocation(Location location) { }

	[Extension]
	public static bool IsTimeSelectionAllowed(Location location, LocationSettings locationSettings) { }

	[Extension]
	public static bool IsUnlockedForPlayer(Location location, LocationSettings locationSettings, IEnumerable unlockedLocations) { }

	private static bool ReferencesLocation(string locationReference, Location location) { }

	[Extension]
	public static Location ResolveByPlayerLevel(Location location, LocationSettings locationSettings, ESideType sideType, int maxGroupLevel) { }

	[Extension]
	public static Location TryGetHighLevelVariant(Location baseLocation, LocationSettings locationSettings) { }

	[Extension]
	public static bool TryGetLocation(LocationSettings locationSettings, string locationReference, out Location location) { }

}

