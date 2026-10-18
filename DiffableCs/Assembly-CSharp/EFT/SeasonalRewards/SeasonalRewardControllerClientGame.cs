namespace EFT.SeasonalRewards;

public sealed class SeasonalRewardControllerClientGame : SeasonalRewardControllerClient
{
	private readonly QuestBook _questBook; //Field offset: 0x80
	private ConditionsConnectorsManagerClientGame _conditionsConnectorsManagerClientGame; //Field offset: 0x88

	public private ConditionsConnectorsManagerClientGame ConditionsConnectorsManagerClientGame
	{
		 get { } //Length: 8
		private set { } //Length: 228
	}

	public virtual bool FromServer
	{
		 get { } //Length: 3
	}

	public SeasonalRewardControllerClientGame(Profile profile, InventoryController inventoryController, QuestBook questBook, IEftSession session) { }

	public ConditionsConnectorsManagerClientGame get_ConditionsConnectorsManagerClientGame() { }

	public virtual bool get_FromServer() { }

	protected virtual void InitConditionsConnectorsManager() { }

	private void set_ConditionsConnectorsManagerClientGame(ConditionsConnectorsManagerClientGame value) { }

}

