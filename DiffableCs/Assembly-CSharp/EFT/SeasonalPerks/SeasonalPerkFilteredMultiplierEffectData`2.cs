namespace EFT.SeasonalPerks;

public abstract class SeasonalPerkFilteredMultiplierEffectData`2 : SeasonalPerkFilteredEffectData
{
	[JsonProperty("multiplicator")]
	public readonly float Multiplier; //Field offset: 0x0

	protected SeasonalPerkFilteredMultiplierEffectData`2() { }

}

