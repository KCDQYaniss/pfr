namespace EFT;

internal static class MatchingOperation
{
	[CompilerGenerated]
	private struct <CancelMatching>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IClientSession session; //Field offset: 0x20
		public bool isPet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Execute>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EMatchingType type; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public RaidSettings raidSettings; //Field offset: 0x30
		public IClientSession session; //Field offset: 0x38
		public MatchingProgress matchingProgress; //Field offset: 0x40
		public string groupId; //Field offset: 0x48
		public int timeoutMinutes; //Field offset: 0x50
		public ClientMetricsEvents metricsEvents; //Field offset: 0x58
		private bool <isPet>5__2; //Field offset: 0x60
		private Task <gameJob>5__3; //Field offset: 0x68
		private Task <timeoutJob>5__4; //Field offset: 0x70
		private YieldAwaiter <>u__1; //Field offset: 0x78
		private TaskAwaiter <>u__2; //Field offset: 0x80
		private TaskAwaiter <>u__3; //Field offset: 0x88

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartSearchingTimeout>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int timeoutMinutes; //Field offset: 0x20
		public Task gameJob; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string MATCHING_TIMEOUT_ERROR = "matching/timeout"; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <ReadyToMatching>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <MatchingCanceledByPlayer>k__BackingField; //Field offset: 0x1

	public static bool MatchingCanceledByPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		 set { } //Length: 65
	}

	public static bool ReadyToMatching
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		 set { } //Length: 64
	}

	[AsyncStateMachine(typeof(<CancelMatching>d__11))]
	private static Task CancelMatching(IClientSession session, bool isPet) { }

	[AsyncStateMachine(typeof(<Execute>d__9))]
	public static Task Execute(IClientSession session, RaidSettings raidSettings, string groupId, EMatchingType type, CancellationToken cancellationToken, ClientMetricsEvents metricsEvents, int timeoutMinutes, MatchingProgress matchingProgress) { }

	[CompilerGenerated]
	public static bool get_MatchingCanceledByPlayer() { }

	[CompilerGenerated]
	public static bool get_ReadyToMatching() { }

	[CompilerGenerated]
	public static void set_MatchingCanceledByPlayer(bool value) { }

	[CompilerGenerated]
	public static void set_ReadyToMatching(bool value) { }

	[AsyncStateMachine(typeof(<StartSearchingTimeout>d__10))]
	private static Task StartSearchingTimeout(int timeoutMinutes, Task gameJob) { }

}

