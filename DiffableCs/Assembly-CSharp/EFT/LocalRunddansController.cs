namespace EFT;

public sealed class LocalRunddansController : ClientRunddansController
{
	[CompilerGenerated]
	private struct <BuffDistributor>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken token; //Field offset: 0x20
		public int delay; //Field offset: 0x28
		public LocalRunddansController <>4__this; //Field offset: 0x30
		private GameTimer <gameTimer>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public LocalRunddansController(RunddansGlobalSettings settings, Location location) { }

	[AsyncStateMachine(typeof(<BuffDistributor>d__1))]
	private Task BuffDistributor(int delay, CancellationToken token) { }

	public virtual void InteractWithEventObject(Player player, InteractWithEventObjectPacket packet) { }

	protected virtual void OnTriggerStateChanged(EState state) { }

}

