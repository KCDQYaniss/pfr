namespace EFT;

public sealed class AllergyRuntimeEntry
{
	public readonly AllergyPerkEffect Effect; //Field offset: 0x10
	public readonly HashSet TargetItems; //Field offset: 0x18

	public AllergyRuntimeEntry(AllergyPerkEffect effect, IEnumerable targetItems) { }

}

