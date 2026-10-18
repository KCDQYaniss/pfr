namespace EFT.SeasonalPerks;

[JsonObject(MemberSerialization::OptIn (1))]
public sealed class PersonalPerkData : SeasonalPerkData
{
	[JsonProperty("points")]
	public readonly int Points; //Field offset: 0x38
	[JsonProperty("mutuallyExclusiveSeasonalPerkIds", NullValueHandling = NullValueHandling::Ignore (1))]
	private MongoID[] _mutuallyExclusiveWith; //Field offset: 0x40

	public IEnumerable MutuallyExclusiveWith
	{
		 get { } //Length: 5
	}

	public PersonalPerkData() { }

	public IEnumerable get_MutuallyExclusiveWith() { }

}

