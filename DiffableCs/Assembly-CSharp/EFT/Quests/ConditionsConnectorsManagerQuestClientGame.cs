namespace EFT.Quests;

public sealed class ConditionsConnectorsManagerQuestClientGame : ConditionsConnectorsManagerClientGame
{

	public ConditionsConnectorsManagerQuestClientGame(Profile profile, InventoryController inventoryController, QuestBook questBook, IQuestSession session) { }

	protected virtual int GetFindItemConditionCount(Quest quest, ConditionFindItem condition) { }

	protected virtual int GetItemsForConditionCount(Inventory inventory, ConditionFindItem condition) { }

	protected virtual void InvokeConditionsConnector(Quest conditional, EQuestStatus status, Condition condition) { }

}

