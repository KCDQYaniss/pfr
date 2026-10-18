namespace EFT.Quests;

public sealed class DailyQuest : Quest
{
	[CompilerGenerated]
	private struct <WaitForExpiration>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DailyQuest <>4__this; //Field offset: 0x20
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string DAILY_QUEST_TYPE_NAME = "Daily"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnExpired; //Field offset: 0x98
	public readonly int ExpirationDate; //Field offset: 0xA0
	private TaskCompletionSource _completionSource; //Field offset: 0xA8

	public event Action OnExpired
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public virtual EQuestIconType IconType
	{
		 get { } //Length: 6
	}

	public bool NeedCountdown
	{
		 get { } //Length: 69
	}

	public virtual string QuestTypeName
	{
		 get { } //Length: 49
	}

	public DailyQuest(RepeatableQuestTemplate template, QuestStatusData statusData, Dictionary conditionCounters, bool fromServer, bool inRaid) { }

	[CompilerGenerated]
	public void add_OnExpired(Action value) { }

	public virtual EQuestIconType get_IconType() { }

	public bool get_NeedCountdown() { }

	public virtual string get_QuestTypeName() { }

	[CompilerGenerated]
	public void remove_OnExpired(Action value) { }

	public void SetExpired() { }

	[AsyncStateMachine(typeof(<WaitForExpiration>d__13))]
	private Task WaitForExpiration() { }

}

