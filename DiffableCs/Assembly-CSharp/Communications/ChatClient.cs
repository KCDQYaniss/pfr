namespace Communications;

internal sealed class ChatClient : MonoBehaviourSingleton, IUnityScheduller
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal DateTime <BackEndCallback>b__20_0(ChatServerState item) { }

	}

	[CompilerGenerated]
	private sealed class <ReconnectCoroutine>d__22 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ChatClient <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <ReconnectCoroutine>d__22(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ReconnectCoroutune>d__27 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ChatClient <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <ReconnectCoroutune>d__27(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private string _versionId; //Field offset: 0x20
	private ICommunicator _communicator; //Field offset: 0x28
	private ITcpClient _tcpClient; //Field offset: 0x30
	private IEftSession _backEndSession; //Field offset: 0x38
	private string _connectionPoint; //Field offset: 0x40
	private int _reconnectCounter; //Field offset: 0x48
	[CompilerGenerated]
	private IChatsSession <Session>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private ChatController <ChatController>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Action Event; //Field offset: 0x60

	public override event Action Event
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private ChatController ChatController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private IChatsSession Session
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ChatClient() { }

	[CompilerGenerated]
	private void <OnConnect>b__24_0(object sender, ConnectionClosedEventArgs args) { }

	[CompilerGenerated]
	public override void add_Event(Action value) { }

	private void BackEndCallback(Result result) { }

	private override Coroutine Comfort.Common.IUnityScheduller.StartCoroutine(IEnumerator enumerator) { }

	private void Connect() { }

	internal static ChatClient Create(string versionId, GameObject gameObject = null, CommunicatorFactory communicatorFactory = null) { }

	private void FixedUpdate() { }

	[CompilerGenerated]
	public ChatController get_ChatController() { }

	[CompilerGenerated]
	public IChatsSession get_Session() { }

	private void OnCommunicationError(string error) { }

	private void OnConnect(IConnection connection) { }

	public virtual void OnDestroy() { }

	private void OnDisconnect(ConnectionStateChangedEventArgs args) { }

	private void OnStatusChangedEvent(StatusChangedEventArgs args) { }

	public void Reconnect(string ip, int port) { }

	[IteratorStateMachine(typeof(<ReconnectCoroutine>d__22))]
	private IEnumerator ReconnectCoroutine() { }

	[IteratorStateMachine(typeof(<ReconnectCoroutune>d__27))]
	private IEnumerator ReconnectCoroutune() { }

	[CompilerGenerated]
	public override void remove_Event(Action value) { }

	internal void Run(IEftSession backEndSession) { }

	[CompilerGenerated]
	private void set_ChatController(ChatController value) { }

	[CompilerGenerated]
	private void set_Session(IChatsSession value) { }

	internal void Stop() { }

}

