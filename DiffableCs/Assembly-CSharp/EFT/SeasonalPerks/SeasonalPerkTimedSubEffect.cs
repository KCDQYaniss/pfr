namespace EFT.SeasonalPerks;

public abstract class SeasonalPerkTimedSubEffect : SeasonalPerkSubEffect
{
	[JsonProperty("durationSeconds")]
	public readonly int DurationSeconds; //Field offset: 0x18

	protected SeasonalPerkTimedSubEffect() { }

}

