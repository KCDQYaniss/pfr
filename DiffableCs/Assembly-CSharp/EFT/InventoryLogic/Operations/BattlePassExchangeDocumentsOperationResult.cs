namespace EFT.InventoryLogic.Operations;

public sealed class BattlePassExchangeDocumentsOperationResult : BattlePassOperationResult
{
	public readonly BattlePassDocumentScheme DocumentScheme; //Field offset: 0x30
	public readonly int ExchangeCount; //Field offset: 0x38

	public BattlePassExchangeDocumentsOperationResult(BattlePassController controller, BattlePass battlePass, BattlePassDocumentScheme documentScheme, int exchangeCount, IEnumerable removeResults) { }

	protected virtual OperationResult ExecuteInternal() { }

}

