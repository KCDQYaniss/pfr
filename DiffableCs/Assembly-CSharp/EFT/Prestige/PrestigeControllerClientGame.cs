namespace EFT.Prestige;

public sealed class PrestigeControllerClientGame : PrestigeControllerClient
{
	private readonly QuestBook _questBook; //Field offset: 0x68
	private ConditionsConnectorsManagerClientGame _conditionsConnectorsManagerClientGame; //Field offset: 0x70

	public virtual bool CanUpgrade
	{
		 get { } //Length: 3
	}

	public private ConditionsConnectorsManagerClientGame ConditionsConnectorsManagerClientGame
	{
		 get { } //Length: 5
		private set { } //Length: 228
	}

	public virtual bool FromServer
	{
		 get { } //Length: 3
	}

	public PrestigeControllerClientGame(Profile profile, InventoryController inventoryController, QuestBook questBook, IQuestSession session) { }

	public virtual bool get_CanUpgrade() { }

	public ConditionsConnectorsManagerClientGame get_ConditionsConnectorsManagerClientGame() { }

	public virtual bool get_FromServer() { }

	protected virtual void InitConditionsConnectorsManager() { }

	private void set_ConditionsConnectorsManagerClientGame(ConditionsConnectorsManagerClientGame value) { }

}

