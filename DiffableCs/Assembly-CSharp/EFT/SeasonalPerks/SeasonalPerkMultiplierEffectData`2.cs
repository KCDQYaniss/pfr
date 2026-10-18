namespace EFT.SeasonalPerks;

[JsonObject(MemberSerialization::OptIn (1))]
public abstract class SeasonalPerkMultiplierEffectData`2 : SeasonalPerkEffectData
{
	[JsonProperty("multiplicator")]
	public readonly float Multiplier; //Field offset: 0x0

	protected SeasonalPerkMultiplierEffectData`2() { }

}

