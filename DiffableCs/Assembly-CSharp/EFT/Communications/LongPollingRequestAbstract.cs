namespace EFT.Communications;

internal abstract class LongPollingRequestAbstract : ILongPollingRequest
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8
		public static Func <>9__8_1; //Field offset: 0x10
		public static Func <>9__8_2; //Field offset: 0x18
		public static Func <>9__8_3; //Field offset: 0x20
		public static Func <>9__28_0; //Field offset: 0x28
		public static Func <>9__30_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__8_0(KeyValuePair pair) { }

		internal string <.ctor>b__8_1(KeyValuePair pair) { }

		internal string <.ctor>b__8_2(KeyValuePair pair) { }

		internal string <.ctor>b__8_3(KeyValuePair pair) { }

		internal string <GetUri>b__28_0(string current, KeyValuePair pair) { }

		internal string <ToString>b__30_0(string current, KeyValuePair item) { }

	}

	protected const string STATUS_HEADER = "STATUS"; //Field offset: 0x0
	private string _uri; //Field offset: 0x10
	private readonly Dictionary _uriParams; //Field offset: 0x18
	private readonly Dictionary _requestHeaders; //Field offset: 0x20
	private Action _onMessage; //Field offset: 0x28
	private Action _onError; //Field offset: 0x30

	public override bool Closed
	{
		 get { } //Length: 19
	}

	protected Action OnError
	{
		 get { } //Length: 123
	}

	protected Action OnReceiveMessage
	{
		 get { } //Length: 123
	}

	public override IReadOnlyDictionary RequestHeaders
	{
		 get { } //Length: 5
	}

	public abstract ENotificationTransportType TransportType
	{
		 get { } //Length: 0
	}

	protected abstract string TypeName
	{
		 get { } //Length: 0
	}

	public override IReadOnlyDictionary UriParams
	{
		 get { } //Length: 5
	}

	protected LongPollingRequestAbstract(string uri = null, IReadOnlyDictionary uriParams = null, IReadOnlyDictionary requestHeaders = null) { }

	[CompilerGenerated]
	private void <get_OnError>g__ReceiveError|12_0(long code, string error) { }

	[CompilerGenerated]
	private void <get_OnReceiveMessage>g__ReceiveMessage|10_0(long code, byte[] data) { }

	protected abstract void Connect() { }

	protected abstract void Disconnect() { }

	private override void EFT.Communications.ILongPollingRequest.Close() { }

	private override void EFT.Communications.ILongPollingRequest.Open(Action onMessage, Action onError) { }

	private override void EFT.Communications.ILongPollingRequest.SetRequestHeader(string key, string value) { }

	private override void EFT.Communications.ILongPollingRequest.SetUri(string uri) { }

	private override void EFT.Communications.ILongPollingRequest.SetUriParam(string key, string value) { }

	public override bool get_Closed() { }

	protected Action get_OnError() { }

	protected Action get_OnReceiveMessage() { }

	public override IReadOnlyDictionary get_RequestHeaders() { }

	public abstract ENotificationTransportType get_TransportType() { }

	protected abstract string get_TypeName() { }

	public override IReadOnlyDictionary get_UriParams() { }

	protected static long GetResponseCode(string message) { }

	protected Uri GetUri() { }

	protected static void LogError(string format, object[] args) { }

	protected static void LogException(Exception e) { }

	protected static void LogInfo(string format, object[] args) { }

	protected static void LogTrace(string format, object[] args) { }

	protected static void LogWarn(string format, object[] args) { }

	protected static string ToString(IDictionary responseHeaders) { }

}

