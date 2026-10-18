namespace EFT.SeasonalPerks;

[JsonObject(MemberSerialization::OptIn (1))]
public abstract class SeasonalPerkFilteredEffectData`2 : SeasonalPerkEffectData
{
	[JsonProperty("itemFilter")]
	public readonly SeasonalPerkItemFilter ItemFilter; //Field offset: 0x0

	protected SeasonalPerkFilteredEffectData`2() { }

}

