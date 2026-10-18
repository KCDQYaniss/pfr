namespace EFT.InventoryLogic.Operations;

public sealed class BattlePassExchangeDocumentsOperation : BattlePassOperation
{
	private sealed class BattlePassExchangeDocumentsOperationCommand : BattlePassOperationCommand
	{
		[JsonProperty("receiveDocumentId")]
		public readonly MongoID ReceiveDocumentId; //Field offset: 0x38

		protected virtual string ActionName
		{
			 get { } //Length: 49
		}

		public BattlePassExchangeDocumentsOperationCommand(BattlePassExchangeDocumentsOperationResult result, OwnerInfo owner) { }

		protected virtual string get_ActionName() { }

	}


	public BattlePassExchangeDocumentsOperation(ushort id, BattlePassExchangeDocumentsOperationResult battlePassResult) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

}

