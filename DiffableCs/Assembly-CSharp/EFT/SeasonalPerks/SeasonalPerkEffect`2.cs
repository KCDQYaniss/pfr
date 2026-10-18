namespace EFT.SeasonalPerks;

public abstract class SeasonalPerkEffect`2 : ISeasonalPerkEffect
{
	public readonly TEffectTemplate Template; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ISeasonalPerk <Parent>k__BackingField; //Field offset: 0x0

	public override ISeasonalPerk Parent
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected SeasonalPerkEffect`2(TEffectTemplate template, ISeasonalPerk parent) { }

	protected static bool ApplyBoolValue(PerkRuntimeState state, EPerkRuntimeStatId valueId, bool value) { }

	protected static bool ApplyNumericMultiplier(PerkRuntimeState state, EPerkRuntimeStatId valueId, float multiplier) { }

	[CompilerGenerated]
	public override ISeasonalPerk get_Parent() { }

	public abstract bool TryApply(PerkRuntimeState state) { }

}

