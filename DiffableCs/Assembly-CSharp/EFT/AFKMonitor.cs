namespace EFT;

public sealed class AFKMonitor
{
	[CompilerGenerated]
	private struct <AwaitInput>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public AFKMonitor <>4__this; //Field offset: 0x28
		private double <lastInputTime>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartWaiting>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AFKMonitor <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int TIME_TO_CANCEL_SECONDS = 30; //Field offset: 0x0
	private const string AFK_ERROR_HEADER = "Errors/AFKQuitHeader"; //Field offset: 0x0
	private const string AFK_ERROR_TEXT = "Errors/AFKQuitText"; //Field offset: 0x0
	private float _afkTimeout; //Field offset: 0x10
	private CancellationTokenSource _cancellationSource; //Field offset: 0x18
	private ErrorWindowContext _errorWindowContext; //Field offset: 0x20

	public AFKMonitor() { }

	[CompilerGenerated]
	private void <TryQuitApplication>g__AcceptHandler|9_0() { }

	[CompilerGenerated]
	private void <TryQuitApplication>g__CloseHandler|9_2() { }

	[CompilerGenerated]
	private void <TryQuitApplication>g__DeclineHandler|9_1() { }

	[AsyncStateMachine(typeof(<AwaitInput>d__11))]
	private Task AwaitInput(CancellationToken cancellationToken) { }

	private void QuitApplication() { }

	public void Start() { }

	[AsyncStateMachine(typeof(<StartWaiting>d__8))]
	private Task StartWaiting() { }

	public void Stop() { }

	private void TryQuitApplication() { }

}

