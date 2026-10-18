namespace WebSocketSharp.Server;

public class HttpServer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass83_0
	{
		public HttpListenerContext ctx; //Field offset: 0x10
		public HttpServer <>4__this; //Field offset: 0x18

		public <>c__DisplayClass83_0() { }

		internal void <receiveRequest>b__0(object state) { }

	}

	private IPAddress _address; //Field offset: 0x10
	private string _docRootPath; //Field offset: 0x18
	private string _hostname; //Field offset: 0x20
	private HttpListener _listener; //Field offset: 0x28
	private Logger _log; //Field offset: 0x30
	private int _port; //Field offset: 0x38
	private Thread _receiveThread; //Field offset: 0x40
	private bool _secure; //Field offset: 0x48
	private WebSocketServiceManager _services; //Field offset: 0x50
	private ServerState _state; //Field offset: 0x58
	private object _sync; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler OnConnect; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler OnDelete; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler OnGet; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler OnHead; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler OnOptions; //Field offset: 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler OnPost; //Field offset: 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler OnPut; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler OnTrace; //Field offset: 0xA0

	public event EventHandler OnConnect
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler OnDelete
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler OnGet
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler OnHead
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event EventHandler OnOptions
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event EventHandler OnPost
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event EventHandler OnPut
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event EventHandler OnTrace
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public IPAddress Address
	{
		 get { } //Length: 7
	}

	public AuthenticationSchemes AuthenticationSchemes
	{
		 get { } //Length: 110
		 set { } //Length: 361
	}

	public string DocumentRootPath
	{
		 get { } //Length: 7
		 set { } //Length: 1438
	}

	public bool IsListening
	{
		 get { } //Length: 15
	}

	public bool IsSecure
	{
		 get { } //Length: 7
	}

	public bool KeepClean
	{
		 get { } //Length: 32
		 set { } //Length: 30
	}

	public Logger Log
	{
		 get { } //Length: 7
	}

	public int Port
	{
		 get { } //Length: 6
	}

	public string Realm
	{
		 get { } //Length: 111
		 set { } //Length: 441
	}

	public bool ReuseAddress
	{
		 get { } //Length: 27
		 set { } //Length: 274
	}

	public ServerSslConfiguration SslConfiguration
	{
		 get { } //Length: 130
	}

	public Func UserCredentialsFinder
	{
		 get { } //Length: 111
		 set { } //Length: 441
	}

	public TimeSpan WaitTime
	{
		 get { } //Length: 27
		 set { } //Length: 30
	}

	public WebSocketServiceManager WebSocketServices
	{
		 get { } //Length: 7
	}

	public HttpServer() { }

	public HttpServer(int port) { }

	public HttpServer(string url) { }

	public HttpServer(int port, bool secure) { }

	public HttpServer(IPAddress address, int port) { }

	public HttpServer(IPAddress address, int port, bool secure) { }

	private void abort() { }

	[CompilerGenerated]
	public void add_OnConnect(EventHandler value) { }

	[CompilerGenerated]
	public void add_OnDelete(EventHandler value) { }

	[CompilerGenerated]
	public void add_OnGet(EventHandler value) { }

	[CompilerGenerated]
	public void add_OnHead(EventHandler value) { }

	[CompilerGenerated]
	public void add_OnOptions(EventHandler value) { }

	[CompilerGenerated]
	public void add_OnPost(EventHandler value) { }

	[CompilerGenerated]
	public void add_OnPut(EventHandler value) { }

	[CompilerGenerated]
	public void add_OnTrace(EventHandler value) { }

	public void AddWebSocketService(string path) { }

	public void AddWebSocketService(string path, Action initializer) { }

	private bool canSet() { }

	private bool checkCertificate(out string message) { }

	private static HttpListener createListener(string hostname, int port, bool secure) { }

	public IPAddress get_Address() { }

	public AuthenticationSchemes get_AuthenticationSchemes() { }

	public string get_DocumentRootPath() { }

	public bool get_IsListening() { }

	public bool get_IsSecure() { }

	public bool get_KeepClean() { }

	public Logger get_Log() { }

	public int get_Port() { }

	public string get_Realm() { }

	public bool get_ReuseAddress() { }

	public ServerSslConfiguration get_SslConfiguration() { }

	public Func get_UserCredentialsFinder() { }

	public TimeSpan get_WaitTime() { }

	public WebSocketServiceManager get_WebSocketServices() { }

	private void init(string hostname, IPAddress address, int port, bool secure) { }

	private void processRequest(HttpListenerContext context) { }

	private void processRequest(HttpListenerWebSocketContext context) { }

	private void receiveRequest() { }

	[CompilerGenerated]
	public void remove_OnConnect(EventHandler value) { }

	[CompilerGenerated]
	public void remove_OnDelete(EventHandler value) { }

	[CompilerGenerated]
	public void remove_OnGet(EventHandler value) { }

	[CompilerGenerated]
	public void remove_OnHead(EventHandler value) { }

	[CompilerGenerated]
	public void remove_OnOptions(EventHandler value) { }

	[CompilerGenerated]
	public void remove_OnPost(EventHandler value) { }

	[CompilerGenerated]
	public void remove_OnPut(EventHandler value) { }

	[CompilerGenerated]
	public void remove_OnTrace(EventHandler value) { }

	public bool RemoveWebSocketService(string path) { }

	public void set_AuthenticationSchemes(AuthenticationSchemes value) { }

	public void set_DocumentRootPath(string value) { }

	public void set_KeepClean(bool value) { }

	public void set_Realm(string value) { }

	public void set_ReuseAddress(bool value) { }

	public void set_UserCredentialsFinder(Func value) { }

	public void set_WaitTime(TimeSpan value) { }

	private void start() { }

	public void Start() { }

	private void startReceiving() { }

	private void stop(ushort code, string reason) { }

	public void Stop() { }

	private void stopReceiving(int millisecondsTimeout) { }

	private static bool tryCreateUri(string uriString, out Uri result, out string message) { }

}

