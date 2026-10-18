namespace EFT.SeasonBP;

public sealed class BattlePassItemExchangeSettingsData
{
	[JsonProperty("requiredDocuments")]
	public readonly int RequiredDocuments; //Field offset: 0x10
	[JsonProperty("receivedItems")]
	public readonly int ReceivedItems; //Field offset: 0x14
	[JsonProperty("image")]
	public readonly string Image; //Field offset: 0x18
	[JsonProperty("itemId")]
	public readonly string ItemId; //Field offset: 0x20

	public BattlePassItemExchangeSettingsData() { }

}

