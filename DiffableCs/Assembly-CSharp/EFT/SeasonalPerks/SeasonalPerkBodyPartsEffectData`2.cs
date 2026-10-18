namespace EFT.SeasonalPerks;

public abstract class SeasonalPerkBodyPartsEffectData`2 : SeasonalPerkEffectData
{
	[JsonProperty("bodyPartTypes", ItemConverterType = typeof(EFT.EnumConverter`1<EFT.SeasonalPerks.EPerkBodyPartType>))]
	private EPerkBodyPartType[] _bodyPartTypes; //Field offset: 0x0

	public IEnumerable BodyPartTypes
	{
		 get { } //Length: 5
	}

	protected SeasonalPerkBodyPartsEffectData`2() { }

	public IEnumerable get_BodyPartTypes() { }

}

