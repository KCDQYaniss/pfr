namespace EFT;

[Extension]
public static class PerkRuntimeUtility
{

	[Extension]
	public static bool ContainsKeyType(IEnumerable keyTypes, EPerkKeyType keyType) { }

	public static float ConvertDurabilityMultiplierToSaveChance(float multiplier) { }

	public static float ConvertDurabilityMultiplierToUsageChance(float multiplier) { }

	public static float NonNegativeMultiplier(float value) { }

	public static float PositiveMultiplier(float value) { }

	public static Nullable ResolveAuthoritativeProbability(float chance) { }

	[Extension]
	public static void ResolveBodyPartTargets(IEnumerable bodyPartTypes, out bool affectsLegs, out bool affectsHands) { }

}

