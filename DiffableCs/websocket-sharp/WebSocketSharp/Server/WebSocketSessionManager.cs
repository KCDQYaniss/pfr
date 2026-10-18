namespace WebSocketSharp.Server;

[DefaultMember("Item")]
public class WebSocketSessionManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public WebSocketSessionManager <>4__this; //Field offset: 0x10
		public Opcode opcode; //Field offset: 0x18
		public byte[] data; //Field offset: 0x20
		public Action completed; //Field offset: 0x28

		public <>c__DisplayClass34_0() { }

		internal void <broadcastAsync>b__0(object state) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public WebSocketSessionManager <>4__this; //Field offset: 0x10
		public Opcode opcode; //Field offset: 0x18
		public Stream stream; //Field offset: 0x20
		public Action completed; //Field offset: 0x28

		public <>c__DisplayClass35_0() { }

		internal void <broadcastAsync>b__0(object state) { }

	}

	[CompilerGenerated]
	private sealed class <get_ActiveIDs>d__15 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public WebSocketSessionManager <>4__this; //Field offset: 0x28
		private Enumerator <>s__1; //Field offset: 0x30
		private KeyValuePair <res>5__2; //Field offset: 0x58

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_ActiveIDs>d__15(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_InactiveIDs>d__21 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public WebSocketSessionManager <>4__this; //Field offset: 0x28
		private Enumerator <>s__1; //Field offset: 0x30
		private KeyValuePair <res>5__2; //Field offset: 0x58

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_InactiveIDs>d__21(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly byte[] _emptyPingFrameAsBytes; //Field offset: 0x0
	private object _forSweep; //Field offset: 0x10
	private bool _keepClean; //Field offset: 0x18
	private Logger _log; //Field offset: 0x20
	private Dictionary _sessions; //Field offset: 0x28
	private ServerState _state; //Field offset: 0x30
	private bool _sweeping; //Field offset: 0x34
	private Timer _sweepTimer; //Field offset: 0x38
	private object _sync; //Field offset: 0x40
	private TimeSpan _waitTime; //Field offset: 0x48

	public IEnumerable ActiveIDs
	{
		 get { } //Length: 180
	}

	public int Count
	{
		 get { } //Length: 246
	}

	public IEnumerable IDs
	{
		 get { } //Length: 486
	}

	public IEnumerable InactiveIDs
	{
		 get { } //Length: 180
	}

	public IWebSocketSession Item
	{
		 get { } //Length: 223
	}

	public bool KeepClean
	{
		 get { } //Length: 10
		 set { } //Length: 176
	}

	public IEnumerable Sessions
	{
		 get { } //Length: 486
	}

	internal ServerState State
	{
		internal get { } //Length: 9
	}

	public TimeSpan WaitTime
	{
		 get { } //Length: 7
		 set { } //Length: 342
	}

	private static WebSocketSessionManager() { }

	internal WebSocketSessionManager(Logger log) { }

	[CompilerGenerated]
	private void <setSweepTimer>b__39_0(object sender, ElapsedEventArgs e) { }

	internal string Add(IWebSocketSession session) { }

	private void broadcast(Opcode opcode, Stream stream, Action completed) { }

	private void broadcast(Opcode opcode, byte[] data, Action completed) { }

	public void Broadcast(byte[] data) { }

	public void Broadcast(Stream stream, int length) { }

	public void Broadcast(string data) { }

	private void broadcastAsync(Opcode opcode, byte[] data, Action completed) { }

	private void broadcastAsync(Opcode opcode, Stream stream, Action completed) { }

	public void BroadcastAsync(byte[] data, Action completed) { }

	public void BroadcastAsync(Stream stream, int length, Action completed) { }

	public void BroadcastAsync(string data, Action completed) { }

	private Dictionary broadping(byte[] frameAsBytes) { }

	private bool canSet() { }

	public void CloseSession(string id) { }

	public void CloseSession(string id, ushort code, string reason) { }

	public void CloseSession(string id, CloseStatusCode code, string reason) { }

	private static string createID() { }

	public IEnumerable get_ActiveIDs() { }

	public int get_Count() { }

	public IEnumerable get_IDs() { }

	public IEnumerable get_InactiveIDs() { }

	public IWebSocketSession get_Item(string id) { }

	public bool get_KeepClean() { }

	public IEnumerable get_Sessions() { }

	internal ServerState get_State() { }

	public TimeSpan get_WaitTime() { }

	public bool PingTo(string message, string id) { }

	public bool PingTo(string id) { }

	internal bool Remove(string id) { }

	public void SendTo(byte[] data, string id) { }

	public void SendTo(string data, string id) { }

	public void SendTo(Stream stream, int length, string id) { }

	public void SendToAsync(byte[] data, string id, Action completed) { }

	public void SendToAsync(string data, string id, Action completed) { }

	public void SendToAsync(Stream stream, int length, string id, Action completed) { }

	public void set_KeepClean(bool value) { }

	public void set_WaitTime(TimeSpan value) { }

	private void setSweepTimer(double interval) { }

	internal void Start() { }

	private void stop(PayloadData payloadData, bool send) { }

	internal void Stop(ushort code, string reason) { }

	public void Sweep() { }

	private bool tryGetSession(string id, out IWebSocketSession session) { }

	public bool TryGetSession(string id, out IWebSocketSession session) { }

}

