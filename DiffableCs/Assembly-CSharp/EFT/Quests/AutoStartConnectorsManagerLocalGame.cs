namespace EFT.Quests;

public class AutoStartConnectorsManagerLocalGame : AutoStartConnectorsManager
{
	private QuestControllerClientLocalGame _questController; //Field offset: 0x40

	public AutoStartConnectorsManagerLocalGame(QuestBook quests, Profile profile, InventoryController inventoryController, QuestControllerClientLocalGame questController) { }

	protected virtual IEnumerable CreateStartersInternal() { }

}

