namespace EFT.Quests;

public sealed class QuestControllerClientGame : QuestControllerClient
{
	private ConditionsConnectorsManagerQuestClientGame _conditionsConnectorsManagerQuestClientGame; //Field offset: 0xB8

	public private ConditionsConnectorsManagerQuestClientGame ConditionsConnectorsManagerClientGame
	{
		 get { } //Length: 8
		private set { } //Length: 96
	}

	public virtual bool FromServer
	{
		 get { } //Length: 3
	}

	public QuestControllerClientGame(Profile profile, InventoryController inventoryController, IQuestSession session) { }

	public virtual OperationResult ApplyReward(Quest conditional, ItemController itemController, bool simulate) { }

	public ConditionsConnectorsManagerQuestClientGame get_ConditionsConnectorsManagerClientGame() { }

	public virtual bool get_FromServer() { }

	protected virtual void InitConditionsConnectorsManager() { }

	private void set_ConditionsConnectorsManagerClientGame(ConditionsConnectorsManagerQuestClientGame value) { }

	protected virtual Task TryInstantFinishQuest(Quest conditional) { }

}

