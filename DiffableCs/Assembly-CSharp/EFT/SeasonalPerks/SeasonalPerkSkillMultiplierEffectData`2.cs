namespace EFT.SeasonalPerks;

public abstract class SeasonalPerkSkillMultiplierEffectData`2 : SeasonalPerkSkillIdsEffectData
{
	[JsonProperty("multiplicator")]
	public readonly float Multiplier; //Field offset: 0x0

	protected SeasonalPerkSkillMultiplierEffectData`2() { }

}

