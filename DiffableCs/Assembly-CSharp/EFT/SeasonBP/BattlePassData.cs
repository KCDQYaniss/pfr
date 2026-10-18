namespace EFT.SeasonBP;

public sealed class BattlePassData
{
	[JsonProperty("id")]
	public readonly MongoID Id; //Field offset: 0x10
	[JsonProperty("pages")]
	public readonly IReadOnlyList Pages; //Field offset: 0x28
	[JsonProperty("exchangeRate")]
	public readonly int ExchangeRate; //Field offset: 0x30
	[JsonProperty("documents")]
	public readonly IReadOnlyList Documents; //Field offset: 0x38
	[JsonProperty("itemExchangeSettings")]
	public readonly BattlePassItemExchangeSettingsData ItemExchangeSettings; //Field offset: 0x40
	[JsonProperty("documentLimits")]
	public readonly BattlePassDocumentLimitSettingsData DocumentLimits; //Field offset: 0x48

	[JsonConstructor]
	public BattlePassData(MongoID id, int exchangeRate, IReadOnlyList documents, BattlePassItemExchangeSettingsData itemExchangeSettings, IReadOnlyList pages, BattlePassDocumentLimitSettingsData documentLimits) { }

}

