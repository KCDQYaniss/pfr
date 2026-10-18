namespace EFT.Quests;

public abstract class Conditional`1 : IConditional, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__65_0; //Field offset: 0x0
		public static Func <>9__65_1; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <GetVisibilityCondition>b__65_0(KeyValuePair collection) { }

		internal IEnumerable <GetVisibilityCondition>b__65_1(Condition x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public MongoID conditionId; //Field offset: 0x0

		public <>c__DisplayClass65_0() { }

		internal bool <GetVisibilityCondition>b__2(Condition cond) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		public MongoID completedConditionId; //Field offset: 0x0

		public <>c__DisplayClass72_0() { }

		internal bool <UpdateCompletedConditions>b__0(Condition cond) { }

		internal bool <UpdateCompletedConditions>b__1(Condition condition) { }

	}

	[CompilerGenerated]
	private Action OnStatusChanged; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnShowConditionChangedNotification; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnConditionChanged; //Field offset: 0x0
	protected readonly CompositeDisposable CompositeDisposable; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Id>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ConditionCounterManager <ConditionCountersManager>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Dictionary <ProgressCheckers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private CompletedConditionsCollection <CompletedConditions>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private EQuestStatus <QuestStatus>k__BackingField; //Field offset: 0x0

	public event Action OnConditionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnShowConditionChangedNotification
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override CompletedConditionsCollection CompletedConditions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override ConditionCounterManager ConditionCountersManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public abstract ConditionsDict Conditions
	{
		 get { } //Length: 0
	}

	public override EQuestStatus[] CurrentStatusTransitions
	{
		 get { } //Length: 210
	}

	public abstract string Description
	{
		 get { } //Length: 0
	}

	public override string Id
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public abstract bool InstantComplete
	{
		 get { } //Length: 0
	}

	public bool IsActive
	{
		 get { } //Length: 21
	}

	public bool IsComplete
	{
		 get { } //Length: 8
	}

	public bool IsFailed
	{
		 get { } //Length: 26
	}

	public abstract ETaskPlayerSide PlayerSide
	{
		 get { } //Length: 0
	}

	public override Dictionary ProgressCheckers
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override EQuestStatus QuestStatus
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public abstract bool ReadyToFail
	{
		 get { } //Length: 0
	}

	public abstract Dictionary Rewards
	{
		 get { } //Length: 0
	}

	public abstract bool ServerOnly
	{
		 get { } //Length: 0
	}

	public abstract Sprite Sprite
	{
		 get { } //Length: 0
	}

	public abstract IReadOnlyDictionary StatusTransition
	{
		 get { } //Length: 0
	}

	protected Conditional`1(string id, Dictionary conditionCounters) { }

	[CompilerGenerated]
	public void add_OnConditionChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnShowConditionChangedNotification(Action value) { }

	[CompilerGenerated]
	public void add_OnStatusChanged(Action value) { }

	protected void CallOnConditionChangedEvent(TConditional conditional, bool showNotification) { }

	protected void CallOnStatusChangedEvent(TConditional conditional, bool notify) { }

	protected bool CheckConditionDone(Condition condition) { }

	protected void CheckForNextStatusChange(bool fromServer, bool canFail) { }

	public override void CheckForStatusChange(bool fromServer, bool canFail, bool notify = true) { }

	public abstract void CheckForStatusChange(EQuestStatus status, bool notify, bool fromServer, bool canFail, bool recursive = false) { }

	public override bool CheckVisibilityStatus(Condition condition) { }

	protected void CreateConditionHandlers() { }

	public override void DisconnectConditions() { }

	public override void Dispose() { }

	public virtual bool Equals(object otherConditional) { }

	[CompilerGenerated]
	public override CompletedConditionsCollection get_CompletedConditions() { }

	[CompilerGenerated]
	public override ConditionCounterManager get_ConditionCountersManager() { }

	public abstract ConditionsDict get_Conditions() { }

	public override EQuestStatus[] get_CurrentStatusTransitions() { }

	public abstract string get_Description() { }

	[CompilerGenerated]
	public override string get_Id() { }

	public abstract bool get_InstantComplete() { }

	public bool get_IsActive() { }

	public bool get_IsComplete() { }

	public bool get_IsFailed() { }

	public abstract ETaskPlayerSide get_PlayerSide() { }

	[CompilerGenerated]
	public override Dictionary get_ProgressCheckers() { }

	[CompilerGenerated]
	public override EQuestStatus get_QuestStatus() { }

	public abstract bool get_ReadyToFail() { }

	public abstract Dictionary get_Rewards() { }

	public abstract bool get_ServerOnly() { }

	public abstract Sprite get_Sprite() { }

	public abstract IReadOnlyDictionary get_StatusTransition() { }

	[CanBeNull]
	public override Condition GetCondition(MongoID conditionId) { }

	[CanBeNull]
	protected TCondition GetCondition(EQuestStatus status) { }

	public IEnumerable GetConditions(EQuestStatus status) { }

	public virtual int GetHashCode() { }

	[CanBeNull]
	public override Condition GetVisibilityCondition(MongoID conditionId) { }

	public override bool IsConditionDone(Condition condition) { }

	public override bool IsDone() { }

	public abstract Task LoadSprite(IImageLoader session) { }

	[CompilerGenerated]
	public void remove_OnConditionChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnShowConditionChangedNotification(Action value) { }

	[CompilerGenerated]
	public void remove_OnStatusChanged(Action value) { }

	public void ResetCounter(Condition condition) { }

	[CompilerGenerated]
	protected void set_CompletedConditions(CompletedConditionsCollection value) { }

	[CompilerGenerated]
	protected void set_QuestStatus(EQuestStatus value) { }

	public abstract void SetStatus(EQuestStatus status, bool notify, bool fromServer) { }

	public void TransitionStatus(EQuestStatus status, bool fromServer) { }

	public override bool TryGetStatusNote(EQuestStatus status, out MongoID noteId) { }

	protected bool UpdateCompletedConditions(EQuestStatus status, out bool showNotification) { }

}

