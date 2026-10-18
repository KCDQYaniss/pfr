namespace EFT.Quests;

public class QuestControllerClientBackend : QuestControllerClient
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Quest testQuest; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <ApplyReward>b__0(Condition condition) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		private struct <<LoadAssociatedQuestsAsync>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass9_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public QuestControllerClientBackend <>4__this; //Field offset: 0x10
		public MongoID itemId; //Field offset: 0x18
		public List result; //Field offset: 0x30

		public <>c__DisplayClass9_0() { }

		[AsyncStateMachine(typeof(<<LoadAssociatedQuestsAsync>b__0>d))]
		internal Task <LoadAssociatedQuestsAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <LoadAssociatedQuestsAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestControllerClientBackend <>4__this; //Field offset: 0x20
		public MongoID itemId; //Field offset: 0x28
		private <>c__DisplayClass9_0 <>8__1; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RestartFailedRestartableQuests>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestControllerClientBackend <>4__this; //Field offset: 0x20
		private Quest[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private Quest <quest>5__4; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendQuestFailToBackend>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestControllerClientBackend <>4__this; //Field offset: 0x20
		public string questId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private ConditionsConnectorsManagerQuestClientBackend _conditionsConnectorsManagerQuestClientBackend; //Field offset: 0xB8

	public ConditionsConnectorsManagerQuestClientBackend ConditionsConnectorsManagerClientBackend
	{
		 get { } //Length: 8
		 set { } //Length: 96
	}

	public QuestControllerClientBackend(Profile profile, InventoryController inventoryController, IQuestSession session) { }

	protected virtual void AddQuestNote(Quest conditional, Condition condition, QuestNoteTemplate noteTemplate) { }

	public virtual OperationResult ApplyReward(Quest conditional, ItemController itemController, bool simulate) { }

	public ConditionsConnectorsManagerQuestClientBackend get_ConditionsConnectorsManagerClientBackend() { }

	public virtual OperationResult HandoverItem(Quest quest, ConditionItem condition, IReadOnlyCollection items, bool simulate) { }

	protected virtual void InitConditionsConnectorsManager() { }

	[AsyncStateMachine(typeof(<LoadAssociatedQuestsAsync>d__9))]
	public Task LoadAssociatedQuestsAsync(MongoID itemId) { }

	public void NotifyAutoStartedQuests(QuestTemplate[] questTemplates) { }

	[AsyncStateMachine(typeof(<RestartFailedRestartableQuests>d__7))]
	private Task RestartFailedRestartableQuests() { }

	public virtual void Run() { }

	[AsyncStateMachine(typeof(<SendQuestFailToBackend>d__13))]
	protected virtual Task SendQuestFailToBackend(string questId) { }

	protected void set_ConditionsConnectorsManagerClientBackend(ConditionsConnectorsManagerQuestClientBackend value) { }

	public virtual void SetConditionalStatus(Quest quest, EQuestStatus status) { }

}

