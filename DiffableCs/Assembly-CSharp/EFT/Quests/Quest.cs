namespace EFT.Quests;

public abstract class Quest : Conditional
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_NecessaryConditions>b__17_0(Condition x) { }

	}

	[CompilerGenerated]
	private struct <AwaitVisible>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Quest <>4__this; //Field offset: 0x20
		private bool <visible>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadSprite>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Quest <>4__this; //Field offset: 0x20
		public IImageLoader session; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly IReadOnlyDictionary _statusTransition; //Field offset: 0x0
	private const string IS_VIEWED_KEY = "quest_{0}_isViewed"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnFailed; //Field offset: 0x58
	public readonly Dictionary StatusStartTimestamps; //Field offset: 0x60
	private readonly QuestStatusData _statusData; //Field offset: 0x68
	private QuestTemplate _template; //Field offset: 0x70
	private bool _invisibleOnClient; //Field offset: 0x78
	[CompilerGenerated]
	private int <StartTime>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private readonly Task <IsVisibleTask>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private bool <StatusHasBeenChangedInPveOffline>k__BackingField; //Field offset: 0x90
	protected readonly bool InRaid; //Field offset: 0x91
	private Nullable _isViewed; //Field offset: 0x92

	public event Action OnFailed
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public virtual ConditionsDict Conditions
	{
		 get { } //Length: 27
	}

	public virtual string Description
	{
		 get { } //Length: 29
	}

	public int FailTime
	{
		 get { } //Length: 222
	}

	public Sprite IconSprite
	{
		 get { } //Length: 30
	}

	public override EQuestIconType IconType
	{
		 get { } //Length: 26
	}

	public virtual bool InstantComplete
	{
		 get { } //Length: 27
	}

	public bool IsChangeAllowed
	{
		 get { } //Length: 115
	}

	[JsonIgnore]
	public bool IsViewed
	{
		 get { } //Length: 366
		 set { } //Length: 315
	}

	public private bool IsVisible
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Task IsVisibleTask
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override string Name
	{
		 get { } //Length: 29
	}

	public IEnumerable NecessaryConditions
	{
		 get { } //Length: 503
	}

	public virtual ETaskPlayerSide PlayerSide
	{
		 get { } //Length: 35
	}

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"absolute", "current"})]
	public ValueTuple Progress
	{
		 get { } //Length: 814
	}

	public override string QuestTypeName
	{
		 get { } //Length: 76
	}

	public virtual bool ReadyToFail
	{
		 get { } //Length: 75
	}

	public virtual Dictionary Rewards
	{
		 get { } //Length: 27
	}

	public virtual bool ServerOnly
	{
		 get { } //Length: 27
	}

	public virtual Sprite Sprite
	{
		 get { } //Length: 30
	}

	public private int StartTime
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool StatusHasBeenChangedInPveOffline
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public virtual IReadOnlyDictionary StatusTransition
	{
		 get { } //Length: 83
	}

	public private QuestTemplate Template
	{
		 get { } //Length: 5
		private set { } //Length: 213
	}

	private static Quest() { }

	protected Quest(QuestTemplate template, QuestStatusData statusData, Dictionary conditionCounters, bool fromServer, bool inRaid) { }

	[CompilerGenerated]
	public void add_OnFailed(Action value) { }

	[AsyncStateMachine(typeof(<AwaitVisible>d__68))]
	private Task AwaitVisible() { }

	private ValueTuple CalculateConditionProgress(Condition condition) { }

	public virtual void CheckForStatusChange(EQuestStatus status, bool notify, bool fromServer, bool canFail, bool recursive = false) { }

	public virtual ConditionsDict get_Conditions() { }

	public virtual string get_Description() { }

	public int get_FailTime() { }

	public Sprite get_IconSprite() { }

	public override EQuestIconType get_IconType() { }

	public virtual bool get_InstantComplete() { }

	public bool get_IsChangeAllowed() { }

	public bool get_IsViewed() { }

	[CompilerGenerated]
	public bool get_IsVisible() { }

	[CompilerGenerated]
	public Task get_IsVisibleTask() { }

	public override string get_Name() { }

	public IEnumerable get_NecessaryConditions() { }

	public virtual ETaskPlayerSide get_PlayerSide() { }

	public ValueTuple get_Progress() { }

	public override string get_QuestTypeName() { }

	public virtual bool get_ReadyToFail() { }

	public virtual Dictionary get_Rewards() { }

	public virtual bool get_ServerOnly() { }

	public virtual Sprite get_Sprite() { }

	[CompilerGenerated]
	public int get_StartTime() { }

	[CompilerGenerated]
	public bool get_StatusHasBeenChangedInPveOffline() { }

	public virtual IReadOnlyDictionary get_StatusTransition() { }

	public QuestTemplate get_Template() { }

	private TimeSpan GetQuestAvailabilityDelay(QuestStatusData questStatusData) { }

	private bool IsAvailabilityDelayReached(QuestStatusData questStatusData) { }

	public virtual bool IsDone() { }

	[AsyncStateMachine(typeof(<LoadSprite>d__74))]
	public virtual Task LoadSprite(IImageLoader session) { }

	[CompilerGenerated]
	public void remove_OnFailed(Action value) { }

	public void set_IsViewed(bool value) { }

	[CompilerGenerated]
	private void set_IsVisible(bool value) { }

	[CompilerGenerated]
	private void set_StartTime(int value) { }

	[CompilerGenerated]
	private void set_StatusHasBeenChangedInPveOffline(bool value) { }

	private void set_Template(QuestTemplate value) { }

	public virtual void SetStatus(EQuestStatus status, bool notify, bool fromServer) { }

	public virtual string ToString() { }

}

