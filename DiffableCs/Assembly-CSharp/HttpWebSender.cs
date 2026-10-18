//Type is in global namespace

internal class HttpWebSender : ISender
{
	[CompilerGenerated]
	private struct <ExecuteOperationCoroutine>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HttpWebRequest request; //Field offset: 0x20
		public bool headersOnly; //Field offset: 0x28
		public Stopwatch stopwatch; //Field offset: 0x30
		public string url; //Field offset: 0x38
		private HttpWebResponse <response>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private string <errorText>5__3; //Field offset: 0x50
		private HttpStatusCode <responseCode>5__4; //Field offset: 0x58
		private Dictionary <responseHeaders>5__5; //Field offset: 0x60
		private StringBuilder <responseText>5__6; //Field offset: 0x68
		private byte[] <buffer>5__7; //Field offset: 0x70
		private byte[] <responseBytes>5__8; //Field offset: 0x78
		private int <responseBytesCount>5__9; //Field offset: 0x80
		private Stream <responseStream>5__10; //Field offset: 0x88
		private int <sanityCounter>5__11; //Field offset: 0x90
		private TaskAwaiter <>u__2; //Field offset: 0x98

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
		public int timeoutSeconds; //Field offset: 0x28
		public string method; //Field offset: 0x30
		public byte[] data; //Field offset: 0x38
		public HttpWebSender <>4__this; //Field offset: 0x40
		public Dictionary headers; //Field offset: 0x48
		public bool headersOnly; //Field offset: 0x50
		private Stopwatch <stopwatch>5__2; //Field offset: 0x58
		private HttpWebRequest <httpRequest>5__3; //Field offset: 0x60
		private Stream <dataStream>5__4; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x70
		private TaskAwaiter <>u__2; //Field offset: 0x78
		private TaskAwaiter <>u__3; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public HttpWebSender() { }

	[AsyncStateMachine(typeof(<ExecuteOperationCoroutine>d__1))]
	private Task ExecuteOperationCoroutine(string url, HttpWebRequest request, Stopwatch stopwatch, bool headersOnly) { }

	private bool OnCertificateValidation(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslpolicyerrors) { }

	[AsyncStateMachine(typeof(<WaitResponse>d__0))]
	public override Task WaitResponse(string url, byte[] data, Dictionary headers, int timeoutSeconds, string method = "POST", bool headersOnly = false) { }

}

