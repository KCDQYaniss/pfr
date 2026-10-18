namespace EFT.SeasonalPerks;

[JsonObject(MemberSerialization::OptIn (1))]
public sealed class SeasonalPerksData
{
	[JsonProperty("common", NullValueHandling = NullValueHandling::Ignore (1))]
	private CommonPerkData[] _commonPerks; //Field offset: 0x10
	[JsonProperty("personal", NullValueHandling = NullValueHandling::Ignore (1))]
	private PersonalPerkData[] _personalPerks; //Field offset: 0x18

	public IEnumerable CommonPerks
	{
		 get { } //Length: 5
	}

	public IEnumerable PersonalPerks
	{
		 get { } //Length: 5
	}

	public SeasonalPerksData() { }

	public IEnumerable CreateCommonPerks(SeasonalPerkEffectParametersData effectParameters) { }

	public IEnumerable CreateCommonPerks(SeasonalPerkEffectParametersData effectParameters, IReadOnlyCollection activePerkIds) { }

	public IEnumerable CreatePersonalPerks(SeasonalPerkEffectParametersData effectParameters) { }

	public IEnumerable CreatePersonalPerks(SeasonalPerkEffectParametersData effectParameters, IReadOnlyCollection activePerkIds) { }

	public IEnumerable get_CommonPerks() { }

	public IEnumerable get_PersonalPerks() { }

	public bool TryGetPerk(MongoID perkId, out SeasonalPerkData perkData) { }

}

