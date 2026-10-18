namespace EFT.Console.Commands;

public static class Shared
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <UnloadUnusedResources>b__3_0(AsyncOperation _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public EEftScreenType eftScreenType; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <WaitScreenChanged>b__0(EEftScreenType st) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public EEftScreenType eftScreenType; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <WaitScreenChangedToAnother>b__0(EEftScreenType st) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Predicate isNeededScreenType; //Field offset: 0x10
		public TaskCompletionSource waiting; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <WaitScreenChanged>g__OnScreenChanged|0(EEftScreenType currentScreen) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public GameWorld gameWorld; //Field offset: 0x10
		public TaskCompletionSource waitGameStartedEvent; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <WaitGameStarted>g__AfterGameStarted|0() { }

	}

	[CompilerGenerated]
	private struct <WaitGameStarted>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private <>c__DisplayClass9_0 <>8__1; //Field offset: 0x20
		private CancellationTokenSource <timeout>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitScreenChanged>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Predicate isNeededScreenType; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly MethodInfo TryGenScreen_mi; //Field offset: 0x0

	public static Player Player
	{
		 get { } //Length: 53
	}

	private static Shared() { }

	public static void DeleteAll() { }

	public static Player get_Player() { }

	public static T GetUIScreen(EEftScreenType eftScreenType) { }

	public static void UnloadUnusedResources() { }

	[AsyncStateMachine(typeof(<WaitGameStarted>d__9))]
	public static Task WaitGameStarted() { }

	public static Task WaitScreenChanged(EEftScreenType eftScreenType) { }

	[AsyncStateMachine(typeof(<WaitScreenChanged>d__7))]
	public static Task WaitScreenChanged(Predicate isNeededScreenType) { }

	public static Task WaitScreenChangedToAnother(EEftScreenType eftScreenType) { }

}

