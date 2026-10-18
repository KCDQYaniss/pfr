namespace EFT.NextObservedPlayer.Operations;

public class SafeTaskCompleteSource : TaskCompletionSource
{
	[CompilerGenerated]
	private struct <CompleteByTimeout>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public float t; //Field offset: 0x20
		public SafeTaskCompleteSource <>4__this; //Field offset: 0x28
		public Action callback; //Field offset: 0x30
		public string name; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public SafeTaskCompleteSource() { }

	public void Complete() { }

	[AsyncStateMachine(typeof(<CompleteByTimeout>d__2))]
	private Task CompleteByTimeout(string name, float t, Action callback = null) { }

	public SafeTaskCompleteSource WithCompleteByTimeout(string name, float t, Action callback = null) { }

}

