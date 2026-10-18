namespace EFT.SeasonalPerks;

public sealed class CommonPerk : SeasonalPerk
{

	public virtual bool IsCommon
	{
		 get { } //Length: 3
	}

	public CommonPerk(CommonPerkData template, SeasonalPerkEffectParametersData effectParameters) { }

	public virtual bool get_IsCommon() { }

}

