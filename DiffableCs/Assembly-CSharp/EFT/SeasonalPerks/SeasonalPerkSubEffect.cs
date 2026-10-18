namespace EFT.SeasonalPerks;

public abstract class SeasonalPerkSubEffect
{
	[JsonProperty("enabled")]
	public readonly bool Enabled; //Field offset: 0x10

	protected SeasonalPerkSubEffect() { }

}

