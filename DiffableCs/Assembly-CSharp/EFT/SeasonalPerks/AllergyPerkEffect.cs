namespace EFT.SeasonalPerks;

public sealed class AllergyPerkEffect : SeasonalPerkEffect
{
	private readonly List _enabledSubEffects; //Field offset: 0x20
	public readonly IReadOnlyCollection TargetItems; //Field offset: 0x28
	public readonly bool HasEnabledClientSubEffects; //Field offset: 0x30

	public IEnumerable EnabledSubEffects
	{
		 get { } //Length: 5
	}

	public AllergyPerkEffect(AllergyPerkEffectData template, ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

	public IEnumerable get_EnabledSubEffects() { }

	public virtual bool TryApply(PerkRuntimeState state) { }

}

