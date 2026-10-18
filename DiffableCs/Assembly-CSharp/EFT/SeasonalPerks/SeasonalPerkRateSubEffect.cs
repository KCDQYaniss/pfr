namespace EFT.SeasonalPerks;

public abstract class SeasonalPerkRateSubEffect : SeasonalPerkTimedSubEffect
{
	[JsonProperty("amount")]
	public readonly float Amount; //Field offset: 0x20

	protected SeasonalPerkRateSubEffect() { }

}

