namespace EFT.SeasonalRewards;

public sealed class SeasonalRewardControllerClientBackend : SeasonalRewardControllerClient
{
	private readonly QuestBook _questBook; //Field offset: 0x80
	private ConditionsConnectorsManagerClientBackend _conditionsConnectorsManagerClientBackend; //Field offset: 0x88

	public private ConditionsConnectorsManagerClientBackend ConditionsConnectorsManagerClientBackend
	{
		 get { } //Length: 8
		private set { } //Length: 228
	}

	public SeasonalRewardControllerClientBackend(Profile profile, InventoryController inventoryController, QuestBook questBook, IEftSession session) { }

	protected virtual void AddQuestNote(SeasonalReward conditional, Condition condition, QuestNoteTemplate noteTemplate) { }

	public ConditionsConnectorsManagerClientBackend get_ConditionsConnectorsManagerClientBackend() { }

	protected virtual void InitConditionsConnectorsManager() { }

	private void set_ConditionsConnectorsManagerClientBackend(ConditionsConnectorsManagerClientBackend value) { }

}

