namespace EFT;

public sealed class PrestigeObtainData
{
	[JsonProperty("id")]
	public MongoID ItemId; //Field offset: 0x10
	[JsonProperty("location")]
	public LocationInGrid LocationInGrid; //Field offset: 0x28

	public PrestigeObtainData(MongoID itemId, LocationInGrid locationInGrid) { }

}

