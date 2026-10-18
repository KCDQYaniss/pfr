namespace EFT.AssetsManager;

public class LoadSceneOperation : Operation
{
	[CompilerGenerated]
	private struct <ActivateScene>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LoadSceneOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public string Info; //Field offset: 0x38
	[CompilerGenerated]
	private AsyncOperation <AsyncOperation>k__BackingField; //Field offset: 0x40

	protected AsyncOperation AsyncOperation
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public LoadSceneOperation() { }

	[AsyncStateMachine(typeof(<ActivateScene>d__5))]
	public Task ActivateScene() { }

	[CompilerGenerated]
	protected AsyncOperation get_AsyncOperation() { }

	[CompilerGenerated]
	protected void set_AsyncOperation(AsyncOperation value) { }

}

