namespace EFT.SeasonalPerks;

public abstract class SeasonalPerkSkillIdsEffectData`2 : SeasonalPerkEffectData
{
	[JsonProperty("skillIds", ItemConverterType = typeof(EFT.EnumConverter`1<EFT.ESkillId>))]
	private ESkillId[] _skillIds; //Field offset: 0x0

	public IReadOnlyCollection SkillIds
	{
		 get { } //Length: 5
	}

	protected SeasonalPerkSkillIdsEffectData`2() { }

	public IReadOnlyCollection get_SkillIds() { }

}

