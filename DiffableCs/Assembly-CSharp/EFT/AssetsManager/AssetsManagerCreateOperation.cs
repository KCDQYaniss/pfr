namespace EFT.AssetsManager;

public sealed class AssetsManagerCreateOperation : Operation
{
	[CompilerGenerated]
	private struct <Coroutine>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AssetsManagerSettings settings; //Field offset: 0x28
		public AssetsManagerCreateOperation <>4__this; //Field offset: 0x48
		private OperationAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public AssetsManagerCreateOperation() { }

	[AsyncStateMachine(typeof(<Coroutine>d__1))]
	private void Coroutine(AssetsManagerSettings settings) { }

	public static Operation Run(AssetsManagerSettings managerSettings) { }

}

