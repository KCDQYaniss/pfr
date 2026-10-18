namespace EFT.UI.Chat;

public sealed class ChatFriendsSteamPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public SocialNetwork social; //Field offset: 0x10
		public ChatFriendsSteamPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <Show>b__0(UpdatableChatMember member, ChatMember view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_1
	{
		public UpdatableChatMember member; //Field offset: 0x10
		public <>c__DisplayClass11_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass11_1() { }

		internal void <Show>b__1(Vector2 pos) { }

	}

	[CompilerGenerated]
	private sealed class <CooldownLoop>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ChatFriendsSteamPanel <>4__this; //Field offset: 0x20
		private int <lastSeconds>5__2; //Field offset: 0x28
		private WaitForSeconds <wait>5__3; //Field offset: 0x30

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
		public <CooldownLoop>d__15(int <>1__state) { }

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
	private struct <TrySync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ChatFriendsSteamPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private SimpleContextMenu _contextMenu; //Field offset: 0x70
	[SerializeField]
	private ChatMember _chatMember; //Field offset: 0x78
	[SerializeField]
	private RectTransform _membersContainer; //Field offset: 0x80
	[SerializeField]
	private DefaultUiButtonNewStyle _syncButton; //Field offset: 0x88
	[SerializeField]
	private GameObject _syncLoader; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _cooldownLabel; //Field offset: 0x98
	[SerializeField]
	private TextMeshProUGUI _friendsLabel; //Field offset: 0xA0
	private SocialNetwork _social; //Field offset: 0xA8
	private int _steamFriendsListCount; //Field offset: 0xB0
	private Coroutine _cooldownCoroutine; //Field offset: 0xB8
	private bool _syncInProgress; //Field offset: 0xC0

	public ChatFriendsSteamPanel() { }

	private void ApplyCooldown(int seconds) { }

	public virtual void Close() { }

	[IteratorStateMachine(typeof(<CooldownLoop>d__15))]
	private IEnumerator CooldownLoop() { }

	private void OnSyncClicked() { }

	private void SetSteamFriendsLabelText() { }

	public void Show(SocialNetwork social) { }

	[AsyncStateMachine(typeof(<TrySync>d__13))]
	private Task TrySync() { }

	private void UpdateCooldown() { }

}

