namespace EFT.Communications;

internal sealed class LobbyNotificationsChannel
{
	[CompilerGenerated]
	private struct <OpenAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LobbyNotificationsChannel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Func _canAcceptMessages; //Field offset: 0x10
	private readonly Action _onMessagesReceived; //Field offset: 0x18
	private IEftSession _session; //Field offset: 0x20
	private IEftSession _subscribedSession; //Field offset: 0x28

	public bool IsOpen
	{
		 get { } //Length: 81
	}

	public LobbyNotificationsChannel(Func canAcceptMessages, Action onMessagesReceived) { }

	public bool get_IsOpen() { }

	private void HandlePushNotification(WsPushNotificationMessage pushNotification) { }

	public void Init(IClientSession session) { }

	[AsyncStateMachine(typeof(<OpenAsync>d__9))]
	public Task OpenAsync() { }

	private void Subscribe() { }

	public void Unbind() { }

	private void Unsubscribe() { }

}

