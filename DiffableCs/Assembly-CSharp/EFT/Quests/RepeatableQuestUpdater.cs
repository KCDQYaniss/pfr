namespace EFT.Quests;

public sealed class RepeatableQuestUpdater
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetDailyQuests>b__11_0(RepeatableQuestsRange questRange) { }

	}

	[CompilerGenerated]
	private struct <GetDailyQuests>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RepeatableQuestUpdater <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateDailyQuests>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RepeatableQuestUpdater <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int MIN_REPEAT_DELAY_SECONDS = 30; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnDailyQuestsUpdated; //Field offset: 0x10
	private readonly IQuestSession _session; //Field offset: 0x18
	private Task _prefetchedQuestsTask; //Field offset: 0x20
	private CancellationTokenSource _cancellation; //Field offset: 0x28
	private readonly TaskCompletionSource _loadingTaskSource; //Field offset: 0x30

	public event Action OnDailyQuestsUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public RepeatableQuestUpdater(IQuestSession session, Task prefetchedQuestsTask = null) { }

	[CompilerGenerated]
	public void add_OnDailyQuestsUpdated(Action value) { }

	private void ApplicationQuittingHandler() { }

	[AsyncStateMachine(typeof(<GetDailyQuests>d__11))]
	private Task GetDailyQuests() { }

	[CompilerGenerated]
	public void remove_OnDailyQuestsUpdated(Action value) { }

	public Task Run() { }

	public void StopUpdating() { }

	[AsyncStateMachine(typeof(<UpdateDailyQuests>d__10))]
	private Task UpdateDailyQuests() { }

}

