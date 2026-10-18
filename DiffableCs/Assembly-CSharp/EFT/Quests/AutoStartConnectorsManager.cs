namespace EFT.Quests;

public abstract class AutoStartConnectorsManager
{
	[CompilerGenerated]
	private Action OnQuestAutoStartCondition; //Field offset: 0x10
	[CompilerGenerated]
	private readonly QuestBook <Quests>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Profile <Profile>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly InventoryController <InventoryController>k__BackingField; //Field offset: 0x28
	private readonly List _starters; //Field offset: 0x30
	private readonly HashSet _alreadyStartedQuests; //Field offset: 0x38

	public event Action OnQuestAutoStartCondition
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected InventoryController InventoryController
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected Profile Profile
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected QuestBook Quests
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AutoStartConnectorsManager(QuestBook quests, Profile profile, InventoryController inventoryController) { }

	[CompilerGenerated]
	public void add_OnQuestAutoStartCondition(Action value) { }

	private void CacheAlreadyStartedQuests() { }

	protected bool CanAutoStartQuest(string questId) { }

	public void CreateStarters() { }

	protected abstract IEnumerable CreateStartersInternal() { }

	public void Dispose() { }

	[CompilerGenerated]
	protected InventoryController get_InventoryController() { }

	[CompilerGenerated]
	protected Profile get_Profile() { }

	[CompilerGenerated]
	protected QuestBook get_Quests() { }

	protected void RaiseAutoStartEvent(QuestTemplate template) { }

	[CompilerGenerated]
	public void remove_OnQuestAutoStartCondition(Action value) { }

}

