namespace WebSocketSharp.Server;

public abstract class WebSocketBehavior : IWebSocketSession
{
	private WebSocketContext _context; //Field offset: 0x10
	private Func _cookiesValidator; //Field offset: 0x18
	private bool _emitOnPing; //Field offset: 0x20
	private string _id; //Field offset: 0x28
	private bool _ignoreExtensions; //Field offset: 0x30
	private Func _originValidator; //Field offset: 0x38
	private string _protocol; //Field offset: 0x40
	private WebSocketSessionManager _sessions; //Field offset: 0x48
	private DateTime _startTime; //Field offset: 0x50
	private WebSocket _websocket; //Field offset: 0x58

	public override WebSocketState ConnectionState
	{
		 get { } //Length: 27
	}

	public override WebSocketContext Context
	{
		 get { } //Length: 7
	}

	public Func CookiesValidator
	{
		 get { } //Length: 7
		 set { } //Length: 82
	}

	public bool EmitOnPing
	{
		 get { } //Length: 21
		 set { } //Length: 41
	}

	protected NameValueCollection Headers
	{
		 get { } //Length: 46
	}

	public override string ID
	{
		 get { } //Length: 7
	}

	public bool IgnoreExtensions
	{
		 get { } //Length: 7
		 set { } //Length: 4
	}

	public Func OriginValidator
	{
		 get { } //Length: 7
		 set { } //Length: 82
	}

	public override string Protocol
	{
		 get { } //Length: 127
		 set { } //Length: 386
	}

	protected NameValueCollection QueryString
	{
		 get { } //Length: 46
	}

	protected WebSocketSessionManager Sessions
	{
		 get { } //Length: 7
	}

	public override DateTime StartTime
	{
		 get { } //Length: 7
	}

	protected WebSocketBehavior() { }

	private string checkHandshakeRequest(WebSocketContext context) { }

	protected void Close(CloseStatusCode code, string reason) { }

	protected void Close(ushort code, string reason) { }

	protected void Close() { }

	protected void CloseAsync(ushort code, string reason) { }

	protected void CloseAsync() { }

	protected void CloseAsync(CloseStatusCode code, string reason) { }

	public override WebSocketState get_ConnectionState() { }

	public override WebSocketContext get_Context() { }

	public Func get_CookiesValidator() { }

	public bool get_EmitOnPing() { }

	protected NameValueCollection get_Headers() { }

	public override string get_ID() { }

	public bool get_IgnoreExtensions() { }

	public Func get_OriginValidator() { }

	public override string get_Protocol() { }

	protected NameValueCollection get_QueryString() { }

	protected WebSocketSessionManager get_Sessions() { }

	public override DateTime get_StartTime() { }

	private void onClose(object sender, CloseEventArgs e) { }

	protected override void OnClose(CloseEventArgs e) { }

	private void onError(object sender, ErrorEventArgs e) { }

	protected override void OnError(ErrorEventArgs e) { }

	private void onMessage(object sender, MessageEventArgs e) { }

	protected override void OnMessage(MessageEventArgs e) { }

	private void onOpen(object sender, EventArgs e) { }

	protected override void OnOpen() { }

	protected bool Ping(string message) { }

	protected bool Ping() { }

	protected void Send(byte[] data) { }

	protected void Send(FileInfo fileInfo) { }

	protected void Send(string data) { }

	protected void Send(Stream stream, int length) { }

	protected void SendAsync(string data, Action completed) { }

	protected void SendAsync(byte[] data, Action completed) { }

	protected void SendAsync(FileInfo fileInfo, Action completed) { }

	protected void SendAsync(Stream stream, int length, Action completed) { }

	public void set_CookiesValidator(Func value) { }

	public void set_EmitOnPing(bool value) { }

	public void set_IgnoreExtensions(bool value) { }

	public void set_OriginValidator(Func value) { }

	public void set_Protocol(string value) { }

	internal void Start(WebSocketContext context, WebSocketSessionManager sessions) { }

}

