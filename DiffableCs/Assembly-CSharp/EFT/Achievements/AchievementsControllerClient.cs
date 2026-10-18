namespace EFT.Achievements;

public abstract class AchievementsControllerClient : AchievementsController
{
	protected readonly IQuestSession Session; //Field offset: 0x68
	private readonly IConditionalNotificationManager _notificationManager; //Field offset: 0x70

	protected AchievementsControllerClient(Profile profile, InventoryController inventoryController, IQuestSession session, bool updateAchievements) { }

	public virtual void SetConditionalStatus(Achievement conditional, EQuestStatus status) { }

	protected virtual void TryNotifyConditionalStatusChanged(Achievement achievement) { }

	protected virtual void TryNotifyConditionChanged(Achievement achievement) { }

	protected virtual Task TryToInstantComplete(Achievement conditional) { }

}

