//Type is in global namespace

public class PlayerInfoStatsStage : FinalStatisticScreenStage
{
	[CompilerGenerated]
	private struct <ShowState>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerInfoStatsStage <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private StatisticPanel _statisticPanel; //Field offset: 0xC0

	public PlayerInfoStatsStage() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[AsyncStateMachine(typeof(<ShowState>d__1))]
	public virtual Task ShowState() { }

}

