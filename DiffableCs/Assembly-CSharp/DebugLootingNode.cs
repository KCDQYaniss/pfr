//Type is in global namespace

public class DebugLootingNode : BaseNode
{
	[CompilerGenerated]
	private struct <InternalPhase>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int number; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LootingProcess>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DebugLootingNode <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Phase>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int number; //Field offset: 0x20
		public DebugLootingNode <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private CancellationTokenSource _tokenSource; //Field offset: 0x18
	private int _index; //Field offset: 0x20
	private Task _task; //Field offset: 0x28

	public DebugLootingNode(BotOwner bot) { }

	[AsyncStateMachine(typeof(<InternalPhase>d__7))]
	private Task InternalPhase(int number) { }

	[AsyncStateMachine(typeof(<LootingProcess>d__5))]
	public Task LootingProcess() { }

	[AsyncStateMachine(typeof(<Phase>d__6))]
	private Task Phase(int number) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

