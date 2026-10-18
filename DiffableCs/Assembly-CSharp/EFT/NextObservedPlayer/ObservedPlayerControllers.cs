namespace EFT.NextObservedPlayer;

public class ObservedPlayerControllers : Dictionary
{
	[CompilerGenerated]
	private struct <CreateInstance>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerControllers <>4__this; //Field offset: 0x20
		public int id; //Field offset: 0x28
		public ObservedPlayerSpawnMessage message; //Field offset: 0x30
		private Task <task>5__2; //Field offset: 0xD8
		private TaskAwaiter <>u__1; //Field offset: 0xE0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private ObservedPlayerControllerFactory _factory; //Field offset: 0x50

	public ObservedPlayerControllers(ObservedPlayerControllerFactory factory) { }

	[AsyncStateMachine(typeof(<CreateInstance>d__2))]
	public Task CreateInstance(int id, ObservedPlayerSpawnMessage message) { }

	public void RemoveInstance(int id) { }

}

