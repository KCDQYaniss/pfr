namespace Communications;

[RequireComponent(typeof(ChatClient))]
internal sealed class ChatController : MonoBehaviour, IChatMember
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_1; //Field offset: 0x8
		public static Func <>9__13_0; //Field offset: 0x10
		public static Func <>9__15_0; //Field offset: 0x18
		public static Func <>9__16_0; //Field offset: 0x20
		public static Func <>9__16_2; //Field offset: 0x28
		public static Func <>9__19_0; //Field offset: 0x30
		public static Func <>9__20_0; //Field offset: 0x38
		public static Func <>9__21_0; //Field offset: 0x40
		public static Action <>9__22_0; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal bool <ChatShared.IChatMember.Receive>b__15_0(UpdatableChatMember x) { }

		internal bool <ChatShared.IChatMember.ReceiveReplay>b__16_0(UpdatableChatMember x) { }

		internal bool <ChatShared.IChatMember.ReceiveReplay>b__16_2(UpdatableChatMember x) { }

		internal bool <ChatShared.IChatMember.Remove>b__19_0(UpdatableChatMember x) { }

		internal bool <ChatShared.IChatMember.SetBanned>b__20_0(UpdatableChatMember x) { }

		internal bool <ChatShared.IChatMember.SetUnbanned>b__21_0(UpdatableChatMember x) { }

		internal UpdatableChatMember <CreateChatDialog>b__13_0(ChatRoomMember info) { }

		internal UpdatableChatMember <CreateChatDialog>b__13_1(string id) { }

		internal void <OnDestroy>b__22_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Message message; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <ChatShared.IChatMember.Receive>b__1(UpdatableChatMember member) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Message replayMessage; //Field offset: 0x10
		public Message message; //Field offset: 0x18

		public <>c__DisplayClass16_0() { }

		internal bool <ChatShared.IChatMember.ReceiveReplay>b__1(UpdatableChatMember member) { }

		internal bool <ChatShared.IChatMember.ReceiveReplay>b__3(UpdatableChatMember member) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public ChatRoomMember member; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal UpdatableChatMember <ChatShared.IChatMember.Add>b__0(string id) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public string[] members; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <ChatShared.IChatMember.Remove>b__1(UpdatableChatMember member) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public string memberId; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <ChatShared.IChatMember.SetBanned>b__1(UpdatableChatMember x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public string memberId; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <ChatShared.IChatMember.SetUnbanned>b__1(UpdatableChatMember x) { }

	}

	private ChatClient _chatClient; //Field offset: 0x20
	private SocialNetwork _socialNetwork; //Field offset: 0x28
	private IChatHandle _chatHandle; //Field offset: 0x30
	private UpdatableChatDialogue _dialogue; //Field offset: 0x38
	[CompilerGenerated]
	private string <ChatId>k__BackingField; //Field offset: 0x40

	public private string ChatId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ChatController() { }

	private override void ChatShared.IChatMember.Add(ChatRoomMember[] members) { }

	private override void ChatShared.IChatMember.Drop() { }

	private override void ChatShared.IChatMember.Receive(Message message) { }

	private override void ChatShared.IChatMember.ReceiveReplay(Message message, Message replayMessage) { }

	private override void ChatShared.IChatMember.Remove(string[] members) { }

	private override void ChatShared.IChatMember.SetBanned(string memberId, DateTime toDateTime) { }

	private override void ChatShared.IChatMember.SetUnbanned(string memberId) { }

	public static ChatController Create(ChatClient chatClient) { }

	private void CreateChatDialog(Result result) { }

	[CompilerGenerated]
	public string get_ChatId() { }

	private void OnDestroy() { }

	private void Send(DialogueChatMessage message, DialogueChatMessage replayToMessage, Action callback) { }

	public void SessionRestart(string chatId, string ip, int port) { }

	public void SessionStart(SocialNetwork socialNetwork) { }

	public void SessionStop() { }

	[CompilerGenerated]
	private void set_ChatId(string value) { }

	private void StartCallback(Result result) { }

}

