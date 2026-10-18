namespace EFT.SeasonalPerks;

public abstract class SeasonalProfileCreatePerkEffect`2 : SeasonalPerkEffect
{

	protected SeasonalProfileCreatePerkEffect`2(TEffectTemplate template, ISeasonalPerk parent) { }

	public virtual bool TryApply(PerkRuntimeState state) { }

}

