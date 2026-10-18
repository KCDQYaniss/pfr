namespace EFT.Quests;

public abstract class ConditionsConnectorsManagerServer`1 : ConditionsConnectorsManager
{

	protected ConditionsConnectorsManagerServer`1(Profile profile, InventoryController inventoryController, QuestBook questBook) { }

	public virtual EPlayerItems GetPlayerItemSource(ConditionItem condition) { }

	public virtual void SetConditionCurrentValue(Profile profile, TConditional conditional, Condition condition, double value, bool notify = true) { }

}

