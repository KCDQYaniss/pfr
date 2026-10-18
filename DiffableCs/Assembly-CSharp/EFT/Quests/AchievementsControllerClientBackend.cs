namespace EFT.Quests;

public sealed class AchievementsControllerClientBackend : AchievementsControllerClient
{
	private readonly QuestController _questController; //Field offset: 0x78
	private readonly QuestBook _questBook; //Field offset: 0x80
	private readonly IQuestSession _session; //Field offset: 0x88
	private ConditionsConnectorsManagerClientBackend _conditionsConnectorsManagerClientBackend; //Field offset: 0x90

	public private ConditionsConnectorsManagerClientBackend ConditionsConnectorsManagerClientBackend
	{
		 get { } //Length: 8
		private set { } //Length: 228
	}

	public AchievementsControllerClientBackend(Profile profile, InventoryController inventoryController, QuestController questController, IQuestSession session, bool updateAchievements = true) { }

	private void AchievementUnlockedHandler(string achievementId) { }

	protected virtual void AddQuestNote(Achievement conditional, Condition condition, QuestNoteTemplate noteTemplate) { }

	public virtual OperationResult ApplyReward(Achievement conditional, ItemController itemController, bool simulate) { }

	public virtual void Dispose() { }

	public ConditionsConnectorsManagerClientBackend get_ConditionsConnectorsManagerClientBackend() { }

	protected virtual void InitConditionsConnectorsManager() { }

	private void set_ConditionsConnectorsManagerClientBackend(ConditionsConnectorsManagerClientBackend value) { }

}

