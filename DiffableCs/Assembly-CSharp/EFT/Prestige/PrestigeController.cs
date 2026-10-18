namespace EFT.Prestige;

public abstract class PrestigeController : ConditionalController
{

	public abstract bool CanUpgrade
	{
		 get { } //Length: 0
	}

	private PrestigeTemplate NextLevelPrestigeTemplate
	{
		private get { } //Length: 406
	}

	public PrestigeLevel NextPrestigeLevel
	{
		 get { } //Length: 858
	}

	protected PrestigeController(Profile profile, InventoryController inventoryController) { }

	public virtual OperationResult ApplyReward(PrestigeLevel conditional, ItemController itemController, bool simulate) { }

	protected virtual ConditionalBook CreateConditionalList() { }

	public abstract bool get_CanUpgrade() { }

	private PrestigeTemplate get_NextLevelPrestigeTemplate() { }

	public PrestigeLevel get_NextPrestigeLevel() { }

	private static bool IsCompleted(MongoID templateId, IEnumerable completedPrestigeData) { }

	protected virtual void OnConditionValueChanged(PrestigeLevel prestige, EQuestStatus status, Condition condition, bool notify = true) { }

	public virtual void SetConditionalStatus(PrestigeLevel conditional, EQuestStatus status) { }

	protected virtual void TryNotifyConditionalStatusChanged(PrestigeLevel conditional) { }

	protected virtual void TryNotifyConditionChanged(PrestigeLevel achievement) { }

	protected virtual Task TryToInstantComplete(PrestigeLevel conditional) { }

}

