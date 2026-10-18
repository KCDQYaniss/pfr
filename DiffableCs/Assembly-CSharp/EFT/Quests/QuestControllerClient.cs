namespace EFT.Quests;

public abstract class QuestControllerClient : QuestController
{
	[CompilerGenerated]
	private struct <AcceptQuest>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestControllerClient <>4__this; //Field offset: 0x20
		public Quest quest; //Field offset: 0x28
		public bool simulate; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FinishQuest>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestControllerClient <>4__this; //Field offset: 0x20
		public Quest quest; //Field offset: 0x28
		public bool simulate; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryCreateNewAutoStartQuests>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable questTemplates; //Field offset: 0x20
		public QuestControllerClient <>4__this; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30
		private Option <result>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly IQuestSession <Session>k__BackingField; //Field offset: 0xA0
	private ConditionsConnectorsManagerClient _conditionsConnectorsManagerClient; //Field offset: 0xA8
	private IConditionalNotificationManager _notificationManager; //Field offset: 0xB0

	public ConditionsConnectorsManagerClient ConditionsConnectorsManagerClient
	{
		 get { } //Length: 8
		 set { } //Length: 680
	}

	protected IQuestSession Session
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected QuestControllerClient(Profile profile, InventoryController inventoryController, IQuestSession session) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(Quest quest, bool simulate) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__1(Quest quest, bool simulate) { }

	[AsyncStateMachine(typeof(<AcceptQuest>d__12))]
	public virtual Task AcceptQuest(Quest quest, bool simulate) { }

	public virtual void Dispose() { }

	[AsyncStateMachine(typeof(<FinishQuest>d__14))]
	public virtual Task FinishQuest(Quest quest, bool simulate) { }

	public ConditionsConnectorsManagerClient get_ConditionsConnectorsManagerClient() { }

	[CompilerGenerated]
	protected IQuestSession get_Session() { }

	public virtual OperationResult HandoverItem(Quest quest, ConditionItem condition, IReadOnlyCollection items, bool simulate) { }

	protected virtual void NotifyRewards(Quest quest, EQuestStatus status) { }

	public virtual void Run() { }

	protected void set_ConditionsConnectorsManagerClient(ConditionsConnectorsManagerClient value) { }

	public virtual void SetConditionalStatus(Quest conditional, EQuestStatus status) { }

	private void TimeRangeExpiredHandler(DailyQuest quest) { }

	[AsyncStateMachine(typeof(<TryCreateNewAutoStartQuests>d__15))]
	protected virtual Task TryCreateNewAutoStartQuests(IEnumerable questTemplates) { }

	protected virtual void TryNotifyConditionalStatusChanged(Quest quest) { }

	protected virtual void TryNotifyConditionChanged(Quest quest) { }

}

