namespace EFT.Communications;

internal sealed class LegacyNotifierChannel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		private struct <<CreateNotifierChannel>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass38_0 <>4__this; //Field offset: 0x28
			public Result result; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x48

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public int generation; //Field offset: 0x10
		public LegacyNotifierChannel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass38_0() { }

		[AsyncStateMachine(typeof(<<CreateNotifierChannel>b__0>d))]
		internal void <CreateNotifierChannel>b__0(Result result) { }

	}

	[CompilerGenerated]
	private struct <RecreateNotifierChannel>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LegacyNotifierChannel <>4__this; //Field offset: 0x28
		public bool withDelay; //Field offset: 0x30
		private int <generation>5__2; //Field offset: 0x34
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class ChannelCreationTimeout
	{
		private const int LinkRequestDelay = 60; //Field offset: 0x0
		private const int LinkRequestDelayMax = 120; //Field offset: 0x0
		private const int LinkRequestDelayIncrement = 30; //Field offset: 0x0
		private int _delay; //Field offset: 0x10

		public ChannelCreationTimeout() { }

		internal int Delay(bool update = true) { }

		internal void Reset() { }

		internal Task Wait(bool update = true) { }

	}

	private sealed class SpamChecker
	{
		private const int SpamProtectionStartsFrom = 60; //Field offset: 0x0
		private const float SpamProtectionNormalAvgMinTime = 0.5; //Field offset: 0x0
		private int _messageCounter; //Field offset: 0x10
		private float _time; //Field offset: 0x14

		public SpamChecker() { }

		internal bool IsSpam(bool messageReceived = true) { }

		internal void Reset() { }

	}

	private const string DEFAULT_NOTIFICATION_ID = "default_id"; //Field offset: 0x0
	private readonly long[] _reconnectCodes; //Field offset: 0x10
	private readonly long[] _createNewChannelCodes; //Field offset: 0x18
	private readonly SpamChecker _spamChecker; //Field offset: 0x20
	private readonly ChannelCreationTimeout _channelCreationTimeout; //Field offset: 0x28
	private readonly Func _isActivated; //Field offset: 0x30
	private readonly Action _onSpamDetected; //Field offset: 0x38
	private readonly LegacyPayloadProcessor _processPayload; //Field offset: 0x40
	private string _lastNotificationId; //Field offset: 0x48
	private NotifierParams _notifierParams; //Field offset: 0x50
	private ILongPollingRequest _longPollingRequest; //Field offset: 0x58
	private IClientSession _session; //Field offset: 0x60
	private ENotificationTransportType _transportType; //Field offset: 0x68
	private bool _opened; //Field offset: 0x6C
	private int _generation; //Field offset: 0x70

	private bool Enabled
	{
		private get { } //Length: 157
	}

	private bool HasNotifierParams
	{
		private get { } //Length: 32
	}

	public bool IsOpen
	{
		 get { } //Length: 5
	}

	public LegacyNotifierChannel(Func isActivated, Action onSpamDetected, LegacyPayloadProcessor processPayload) { }

	public void ChangeTransport(ENotificationTransportType transportType) { }

	public void Close() { }

	private void CreateNotifierChannel() { }

	private void ErrorHandler(long responseCode, string message) { }

	private bool get_Enabled() { }

	private bool get_HasNotifierParams() { }

	public bool get_IsOpen() { }

	private void HandleProcessResult(NotificationProcessResult processResult) { }

	public void Init(IClientSession session, ENotificationTransportType transportType) { }

	private void MessageHandler(long responseCode, byte[] bytes) { }

	private void ProcessError(long responseCode) { }

	[AsyncStateMachine(typeof(<RecreateNotifierChannel>d__37))]
	private void RecreateNotifierChannel(bool withDelay = false) { }

	private void RequestClose() { }

	private void RequestCreate(ENotificationTransportType transportType) { }

	private void RequestOpen() { }

	public void ResetTimeout() { }

	public void Resume() { }

	private void SetLastNotificationId(string eventId) { }

	public void Start() { }

	public void Unbind() { }

}

