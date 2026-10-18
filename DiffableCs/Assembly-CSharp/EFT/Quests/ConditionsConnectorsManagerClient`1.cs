namespace EFT.Quests;

public abstract class ConditionsConnectorsManagerClient`1 : ConditionsConnectorsManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x0
		public static Func <>9__7_1; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal double <ConnectConditionLevelInGameMode>b__6_0(ConditionProgressChecker _) { }

		internal double <ConnectConditionQuestTime>b__7_0(ConditionProgressChecker _) { }

		internal double <ConnectConditionQuestTime>b__7_1(ConditionProgressChecker _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ConditionsConnectorsManagerClient <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionLevelInGameMode condition; //Field offset: 0x0

		public <>c__DisplayClass6_0() { }

		internal double <ConnectConditionLevelInGameMode>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionLevelInGameMode>b__2(ConditionProgressChecker _) { }

		internal void <ConnectConditionLevelInGameMode>g__OnUserLevelChanged|3(int level, int diff) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Quest questCast; //Field offset: 0x0
		public ConditionsConnectorsManagerClient <>4__this; //Field offset: 0x0
		public TConditional quest; //Field offset: 0x0

		public <>c__DisplayClass7_0() { }

		internal double <ConnectConditionQuestTime>b__2(ConditionProgressChecker _) { }

		internal void <ConnectConditionQuestTime>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_1
	{
		public IEnumerator timer; //Field offset: 0x0

		public <>c__DisplayClass7_1() { }

		internal void <ConnectConditionQuestTime>b__4(ConditionProgressChecker _) { }

	}

	[CompilerGenerated]
	private struct <FailConditional>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ConditionsConnectorsManagerClient <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private Action OnConditionQuestTimeExpired; //Field offset: 0x0
	protected readonly IQuestSession Session; //Field offset: 0x0

	public event Action OnConditionQuestTimeExpired
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected ConditionsConnectorsManagerClient`1(Profile profile, InventoryController inventoryController, QuestBook questBook, IQuestSession session) { }

	[CompilerGenerated]
	public void add_OnConditionQuestTimeExpired(Action value) { }

	private void ConnectConditionLevelInGameMode(TConditional conditional, EQuestStatus status, ConditionLevelInGameMode condition) { }

	protected void ConnectConditionQuestTime(TConditional quest, EQuestStatus status, ConditionQuestTime condition) { }

	[AsyncStateMachine(typeof(<FailConditional>d__8))]
	private Task FailConditional(TConditional conditional) { }

	protected virtual void InvokeConditionsConnector(TConditional conditional, EQuestStatus status, Condition condition) { }

	[CompilerGenerated]
	public void remove_OnConditionQuestTimeExpired(Action value) { }

}

