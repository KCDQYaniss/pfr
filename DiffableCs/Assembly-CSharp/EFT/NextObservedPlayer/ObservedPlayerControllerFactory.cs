namespace EFT.NextObservedPlayer;

public class ObservedPlayerControllerFactory
{
	[CompilerGenerated]
	private struct <CreateInstance>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int id; //Field offset: 0x20
		public ObservedPlayerSpawnMessage message; //Field offset: 0x28
		private Task <task>5__2; //Field offset: 0xD0
		private TaskAwaiter <>u__1; //Field offset: 0xD8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public ObservedPlayerControllerFactory() { }

	[AsyncStateMachine(typeof(<CreateInstance>d__0))]
	public Task CreateInstance(int id, ObservedPlayerSpawnMessage message) { }

}

