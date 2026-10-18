namespace EFT.Communications;

public sealed class NotificationManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public NotificationManager <>4__this; //Field offset: 0x10
		public string result; //Field offset: 0x18
		public bool sessionDestroyed; //Field offset: 0x20

		public <>c__DisplayClass29_0() { }

		internal void <ProcessMessages>b__0(NotificationProcessResult processResult) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public Action onProcessed; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal void <ProcessLegacyPayload>b__0(string rawResult, NotificationProcessResult processResult) { }

	}

	[CompilerGenerated]
	private struct <ActivateAsync>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NotificationManager <>4__this; //Field offset: 0x20
		public IClientSession backEndSession; //Field offset: 0x28
		public ENotificationTransportType transportType; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ActivateAsync>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NotificationManager <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureActiveAsync>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IClientSession backEndSession; //Field offset: 0x20
		public NotificationManager <>4__this; //Field offset: 0x28
		public ENotificationTransportType transportType; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RebindActiveSessionAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NotificationManager <>4__this; //Field offset: 0x20
		public IClientSession backEndSession; //Field offset: 0x28
		public ENotificationTransportType transportType; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class NotificationLogger : AbstractLogger
	{
		private static NotificationLogger _instance; //Field offset: 0x0

		public static NotificationLogger Instance
		{
			 get { } //Length: 311
		}

		private NotificationLogger() { }

		public static NotificationLogger get_Instance() { }

	}

	private readonly NotificationInbox _inbox; //Field offset: 0x10
	private readonly LobbyNotificationsChannel _lobbyChannel; //Field offset: 0x18
	private readonly LegacyNotifierChannel _legacyChannel; //Field offset: 0x20
	private readonly NotificationMessageProcessor _messageProcessor; //Field offset: 0x28
	private IClientSession _backEndSession; //Field offset: 0x30
	[CompilerGenerated]
	private bool <Activated>k__BackingField; //Field offset: 0x38

	public event Action OnNotificationReceived
	{
		 add { } //Length: 286
		 remove { } //Length: 286
	}

	private bool Activated
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private bool IsLegacyNotifierChannelEnabled
	{
		private get { } //Length: 157
	}

	public static AbstractLogger Logger
	{
		 get { } //Length: 311
	}

	public List Notifications
	{
		 get { } //Length: 27
	}

	public List ProfileChangeNotifications
	{
		 get { } //Length: 27
	}

	public NotificationManager() { }

	[CompilerGenerated]
	private bool <.ctor>b__21_0() { }

	[CompilerGenerated]
	private bool <.ctor>b__21_1() { }

	[AsyncStateMachine(typeof(<ActivateAsync>d__23))]
	public Task ActivateAsync() { }

	[AsyncStateMachine(typeof(<ActivateAsync>d__22))]
	public Task ActivateAsync(IClientSession backEndSession, ENotificationTransportType transportType) { }

	public void add_OnNotificationReceived(Action value) { }

	private void AddNotification(Notification notification) { }

	public void ChangeTransport(ENotificationTransportType transportType) { }

	public void Deactivate() { }

	public static void DisplayMessageNotification(string message, ENotificationDurationType duration = 0, ENotificationIconType iconType = 0, Nullable textColor = null, bool rawText = true) { }

	public static void DisplayNotification(Notification notification) { }

	public static void DisplaySingletonNotification(string message, ENotificationDurationType duration = 0) { }

	public static void DisplaySingletonWarningNotification(string message, ENotificationDurationType duration = 0) { }

	public static void DisplayWarningNotification(string message, ENotificationDurationType duration = 0) { }

	[AsyncStateMachine(typeof(<EnsureActiveAsync>d__24))]
	public Task EnsureActiveAsync(IClientSession backEndSession, ENotificationTransportType transportType) { }

	[CompilerGenerated]
	private bool get_Activated() { }

	private bool get_IsLegacyNotifierChannelEnabled() { }

	public static AbstractLogger get_Logger() { }

	public List get_Notifications() { }

	public List get_ProfileChangeNotifications() { }

	private void HandleExternalProcessResult(string result, NotificationProcessResult processResult, bool sessionDestroyed) { }

	private void InitChannels(IClientSession backEndSession, ENotificationTransportType transportType) { }

	private void ProcessLegacyPayload(byte[] payload, Action onProcessed) { }

	private void ProcessLobbyMessages(string result, string[] messages, Nullable notificationType = null, string eventId = null) { }

	private void ProcessMessages(string result, string[] messages, Nullable notificationType, string eventId) { }

	[AsyncStateMachine(typeof(<RebindActiveSessionAsync>d__30))]
	private Task RebindActiveSessionAsync(IClientSession backEndSession, ENotificationTransportType transportType) { }

	public void remove_OnNotificationReceived(Action value) { }

	[CompilerGenerated]
	private void set_Activated(bool value) { }

	public void Shutdown() { }

}

