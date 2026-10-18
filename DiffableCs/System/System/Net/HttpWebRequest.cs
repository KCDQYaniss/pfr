namespace System.Net;

public class HttpWebRequest : WebRequest, ISerializable
{
	[CompilerGenerated]
	private struct <<GetRewriteHandler>b__271_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HttpWebRequest <>4__this; //Field offset: 0x20
		private MemoryStream <ms>5__2; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c__241`1
	{
		public static readonly <>c__241 <>9; //Field offset: 0x0
		public static Func <>9__241_0; //Field offset: 0x0

		private static <>c__241`1() { }

		public <>c__241`1() { }

		internal Nullable <RunWithTimeoutWorker>b__241_0(Task t) { }

	}

	[CompilerGenerated]
	private struct <GetResponseFromData>d__244 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"response", "redirect", "mustReadAll", "writeBuffer", "ntlm"})]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HttpWebRequest <>4__this; //Field offset: 0x20
		public WebResponseStream stream; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private HttpWebResponse <response>5__2; //Field offset: 0x38
		private WebException <throwMe>5__3; //Field offset: 0x40
		private bool <redirect>5__4; //Field offset: 0x48
		private bool <mustReadAll>5__5; //Field offset: 0x49
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MyGetResponseAsync>d__243 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HttpWebRequest <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private WebCompletionSource <completion>5__2; //Field offset: 0x30
		private WebOperation <operation>5__3; //Field offset: 0x38
		private WebException <throwMe>5__4; //Field offset: 0x40
		private HttpWebResponse <response>5__5; //Field offset: 0x48
		private WebResponseStream <stream>5__6; //Field offset: 0x50
		private bool <redirect>5__7; //Field offset: 0x58
		private bool <mustReadAll>5__8; //Field offset: 0x59
		private WebOperation <ntlm>5__9; //Field offset: 0x60
		private BufferOffsetSize <writeBuffer>5__10; //Field offset: 0x68
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x70
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x80
		private TaskAwaiter <>u__3; //Field offset: 0x90
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"response", "redirect", "mustReadAll", "writeBuffer", "ntlm"})]
		private ConfiguredTaskAwaiter <>u__4; //Field offset: 0x98

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunWithTimeoutWorker>d__241`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Task workerTask; //Field offset: 0x0
		public int timeout; //Field offset: 0x0
		public CancellationTokenSource cts; //Field offset: 0x0
		public Action abort; //Field offset: 0x0
		public Func aborted; //Field offset: 0x0
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct AuthorizationState
	{
		private readonly HttpWebRequest request; //Field offset: 0x0
		private readonly bool isProxy; //Field offset: 0x8
		private bool isCompleted; //Field offset: 0x9
		private NtlmAuthState ntlm_auth_state; //Field offset: 0xC

		public bool IsCompleted
		{
			 get { } //Length: 5
		}

		public bool IsNtlmAuthenticated
		{
			 get { } //Length: 17
		}

		public NtlmAuthState NtlmAuthState
		{
			 get { } //Length: 4
		}

		public AuthorizationState(HttpWebRequest request, bool isProxy) { }

		public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

		public bool get_IsCompleted() { }

		public bool get_IsNtlmAuthenticated() { }

		public NtlmAuthState get_NtlmAuthState() { }

		public void Reset() { }

		public virtual string ToString() { }

	}

	private enum NtlmAuthState
	{
		None = 0,
		Challenge = 1,
		Response = 2,
	}

	private static int defaultMaxResponseHeadersLength; //Field offset: 0x0
	private static int defaultMaximumErrorResponseLength; //Field offset: 0x4
	private static RequestCachePolicy defaultCachePolicy; //Field offset: 0x8
	private Uri requestUri; //Field offset: 0x38
	private Uri actualUri; //Field offset: 0x40
	private bool hostChanged; //Field offset: 0x48
	private bool allowAutoRedirect; //Field offset: 0x49
	private bool allowBuffering; //Field offset: 0x4A
	private X509CertificateCollection certificates; //Field offset: 0x50
	private string connectionGroup; //Field offset: 0x58
	private bool haveContentLength; //Field offset: 0x60
	private long contentLength; //Field offset: 0x68
	private HttpContinueDelegate continueDelegate; //Field offset: 0x70
	private CookieContainer cookieContainer; //Field offset: 0x78
	private ICredentials credentials; //Field offset: 0x80
	private bool haveResponse; //Field offset: 0x88
	private bool requestSent; //Field offset: 0x89
	private WebHeaderCollection webHeaders; //Field offset: 0x90
	private bool keepAlive; //Field offset: 0x98
	private int maxAutoRedirect; //Field offset: 0x9C
	private string mediaType; //Field offset: 0xA0
	private string method; //Field offset: 0xA8
	private string initialMethod; //Field offset: 0xB0
	private bool pipelined; //Field offset: 0xB8
	private bool preAuthenticate; //Field offset: 0xB9
	private bool usedPreAuth; //Field offset: 0xBA
	private Version version; //Field offset: 0xC0
	private bool force_version; //Field offset: 0xC8
	private Version actualVersion; //Field offset: 0xD0
	private IWebProxy proxy; //Field offset: 0xD8
	private bool sendChunked; //Field offset: 0xE0
	private ServicePoint servicePoint; //Field offset: 0xE8
	private int timeout; //Field offset: 0xF0
	private int continueTimeout; //Field offset: 0xF4
	private WebRequestStream writeStream; //Field offset: 0xF8
	private HttpWebResponse webResponse; //Field offset: 0x100
	private WebCompletionSource responseTask; //Field offset: 0x108
	private WebOperation currentOperation; //Field offset: 0x110
	private int aborted; //Field offset: 0x118
	private bool gotRequestStream; //Field offset: 0x11C
	private int redirects; //Field offset: 0x120
	private bool expectContinue; //Field offset: 0x124
	private bool getResponseCalled; //Field offset: 0x125
	private object locker; //Field offset: 0x128
	private bool finished_reading; //Field offset: 0x130
	private DecompressionMethods auto_decomp; //Field offset: 0x134
	private int readWriteTimeout; //Field offset: 0x138
	private MobileTlsProvider tlsProvider; //Field offset: 0x140
	private MonoTlsSettings tlsSettings; //Field offset: 0x148
	private ServerCertValidationCallback certValidationCallback; //Field offset: 0x150
	private bool hostHasPort; //Field offset: 0x158
	private Uri hostUri; //Field offset: 0x160
	private AuthorizationState auth_state; //Field offset: 0x168
	private AuthorizationState proxy_auth_state; //Field offset: 0x178
	internal Func ResendContentFactory; //Field offset: 0x188
	[CompilerGenerated]
	private bool <ThrowOnError>k__BackingField; //Field offset: 0x190
	private bool unsafe_auth_blah; //Field offset: 0x191

	internal bool Aborted
	{
		internal get { } //Length: 22
	}

	public string Accept
	{
		 set { } //Length: 161
	}

	public Uri Address
	{
		 get { } //Length: 5
	}

	public override bool AllowWriteStreamBuffering
	{
		 get { } //Length: 5
	}

	internal Uri AuthUri
	{
		internal get { } //Length: 5
	}

	public DecompressionMethods AutomaticDecompression
	{
		 get { } //Length: 7
	}

	public X509CertificateCollection ClientCertificates
	{
		 get { } //Length: 171
	}

	public string Connection
	{
		 set { } //Length: 570
	}

	public virtual long ContentLength
	{
		 get { } //Length: 5
		 set { } //Length: 207
	}

	public virtual string ContentType
	{
		 get { } //Length: 91
		 set { } //Length: 80
	}

	public virtual ICredentials Credentials
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	[MonoTODO]
	public static int DefaultMaximumErrorResponseLength
	{
		 get { } //Length: 83
	}

	public string Expect
	{
		 set { } //Length: 507
	}

	internal bool ExpectContinue
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	internal bool FinishedReading
	{
		internal set { } //Length: 7
	}

	public virtual WebHeaderCollection Headers
	{
		 get { } //Length: 8
		 set { } //Length: 471
	}

	public string Host
	{
		 get { } //Length: 387
		 set { } //Length: 676
	}

	internal bool InternalAllowBuffering
	{
		internal get { } //Length: 16
	}

	internal long InternalContentLength
	{
		internal set { } //Length: 5
	}

	public bool KeepAlive
	{
		 get { } //Length: 8
	}

	public virtual string Method
	{
		 get { } //Length: 8
		 set { } //Length: 1336
	}

	private bool MethodWithBuffer
	{
		private get { } //Length: 490
	}

	public Version ProtocolVersion
	{
		 get { } //Length: 8
	}

	public virtual IWebProxy Proxy
	{
		 get { } //Length: 8
		 set { } //Length: 313
	}

	internal bool ProxyQuery
	{
		internal get { } //Length: 46
	}

	public int ReadWriteTimeout
	{
		 get { } //Length: 7
	}

	public string Referer
	{
		 set { } //Length: 313
	}

	public virtual Uri RequestUri
	{
		 get { } //Length: 5
	}

	public bool SendChunked
	{
		 get { } //Length: 8
	}

	public RemoteCertificateValidationCallback ServerCertificateValidationCallback
	{
		 get { } //Length: 25
		 set { } //Length: 324
	}

	internal ServerCertValidationCallback ServerCertValidationCallback
	{
		internal get { } //Length: 8
	}

	public ServicePoint ServicePoint
	{
		 get { } //Length: 7
	}

	internal ServicePoint ServicePointNoLock
	{
		internal get { } //Length: 8
	}

	internal bool ThrowOnError
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public virtual int Timeout
	{
		 get { } //Length: 7
		 set { } //Length: 102
	}

	internal MobileTlsProvider TlsProvider
	{
		internal get { } //Length: 8
	}

	internal MonoTlsSettings TlsSettings
	{
		internal get { } //Length: 8
	}

	public string TransferEncoding
	{
		 get { } //Length: 91
	}

	public bool UnsafeAuthenticatedConnectionSharing
	{
		 get { } //Length: 8
	}

	public virtual bool UseDefaultCredentials
	{
		 get { } //Length: 126
	}

	public string UserAgent
	{
		 set { } //Length: 94
	}

	private static HttpWebRequest() { }

	[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
	protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	public HttpWebRequest() { }

	public HttpWebRequest(Uri uri) { }

	[AsyncStateMachine(typeof(<<GetRewriteHandler>b__271_0>d))]
	[CompilerGenerated]
	private Task <GetRewriteHandler>b__271_0() { }

	[CompilerGenerated]
	private bool <RunWithTimeout>b__242_0() { }

	public virtual void Abort() { }

	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	private ValueTuple CheckFinalStatus(HttpWebResponse response) { }

	private void CheckRequestStarted() { }

	internal static WebException CreateRequestAbortedException() { }

	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	private void DoPreAuthenticate() { }

	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	internal static Exception FlattenException(Exception e) { }

	internal bool get_Aborted() { }

	public Uri get_Address() { }

	public override bool get_AllowWriteStreamBuffering() { }

	internal Uri get_AuthUri() { }

	public DecompressionMethods get_AutomaticDecompression() { }

	public X509CertificateCollection get_ClientCertificates() { }

	public virtual long get_ContentLength() { }

	public virtual string get_ContentType() { }

	public virtual ICredentials get_Credentials() { }

	public static int get_DefaultMaximumErrorResponseLength() { }

	internal bool get_ExpectContinue() { }

	public virtual WebHeaderCollection get_Headers() { }

	public string get_Host() { }

	internal bool get_InternalAllowBuffering() { }

	public bool get_KeepAlive() { }

	public virtual string get_Method() { }

	private bool get_MethodWithBuffer() { }

	public Version get_ProtocolVersion() { }

	public virtual IWebProxy get_Proxy() { }

	internal bool get_ProxyQuery() { }

	public int get_ReadWriteTimeout() { }

	public virtual Uri get_RequestUri() { }

	public bool get_SendChunked() { }

	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	public ServicePoint get_ServicePoint() { }

	internal ServicePoint get_ServicePointNoLock() { }

	[CompilerGenerated]
	internal bool get_ThrowOnError() { }

	public virtual int get_Timeout() { }

	internal MobileTlsProvider get_TlsProvider() { }

	internal MonoTlsSettings get_TlsSettings() { }

	public string get_TransferEncoding() { }

	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	public virtual bool get_UseDefaultCredentials() { }

	private string GetHeaders() { }

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal byte[] GetRequestHeaders() { }

	public virtual Stream GetRequestStream() { }

	public virtual Task GetRequestStreamAsync() { }

	public virtual WebResponse GetResponse() { }

	[AsyncStateMachine(typeof(<GetResponseFromData>d__244))]
	private Task GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	private ValueTuple GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	internal ServicePoint GetServicePoint() { }

	private static WebException GetWebException(Exception e, bool aborted) { }

	private WebException GetWebException(Exception e) { }

	private ValueTuple HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	private Task MyGetRequestStreamAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<MyGetResponseAsync>d__243))]
	private Task MyGetResponseAsync(CancellationToken cancellationToken) { }

	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	private void ResetAuthorization() { }

	private void RewriteRedirectToGet() { }

	internal static Task RunWithTimeout(Func func, int timeout, Action abort, Func aborted, CancellationToken cancellationToken) { }

	private Task RunWithTimeout(Func func) { }

	[AsyncStateMachine(typeof(<RunWithTimeoutWorker>d__241`1))]
	private static Task RunWithTimeoutWorker(Task workerTask, int timeout, Action abort, Func aborted, CancellationTokenSource cts) { }

	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	public void set_Accept(string value) { }

	public void set_Connection(string value) { }

	public virtual void set_ContentLength(long value) { }

	public virtual void set_ContentType(string value) { }

	public virtual void set_Credentials(ICredentials value) { }

	public void set_Expect(string value) { }

	internal void set_ExpectContinue(bool value) { }

	internal void set_FinishedReading(bool value) { }

	public virtual void set_Headers(WebHeaderCollection value) { }

	public void set_Host(string value) { }

	internal void set_InternalContentLength(long value) { }

	public virtual void set_Method(string value) { }

	public virtual void set_Proxy(IWebProxy value) { }

	public void set_Referer(string value) { }

	public void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	internal void set_ThrowOnError(bool value) { }

	public virtual void set_Timeout(int value) { }

	public void set_UserAgent(string value) { }

	private void SetSpecialHeaders(string HeaderName, string value) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private bool TryGetHostUri(string hostName, out Uri hostUri) { }

}

