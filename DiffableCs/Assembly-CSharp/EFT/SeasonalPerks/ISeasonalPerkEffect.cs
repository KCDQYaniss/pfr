namespace EFT.SeasonalPerks;

public interface ISeasonalPerkEffect
{

	public ISeasonalPerk Parent
	{
		 get { } //Length: 0
	}

	public ISeasonalPerk get_Parent() { }

	public bool TryApply(PerkRuntimeState runtimeState) { }

}

