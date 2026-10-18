namespace EFT.UI.Seasons;

[IsReadOnly]
public struct BattlePassDocumentExchangeSelection
{
	public readonly IEnumerable SourceDocuments; //Field offset: 0x0
	public readonly BattlePassDocumentScheme TargetDocument; //Field offset: 0x8
	public readonly EBattlePassExchangeMode ExchangeMode; //Field offset: 0x10

	public BattlePassDocumentExchangeSelection(IReadOnlyCollection sourceDocuments, BattlePassDocumentScheme targetDocument, EBattlePassExchangeMode exchangeMode) { }

}

