namespace EFT.SeasonalRewards;

public abstract class SeasonalRewardControllerClient : SeasonalRewardController
{
	protected readonly IEftSession Session; //Field offset: 0x70
	private readonly IConditionalNotificationManager _notificationManager; //Field offset: 0x78

	protected SeasonalRewardControllerClient(Profile profile, InventoryController inventoryController, IEftSession session) { }

	protected virtual void NotifyRewards(SeasonalReward reward, EQuestStatus status) { }

	public virtual void SetConditionalStatus(SeasonalReward conditional, EQuestStatus status) { }

	protected virtual void TryNotifyConditionalStatusChanged(SeasonalReward reward) { }

	protected virtual void TryNotifyConditionChanged(SeasonalReward reward) { }

	protected virtual Task TryToInstantComplete(SeasonalReward conditional) { }

}

