namespace EFT;

public sealed class BattlePassUniversalDocumentData
{
	[JsonProperty("Id")]
	public readonly MongoID Id; //Field offset: 0x10
	[JsonProperty("Image")]
	public readonly string ImageUrl; //Field offset: 0x28
	[JsonProperty("UnavailableImage")]
	public readonly string InactiveImageUrl; //Field offset: 0x30

	public BattlePassUniversalDocumentData() { }

}

