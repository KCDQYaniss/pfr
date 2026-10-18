namespace EFT.InventoryLogic.Operations;

public sealed class BattlePassClaimRewardOperationResult : BattlePassOperationResult
{
	public readonly BattlePassReward Reward; //Field offset: 0x30
	public readonly int UniversalDocuments; //Field offset: 0x38

	public BattlePassClaimRewardOperationResult(BattlePassController controller, BattlePassReward reward, int universalDocuments, IEnumerable removeResults) { }

	protected virtual OperationResult ExecuteInternal() { }

	public virtual void RollBack() { }

}

