namespace EFT.Quests;

public sealed class QuestControllerClientLocalGame : QuestControllerClientBackend, IActiveQuestController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Quest testQuest; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <ApplyReward>b__0(Condition condition) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public QuestStatusData questStatus; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <ManageQuestStatusesForPveOfflineGameEnd>b__0(Quest q) { }

	}

	[CompilerGenerated]
	private struct <FailConditionalAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestControllerClientLocalGame <>4__this; //Field offset: 0x20
		public Quest quest; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendQuestCompleteToBackend>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestControllerClientLocalGame <>4__this; //Field offset: 0x20
		public string questId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendQuestFailToBackend>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestControllerClientLocalGame <>4__this; //Field offset: 0x20
		public string questId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IPlayerSearchController _searchController; //Field offset: 0xC0
	private AutoStartConnectorsManager _autoStartConnectorManager; //Field offset: 0xC8

	protected virtual bool InRaid
	{
		 get { } //Length: 3
	}

	public QuestControllerClientLocalGame(Profile profile, InventoryController inventoryController, IPlayerSearchController searchController, IQuestSession session) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(Quest quest) { }

	protected virtual void AddQuestNote(Quest conditional, Condition condition, QuestNoteTemplate noteTemplate) { }

	public virtual OperationResult ApplyReward(Quest conditional, ItemController itemController, bool simulate) { }

	private void AutoStartQuestHandler(QuestTemplate questTemplate) { }

	private override void EFT.Quests.IActiveQuestController.CompleteConditionExternal(string questTemplateId, string conditionTemplateId) { }

	[AsyncStateMachine(typeof(<FailConditionalAsync>d__11))]
	protected virtual Task FailConditionalAsync(Quest quest) { }

	protected virtual bool get_InRaid() { }

	protected virtual void InitConditionsConnectorsManager() { }

	public void ManageQuestStatusesForPveOfflineGameEnd() { }

	[AsyncStateMachine(typeof(<SendQuestCompleteToBackend>d__10))]
	protected virtual Task SendQuestCompleteToBackend(string questId) { }

	[AsyncStateMachine(typeof(<SendQuestFailToBackend>d__9))]
	protected virtual Task SendQuestFailToBackend(string questId) { }

}

