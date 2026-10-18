namespace EFT.SeasonalPerks;

[JsonObject(MemberSerialization::OptIn (1))]
public abstract class SeasonalPerkData
{
	[JsonProperty("id")]
	public readonly MongoID Id; //Field offset: 0x10
	[JsonProperty("imageUrl")]
	public readonly string IconUrl; //Field offset: 0x28
	[JsonProperty("effects", NullValueHandling = NullValueHandling::Ignore (1))]
	private ISeasonalPerkEffectData[] _effects; //Field offset: 0x30

	public IEnumerable Effects
	{
		 get { } //Length: 76
	}

	protected SeasonalPerkData() { }

	public IEnumerable get_Effects() { }

}

