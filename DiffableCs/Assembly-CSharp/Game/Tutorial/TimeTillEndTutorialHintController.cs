namespace Game.Tutorial;

public sealed class TimeTillEndTutorialHintController : BaseTutorialHintController
{
	[CompilerGenerated]
	private struct <SessionTimerHint>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public float seconds; //Field offset: 0x20
		public TimeTillEndTutorialHintController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private float[] _sessionTimeHints; //Field offset: 0x30
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0x38

	public TimeTillEndTutorialHintController(TutorialHintData hint, Player player, Action showHint, Action closeHint) { }

	public virtual void Dispose() { }

	[AsyncStateMachine(typeof(<SessionTimerHint>d__3))]
	private Task SessionTimerHint(float seconds, TutorialHintData message) { }

}

