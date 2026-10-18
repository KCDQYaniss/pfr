namespace EFT.SeasonBP;

public sealed class BattlePassDocumentSchemeData
{
	[JsonProperty("id")]
	public readonly MongoID Id; //Field offset: 0x10
	[JsonProperty("itemId")]
	public readonly MongoID TemplateId; //Field offset: 0x28
	[JsonProperty("imageUrl")]
	public readonly string ImageUrl; //Field offset: 0x40
	[JsonProperty("unavailableImageUrl")]
	public readonly string InactiveImageUrl; //Field offset: 0x48

	public BattlePassDocumentSchemeData() { }

}

