namespace EFT.Quests;

public sealed class AchievementsControllerClientGame : AchievementsControllerClient
{
	private readonly QuestBook _questBook; //Field offset: 0x78
	private ConditionsConnectorsManagerClientGame _connectorsManager; //Field offset: 0x80

	public private ConditionsConnectorsManagerClientGame ConditionsConnectorsManagerClientGame
	{
		 get { } //Length: 8
		private set { } //Length: 228
	}

	public virtual bool FromServer
	{
		 get { } //Length: 3
	}

	public AchievementsControllerClientGame(Profile profile, InventoryController inventoryController, QuestBook questBook, IQuestSession session, bool updateAchievements) { }

	public virtual OperationResult ApplyReward(Achievement conditional, ItemController itemController, bool simulate) { }

	public ConditionsConnectorsManagerClientGame get_ConditionsConnectorsManagerClientGame() { }

	public virtual bool get_FromServer() { }

	protected virtual void InitConditionsConnectorsManager() { }

	private void set_ConditionsConnectorsManagerClientGame(ConditionsConnectorsManagerClientGame value) { }

}

