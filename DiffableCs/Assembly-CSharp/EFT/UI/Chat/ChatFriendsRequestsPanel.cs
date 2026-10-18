namespace EFT.UI.Chat;

public sealed class ChatFriendsRequestsPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__9_0; //Field offset: 0x8
		public static Predicate <>9__9_2; //Field offset: 0x10
		public static Action <>9__12_0; //Field offset: 0x18
		public static Action <>9__13_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal void <AcceptAllClicked>b__12_0() { }

		internal void <SendAcceptRequests>b__13_0() { }

		internal bool <Show>b__9_0(UpdatableFriendsInvitation x) { }

		internal bool <Show>b__9_2(UpdatableFriendsInvitation x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public ChatFriendsRequestsPanel <>4__this; //Field offset: 0x10
		public SocialNetwork social; //Field offset: 0x18
		public Action <>9__4; //Field offset: 0x20
		public Action <>9__5; //Field offset: 0x28

		public <>c__DisplayClass9_0() { }

		internal void <Show>b__1(UpdatableFriendsInvitation arg, FriendsInvitationView view) { }

		internal void <Show>b__3(UpdatableFriendsInvitation arg, FriendsInvitationView view) { }

		internal void <Show>b__4(UpdatableFriendsInvitation invitation, Vector2 pos) { }

		internal void <Show>b__5(UpdatableFriendsInvitation invitation, Vector2 pos) { }

	}

	[CompilerGenerated]
	private struct <SendAcceptRequests>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ChatFriendsRequestsPanel <>4__this; //Field offset: 0x28
		private Task <task>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string ALL_REQUESTS_ACCEPT_CONFIRMATION = "UI/Social/AllRequestsAccept"; //Field offset: 0x0
	private const string ALL_REQUESTS_ACCEPTED_MESSAGE = "UI/Social/AllRequestsAccepted"; //Field offset: 0x0
	[SerializeField]
	private Button _acceptAllButton; //Field offset: 0x70
	[SerializeField]
	private SimpleContextMenu _contextMenu; //Field offset: 0x78
	[SerializeField]
	private FriendsInvitationView _friendsInvitation; //Field offset: 0x80
	[SerializeField]
	private RectTransform _invitationsContainer; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI _requestsLabel; //Field offset: 0x90
	private SocialNetwork _social; //Field offset: 0x98
	private int _requestsCount; //Field offset: 0xA0

	public ChatFriendsRequestsPanel() { }

	private void AcceptAllClicked() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<SendAcceptRequests>d__13))]
	private void SendAcceptRequests() { }

	public void Show(SocialNetwork social) { }

	private void UpdateAcceptAllButton() { }

	private void UpdateContent() { }

}

