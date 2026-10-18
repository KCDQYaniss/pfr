namespace EFT.Quests;

public abstract class CompletableItemQuestAutoStarter : IQuestAutoStarter
{
	[CompilerGenerated]
	private Action OnQuestAutoStartCondition; //Field offset: 0x10
	private readonly Profile _profile; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Func <CanAutoStartQuest>k__BackingField; //Field offset: 0x20

	public override event Action OnQuestAutoStartCondition
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected Func CanAutoStartQuest
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CompletableItemQuestAutoStarter(Profile profile, Func canAutoStartQuest) { }

	[CompilerGenerated]
	public override void add_OnQuestAutoStartCondition(Action value) { }

	protected abstract void CompletableItemProgressChange(MongoID itemId, bool completed) { }

	public override void Connect() { }

	public override void Disconnect() { }

	[CompilerGenerated]
	protected Func get_CanAutoStartQuest() { }

	protected void RaiseAutoStartEvent(QuestTemplate questTemplate) { }

	[CompilerGenerated]
	public override void remove_OnQuestAutoStartCondition(Action value) { }

}

