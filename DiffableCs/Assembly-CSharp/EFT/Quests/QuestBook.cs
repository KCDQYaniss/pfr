namespace EFT.Quests;

public sealed class QuestBook : ConditionalBook, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <UpdateDailyQuests>b__16_0(RepeatableQuestsRange questRange) { }

	}

	[CompilerGenerated]
	private sealed class <>c__28`1
	{
		public static readonly <>c__28 <>9; //Field offset: 0x0
		public static Func <>9__28_0; //Field offset: 0x0

		private static <>c__28`1() { }

		public <>c__28`1() { }

		internal bool <GetConditionHandlersByZone>b__28_0(Quest quest) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public QuestStatusData statusData; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <SetQuestStatusData>b__0(QuestStatusData quest) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public QuestBook <>4__this; //Field offset: 0x10
		public int i; //Field offset: 0x18
		public Func <>9__0; //Field offset: 0x20

		public <>c__DisplayClass22_0() { }

		internal bool <RemoveConditionalsWithoutTemplate>b__0(QuestTemplate x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public QuestTemplate template; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal bool <TryCreateAutoStartQuest>b__0(Quest existingQuest) { }

		internal bool <TryCreateAutoStartQuest>b__1(QuestStatusData existingQuestData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public Quest quest; //Field offset: 0x10
		public DailyQuest dailyQuest; //Field offset: 0x18
		public QuestBook <>4__this; //Field offset: 0x20

		public <>c__DisplayClass24_0() { }

		internal void <CreateNewQuest>b__0() { }

		internal void <CreateNewQuest>b__1() { }

		internal void <CreateNewQuest>g__QuestExpiredHandler|2() { }

		internal void <CreateNewQuest>g__QuestFailedHandler|3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public QuestTemplate template; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <TryCreateQuest>b__0(Quest existingQuest) { }

		internal bool <TryCreateQuest>b__1(QuestStatusData existingQuestData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0`1
	{
		public string zoneId; //Field offset: 0x0

		public <>c__DisplayClass28_0`1() { }

		internal IEnumerable <GetConditionHandlersByZone>b__1(Quest quest) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_1`1
	{
		public Quest quest; //Field offset: 0x0
		public <>c__DisplayClass28_0 CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass28_1`1() { }

		internal bool <GetConditionHandlersByZone>b__2(T conditionZone) { }

		internal ConditionProgressChecker <GetConditionHandlersByZone>b__3(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public EQuestStatus status; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal bool <GetQuestsCount>b__0(Quest quest) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public string traderId; //Field offset: 0x10
		public QuestBook <>4__this; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal bool <GetQuests>b__0(Quest quest) { }

	}

	[CompilerGenerated]
	private struct <AwaitVisible>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Quest quest; //Field offset: 0x20
		public QuestBook <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitRepeatableQuests>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestBook <>4__this; //Field offset: 0x20
		public IQuestSession session; //Field offset: 0x28
		public Task prefetchedQuestsTask; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class LobbyOnlyQuestError : Error
	{

		public LobbyOnlyQuestError() { }

		public virtual string ToString() { }

	}

	private sealed class UnavailableQuestError : Error
	{
		private readonly IConditional _conditional; //Field offset: 0x10

		public UnavailableQuestError(IConditional conditional) { }

		public virtual string ToString() { }

	}

	[CompilerGenerated]
	private Action OnQuestExpired; //Field offset: 0x88
	[CompilerGenerated]
	private Action OnQuestFailed; //Field offset: 0x90
	private readonly List _questsData; //Field offset: 0x98
	private readonly bool _fromServer; //Field offset: 0xA0
	private readonly bool _inRaid; //Field offset: 0xA1
	private readonly EProfileType _profileType; //Field offset: 0xA4
	private readonly CompositeDisposable _unsubscriber; //Field offset: 0xA8
	private RepeatableQuestUpdater _repeatableQuestUpdater; //Field offset: 0xB0

	public event Action OnQuestExpired
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnQuestFailed
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public QuestBook(string profileId, EPlayerSide profileSide, List questsData, Dictionary conditionCounters, EProfileType profileType, bool fromServer, bool inRaid) { }

	[CompilerGenerated]
	private void <InitRepeatableQuests>b__14_0() { }

	[CompilerGenerated]
	public void add_OnQuestExpired(Action value) { }

	[CompilerGenerated]
	public void add_OnQuestFailed(Action value) { }

	public void AddTemplates(IEnumerable templates) { }

	[AsyncStateMachine(typeof(<AwaitVisible>d__27))]
	private Task AwaitVisible(Quest quest) { }

	private bool CanAcceptanceOrFinishing(QuestTemplate questTemplate) { }

	private bool CanProgress(QuestTemplate questTemplate) { }

	private Quest CreateNewQuest(QuestTemplate template, QuestStatusData questData) { }

	private void CreateQuests(IEnumerable templates) { }

	public virtual void Dispose() { }

	public IEnumerable GetConditionHandlersByZone(string zoneId) { }

	private IEnumerable GetQuests(string traderId) { }

	public int GetQuestsCount(string traderId) { }

	public int GetQuestsCount(string traderId, EQuestStatus status) { }

	public int GetQuestsSuccessCount(string traderId) { }

	[AsyncStateMachine(typeof(<InitRepeatableQuests>d__14))]
	public Task InitRepeatableQuests(IQuestSession session, Task prefetchedQuestsTask = null) { }

	public bool IsVisibleToCurrentProfile(Quest quest) { }

	private void Load() { }

	public virtual void LoadAll() { }

	private void NotifyNewQuest(RepeatableQuestTemplate newQuest) { }

	[CompilerGenerated]
	public void remove_OnQuestExpired(Action value) { }

	[CompilerGenerated]
	public void remove_OnQuestFailed(Action value) { }

	public virtual void RemoveConditionalsWithoutTemplate() { }

	public void RemoveQuestTemplate(QuestTemplate template) { }

	public void SetQuestStatusData(QuestStatusData[] questStatusData) { }

	private void SetupQuestLocalization(Quest quest) { }

	public Option TryCreateAutoStartQuest(QuestTemplate template) { }

	private Option TryCreateQuest(QuestTemplate template) { }

	public void UpdateDailyQuests(IEnumerable questsRanges, bool notify = false) { }

}

