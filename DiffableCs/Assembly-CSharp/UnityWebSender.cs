//Type is in global namespace

internal class UnityWebSender : ISender
{
	[CompilerGenerated]
	private struct <ExecuteOperationCoroutine>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UnityWebRequest request; //Field offset: 0x20
		public Stopwatch stopwatch; //Field offset: 0x28
		public string url; //Field offset: 0x30
		private UnityWebRequestAsyncOperation <www>5__2; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitResponse>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x20
		public string method; //Field offset: 0x28
		public byte[] data; //Field offset: 0x30
		public bool headersOnly; //Field offset: 0x38
		public int timeoutSeconds; //Field offset: 0x3C
		public Dictionary headers; //Field offset: 0x40
		public UnityWebSender <>4__this; //Field offset: 0x48
		private UnityWebRequest <request>5__2; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public UnityWebSender() { }

	[AsyncStateMachine(typeof(<ExecuteOperationCoroutine>d__1))]
	private Task ExecuteOperationCoroutine(string url, UnityWebRequest request, Stopwatch stopwatch) { }

	[AsyncStateMachine(typeof(<WaitResponse>d__0))]
	public override Task WaitResponse(string url, byte[] data, Dictionary headers, int timeoutSeconds, string method = "POST", bool headersOnly = false) { }

}

