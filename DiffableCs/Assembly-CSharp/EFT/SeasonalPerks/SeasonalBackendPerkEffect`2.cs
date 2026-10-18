namespace EFT.SeasonalPerks;

public abstract class SeasonalBackendPerkEffect`2 : SeasonalPerkEffect
{

	protected SeasonalBackendPerkEffect`2(TEffectTemplate template, ISeasonalPerk parent) { }

	public virtual bool TryApply(PerkRuntimeState state) { }

}

