namespace EFT.Quests;

public abstract class QuestController : ConditionalController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		private struct <<FinishQuest>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass25_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28
			private TaskAwaiter <>u__2; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public QuestController <>4__this; //Field offset: 0x10
		public Quest quest; //Field offset: 0x18

		public <>c__DisplayClass25_0() { }

		[AsyncStateMachine(typeof(<<FinishQuest>b__0>d))]
		internal Task <FinishQuest>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		private struct <<FailConditionalAsync>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass44_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28
			private TaskAwaiter <>u__2; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public QuestController <>4__this; //Field offset: 0x10
		public Quest quest; //Field offset: 0x18

		public <>c__DisplayClass44_0() { }

		[AsyncStateMachine(typeof(<<FailConditionalAsync>b__0>d))]
		internal Task <FailConditionalAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public string questTemplateId; //Field offset: 0x10

		public <>c__DisplayClass52_0() { }

		internal bool <CompleteConditionById>b__0(Quest quest) { }

	}

	[CompilerGenerated]
	private struct <FailConditionalAsync>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestController <>4__this; //Field offset: 0x20
		public Quest quest; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FinishQuest>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestController <>4__this; //Field offset: 0x20
		public Quest quest; //Field offset: 0x28
		public bool simulate; //Field offset: 0x30
		private OperationResult <finishResult>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleAutoStartQuestsDTO>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AutoStartQuestsDTO autoStartQuestsDto; //Field offset: 0x20
		public QuestController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <NewQuests>d__35 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Quest <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public QuestController <>4__this; //Field offset: 0x28
		private string traderId; //Field offset: 0x30
		public string <>3__traderId; //Field offset: 0x38
		private IEnumerator <>7__wrap1; //Field offset: 0x40

		private override Quest System.Collections.Generic.IEnumerator<EFT.Quests.Quest>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <NewQuests>d__35(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Quests.Quest>.GetEnumerator() { }

		[DebuggerHidden]
		private override Quest System.Collections.Generic.IEnumerator<EFT.Quests.Quest>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <TryFinishQuestAsync>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Quest quest; //Field offset: 0x20
		public QuestController <>4__this; //Field offset: 0x28
		private ConditionalFinishResult <finishQuestOperationResult>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryInstantFinishQuest>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestController <>4__this; //Field offset: 0x20
		public Quest conditional; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitAndExecuteAsync>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestController <>4__this; //Field offset: 0x20
		public Func action; //Field offset: 0x28
		private bool <hasEnteredSemaphore>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private Action OnNewQuestsAdded; //Field offset: 0x60
	[CompilerGenerated]
	private QuestBook <Quests>k__BackingField; //Field offset: 0x68
	public AchievementsBook Achievements; //Field offset: 0x70
	[CompilerGenerated]
	private readonly HashSet <QuestItemIdsRemoveInRaidList>k__BackingField; //Field offset: 0x78
	private readonly SemaphoreSlim _questFinalizeSemaphore; //Field offset: 0x80
	private TaskCompletionSource _questFinalizeTaskCompletionSource; //Field offset: 0x88
	private readonly object _taskLock; //Field offset: 0x90
	private readonly List _handoverItems; //Field offset: 0x98

	public event Action OnNewQuestsAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public Task BackendAwaitFinishQuestTask
	{
		 get { } //Length: 368
	}

	protected virtual bool CanFailConditionals
	{
		 get { } //Length: 3
	}

	public InventoryController PlayerInventoryController
	{
		 get { } //Length: 5
	}

	public HashSet QuestItemIdsRemoveInRaidList
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private QuestBook Quests
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected QuestController(Profile profile, InventoryController inventoryController) { }

	public override Task AcceptQuest(Quest quest, bool simulate) { }

	[CompilerGenerated]
	public void add_OnNewQuestsAdded(Action value) { }

	protected void CallOnNewQuestsAdded(Quest quest) { }

	public bool CanHandoverAnyItems(Quest quest) { }

	public bool CanHandoverItems(Quest quest, ConditionItem condition, bool partialHandover, bool displayWeaponAssemblyLog = false) { }

	public void CompleteConditionById(string questTemplateId, string conditionId) { }

	private void CompleteConditionGeneric(Quest quest, Condition condition) { }

	protected virtual ConditionalBook CreateConditionalList() { }

	public virtual void Dispose() { }

	[AsyncStateMachine(typeof(<FailConditionalAsync>d__44))]
	protected override Task FailConditionalAsync(Quest quest) { }

	private void FailConditionalHandler(Quest quest) { }

	[AsyncStateMachine(typeof(<FinishQuest>d__25))]
	public override Task FinishQuest(Quest quest, bool simulate) { }

	public Task get_BackendAwaitFinishQuestTask() { }

	protected virtual bool get_CanFailConditionals() { }

	public InventoryController get_PlayerInventoryController() { }

	[CompilerGenerated]
	public HashSet get_QuestItemIdsRemoveInRaidList() { }

	[CompilerGenerated]
	public QuestBook get_Quests() { }

	private static EQuestStatus GetConditionStatus(Quest quest, Condition condition) { }

	public void GetTraderQuestAvailability(string traderId, out bool hasAvailableToStart, out bool hasAvailableToFinish, out bool hasAvailableToHandover) { }

	[AsyncStateMachine(typeof(<HandleAutoStartQuestsDTO>d__41))]
	protected Task HandleAutoStartQuestsDTO(AutoStartQuestsDTO autoStartQuestsDto) { }

	public override OperationResult HandoverItem(Quest quest, ConditionItem condition, IReadOnlyCollection items, bool simulate) { }

	private bool HasEnoughHandoverItems(ConditionItem condition, double requiredItems) { }

	private bool HasEnoughWeaponAssemblies(ConditionWeaponAssembly condition, double requiredItems, bool displayLog) { }

	public bool IsQuestForCurrentProfile(Quest quest) { }

	private static bool ItemMatchesCondition(Item item, ConditionItem condition) { }

	protected virtual void ManageConditional(Quest conditional) { }

	protected virtual void ManageConditionsConnections(Quest conditional) { }

	[IteratorStateMachine(typeof(<NewQuests>d__35))]
	public IEnumerable NewQuests(string traderId = null) { }

	protected virtual void OnConditionalStatusChangedEvent(Quest conditional, bool notify) { }

	[CompilerGenerated]
	public void remove_OnNewQuestsAdded(Action value) { }

	protected override Task SendQuestCompleteToBackend(string questId) { }

	protected override Task SendQuestFailToBackend(string questId) { }

	[CompilerGenerated]
	private void set_Quests(QuestBook value) { }

	public Option TryAddNewQuestsByTemplate(QuestTemplate[] questTemplates) { }

	protected override Task TryCreateNewAutoStartQuests(IEnumerable questTemplates) { }

	[AsyncStateMachine(typeof(<TryFinishQuestAsync>d__43))]
	public Task TryFinishQuestAsync(Quest quest) { }

	[AsyncStateMachine(typeof(<TryInstantFinishQuest>d__45))]
	protected override Task TryInstantFinishQuest(Quest conditional) { }

	public bool TryToFindQuestWithItem(Item item, out Quest questWithItem, out ConditionItem conditionItem) { }

	protected virtual Task TryToInstantComplete(Quest conditional) { }

	private bool ValidateSide(Quest quest) { }

	[AsyncStateMachine(typeof(<WaitAndExecuteAsync>d__42))]
	protected Task WaitAndExecuteAsync(Func action) { }

}

