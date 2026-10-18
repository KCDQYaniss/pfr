namespace EFT.InventoryLogic.Operations;

public sealed class BattlePassBuyItemOperationResult : BattlePassOperationResult
{
	public readonly int ExchangeCount; //Field offset: 0x30

	public BattlePassBuyItemOperationResult(BattlePassController controller, BattlePass battlePass, int exchangeCount, IEnumerable removeResults) { }

	protected virtual OperationResult ExecuteInternal() { }

}

