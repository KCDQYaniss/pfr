namespace EFT;

public sealed class LastFoundCompletableStorage : IDisposable
{
	[CompilerGenerated]
	private struct <<SetLastFoundCompletable>g__ClearLastFoundTape|3_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LastFoundCompletableStorage <>4__this; //Field offset: 0x20
		private CancellationToken <token>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int DELAY = 10000; //Field offset: 0x0
	private readonly CancellationTokenSource _cancellationTokenSource; //Field offset: 0x10
	private CompletableItem _lastCompletable; //Field offset: 0x18

	public LastFoundCompletableStorage() { }

	[AsyncStateMachine(typeof(<<SetLastFoundCompletable>g__ClearLastFoundTape|3_0>d))]
	[CompilerGenerated]
	private Task <SetLastFoundCompletable>g__ClearLastFoundTape|3_0() { }

	public override void Dispose() { }

	public void SetLastFoundCompletable(CompletableItem completable) { }

	public bool TryGetLastFoundCompletable(out CompletableItem completable) { }

}

