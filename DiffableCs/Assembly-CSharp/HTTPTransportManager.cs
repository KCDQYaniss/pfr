//Type is in global namespace

internal sealed class HTTPTransportManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__36_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <RunConnectionDiagnostics>b__36_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0`1
	{
		public HTTPTransportManager <>4__this; //Field offset: 0x0
		public BackendRequestParams backRequest; //Field offset: 0x0

		public <>c__DisplayClass32_0`1() { }

		internal void <SendAndHandleRetries>b__2() { }

		internal ERequestErrorHandlingResult <SendAndHandleRetries>g__HandleGenericException|0(int code, string message) { }

		internal ERequestErrorHandlingResult <SendAndHandleRetries>g__HandleNetworkException|1(HTTPNetworkException netwExc) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public string separator; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

		internal string <ToString>b__0(string current, KeyValuePair item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0`1
	{
		public HTTPTransportManager <>4__this; //Field offset: 0x0
		public BackendRequestParams backRequest; //Field offset: 0x0
		public ResponseData responseData; //Field offset: 0x0
		public string responseText; //Field offset: 0x0

		public <>c__DisplayClass35_0`1() { }

		internal string <ExecuteRequest>b__0() { }

		internal T <ExecuteRequest>b__1() { }

	}

	[CompilerGenerated]
	private struct <ExecuteRequest>d__35`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public HTTPTransportManager <>4__this; //Field offset: 0x0
		public BackendRequestParams backRequest; //Field offset: 0x0
		private <>c__DisplayClass35_0 <>8__1; //Field offset: 0x0
		private T <result>5__2; //Field offset: 0x0
		private Exception <exc>5__3; //Field offset: 0x0
		private double <downloadSeconds>5__4; //Field offset: 0x0
		private double <parseSeconds>5__5; //Field offset: 0x0
		private Nullable <parseStart>5__6; //Field offset: 0x0
		private DateTime <downloadStart>5__7; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0
		private TaskAwaiter <>u__3; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendAndHandleRetries>d__32`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public HTTPTransportManager <>4__this; //Field offset: 0x0
		public BackendRequestParams backRequest; //Field offset: 0x0
		private <>c__DisplayClass32_0 <>8__1; //Field offset: 0x0
		private HTTPRequestResult <result>5__2; //Field offset: 0x0
		private BackendException <resultException>5__3; //Field offset: 0x0
		private bool <shouldRetry>5__4; //Field offset: 0x0
		private bool <expectedError>5__5; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0
		private int <maxRetries>5__6; //Field offset: 0x0
		private int <curTry>5__7; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct HTTPRequestResult`1
	{
		public T ParsedObject; //Field offset: 0x0
		public string ResponseText; //Field offset: 0x0
		public double DownloadSeconds; //Field offset: 0x0
		public double ParseSeconds; //Field offset: 0x0

	}

	internal class IVPoolStrategy : IPooledObjectPolicy
	{

		public IVPoolStrategy() { }

		public override byte[] Create() { }

		public override bool Return(byte[] obj) { }

	}

	[ThreadStatic]
	private static JsonSerializer _responseJsonSerializer; //Field offset: 0x80000000
	private const int IV_LENGTH = 16; //Field offset: 0x0
	private static readonly byte[] _key; //Field offset: 0x0
	private static readonly ObjectPool _ivPool; //Field offset: 0x8
	private DateTime _lastSucceedResponse; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnSessionError; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnErrorHandledWithResult; //Field offset: 0x20
	private readonly bool _zipped; //Field offset: 0x28
	private readonly RequestFailHandler _failHandler; //Field offset: 0x30
	private StringBuilder _sendrequestLogSB; //Field offset: 0x38
	[CompilerGenerated]
	private bool <WebDiagnosticsEnabled>k__BackingField; //Field offset: 0x40

	public event Action OnErrorHandledWithResult
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSessionError
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private ISender _webSender
	{
		private get { } //Length: 175
	}

	public private DateTime LastSucceedResponse
	{
		 get { } //Length: 252
		private set { } //Length: 249
	}

	private SenderLogger Logger
	{
		private get { } //Length: 69
	}

	public bool WebDiagnosticsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static HTTPTransportManager() { }

	internal HTTPTransportManager(string appVersion, string phpSessionId = null, bool zipped = false, RequestFailHandler failHandler = null) { }

	[CompilerGenerated]
	public void add_OnErrorHandledWithResult(Action value) { }

	[CompilerGenerated]
	public void add_OnSessionError(Action value) { }

	private Dictionary CreateHeadersForRequest(BackendRequestParams bRequest) { }

	private byte[] Decrypt(byte[] data, string encryption) { }

	private static byte[] DecryptFromBytesAES(byte[] cipherText, int cipherBytesLength, byte[] Key, byte[] IV) { }

	[AsyncStateMachine(typeof(<ExecuteRequest>d__35`1))]
	private Task ExecuteRequest(BackendRequestParams backRequest) { }

	private T ExtractResponseResult(BackendRequestParams backRequest, string responseJsonText) { }

	private ISender get__webSender() { }

	public DateTime get_LastSucceedResponse() { }

	private SenderLogger get_Logger() { }

	[CompilerGenerated]
	public bool get_WebDiagnosticsEnabled() { }

	private static string GetEncryptionAlgorithm(IDictionary responseHeaders) { }

	private static JsonSerializer GetResponseJsonSerializer() { }

	private T GetResponseResult(BackendRequestParams backRequest, ResponseData backResponse) { }

	private void LogRequest(BackendRequestParams backRequest) { }

	private string ParseResponseToText(BackendRequestParams backRequest, ResponseData bResponse) { }

	[CompilerGenerated]
	public void remove_OnErrorHandledWithResult(Action value) { }

	[CompilerGenerated]
	public void remove_OnSessionError(Action value) { }

	private void RunConnectionDiagnostics() { }

	[AsyncStateMachine(typeof(<SendAndHandleRetries>d__32`1))]
	public Task SendAndHandleRetries(BackendRequestParams backRequest) { }

	private void set_LastSucceedResponse(DateTime value) { }

	[CompilerGenerated]
	public void set_WebDiagnosticsEnabled(bool value) { }

	public static string ToString(IDictionary responseHeaders, string separator = "
") { }

	private static bool TryExtractPhpSessionId(string setCookieValue, out string phpSessionId) { }

	private void UpdatePhpSessionId(IDictionary responseHeaders) { }

}

