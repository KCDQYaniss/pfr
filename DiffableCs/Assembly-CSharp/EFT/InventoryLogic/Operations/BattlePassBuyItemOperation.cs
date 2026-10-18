namespace EFT.InventoryLogic.Operations;

public sealed class BattlePassBuyItemOperation : BattlePassOperation
{
	private sealed class BattlePassBuyItemOperationCommand : BattlePassOperationCommand
	{

		protected virtual string ActionName
		{
			 get { } //Length: 49
		}

		public BattlePassBuyItemOperationCommand(BattlePassBuyItemOperationResult result, OwnerInfo owner) { }

		protected virtual string get_ActionName() { }

	}


	public BattlePassBuyItemOperation(ushort id, BattlePassBuyItemOperationResult battlePassResult) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

}

