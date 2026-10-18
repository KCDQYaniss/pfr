namespace EFT.InventoryLogic.Operations;

public sealed class BattlePassClaimRewardOperation : BattlePassOperation
{
	private sealed class BattlePassClaimRewardOperationCommand : BattlePassOperationCommand
	{
		[JsonProperty("rewardId")]
		public readonly string RewardId; //Field offset: 0x38
		[JsonProperty("universalDocuments")]
		public readonly int UniversalDocuments; //Field offset: 0x40

		protected virtual string ActionName
		{
			 get { } //Length: 49
		}

		public BattlePassClaimRewardOperationCommand(BattlePassClaimRewardOperationResult result, OwnerInfo owner) { }

		protected virtual string get_ActionName() { }

	}


	public BattlePassClaimRewardOperation(ushort id, BattlePassClaimRewardOperationResult battlePassResult) { }

	public virtual void Dispose() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

}

