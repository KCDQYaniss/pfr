namespace EFT.SeasonalPerks;

[JsonObject(MemberSerialization::OptIn (1))]
public sealed class SeasonalPerkItemFilter
{
	[JsonProperty("include", NullValueHandling = NullValueHandling::Ignore (1))]
	private SeasonalPerkItemFilterRule[] _include; //Field offset: 0x10
	[JsonProperty("exclude", NullValueHandling = NullValueHandling::Ignore (1))]
	private SeasonalPerkItemFilterRule[] _exclude; //Field offset: 0x18
	private Nullable _hasRules; //Field offset: 0x20

	public IReadOnlyCollection Exclude
	{
		 get { } //Length: 5
	}

	public bool HasRules
	{
		 get { } //Length: 168
	}

	public IReadOnlyCollection Include
	{
		 get { } //Length: 5
	}

	public SeasonalPerkItemFilter() { }

	public IReadOnlyCollection get_Exclude() { }

	public bool get_HasRules() { }

	public IReadOnlyCollection get_Include() { }

}

