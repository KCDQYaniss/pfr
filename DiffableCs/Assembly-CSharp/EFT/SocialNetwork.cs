namespace EFT;

public class SocialNetwork
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__108_0; //Field offset: 0x8
		public static Func <>9__108_1; //Field offset: 0x10
		public static Func <>9__108_2; //Field offset: 0x18
		public static Func <>9__108_5; //Field offset: 0x20
		public static Func <>9__108_6; //Field offset: 0x28
		public static Func <>9__108_3; //Field offset: 0x30
		public static Func <>9__108_4; //Field offset: 0x38
		public static Func <>9__109_0; //Field offset: 0x40
		public static Func <>9__109_1; //Field offset: 0x48
		public static Func <>9__109_2; //Field offset: 0x50
		public static Func <>9__109_5; //Field offset: 0x58
		public static Func <>9__109_6; //Field offset: 0x60
		public static Func <>9__109_3; //Field offset: 0x68
		public static Func <>9__109_4; //Field offset: 0x70
		public static Func <>9__110_0; //Field offset: 0x78
		public static Func <>9__122_0; //Field offset: 0x80
		public static Callback <>9__128_0; //Field offset: 0x88
		public static Func <>9__133_0; //Field offset: 0x90
		public static Callback <>9__138_0; //Field offset: 0x98
		public static Callback <>9__139_0; //Field offset: 0xA0
		public static Func <>9__140_0; //Field offset: 0xA8
		public static Func <>9__141_0; //Field offset: 0xB0
		public static Func <>9__143_0; //Field offset: 0xB8
		public static Func <>9__155_0; //Field offset: 0xC0
		public static Func <>9__157_0; //Field offset: 0xC8
		public static Func <>9__166_1; //Field offset: 0xD0

		private static <>c() { }

		public <>c() { }

		internal UpdatableChatMember <AcceptAllFriendRequests>b__133_0(UpdatableFriendsInvitation invitation) { }

		internal bool <AllAttachmentsFromDialog>b__166_1(DialogueChatMessage message) { }

		internal void <BanPlayer>b__138_0(Result result) { }

		internal void <DeleteMessage>b__128_0(Result res) { }

		internal UpdatableChatMember <Init>b__108_0(string id) { }

		internal UpdatableChatMember <Init>b__108_1(string id) { }

		internal bool <Init>b__108_2(UpdatableChatMember x) { }

		internal UpdatableFriendsInvitation <Init>b__108_3(FriendsInvitation x) { }

		internal UpdatableFriendsInvitation <Init>b__108_4(FriendsInvitation x) { }

		internal UpdatableChatMember <Init>b__108_5(string id) { }

		internal bool <Init>b__108_6(string item) { }

		internal UpdatableChatMember <Init>b__109_0(string id) { }

		internal UpdatableChatMember <Init>b__109_1(string id) { }

		internal bool <Init>b__109_2(UpdatableChatMember x) { }

		internal UpdatableFriendsInvitation <Init>b__109_3(FriendsInvitation x) { }

		internal UpdatableFriendsInvitation <Init>b__109_4(FriendsInvitation x) { }

		internal UpdatableChatMember <Init>b__109_5(string id) { }

		internal bool <Init>b__109_6(string item) { }

		internal string <InviteToDialogue>b__143_0(UpdatableChatMember x) { }

		internal string <ReadDialogues>b__157_0(UpdatableChatDialogue x) { }

		internal UpdatableChatMember <RemoveMessage>b__155_0(DialogueChatMessage x) { }

		internal bool <SetBannedPlayerStatus>b__140_0(UpdatableChatDialogue x) { }

		internal bool <SetUnbannedPlayerStatus>b__141_0(UpdatableChatDialogue x) { }

		internal void <UnbanPlayer>b__139_0(IResult result) { }

		internal bool <UpdateDialogueList>b__122_0(ChatRoomInformation x) { }

		internal bool <UpdateFriendsWithSteam>b__110_0(UpdatableChatMember x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass116_0
	{
		public NotificationAcceptedFriendsRequest <friendsAccept>5__2; //Field offset: 0x10
		public NotificationDeclinedFriendsRequest <friendsDecline>5__3; //Field offset: 0x18
		public NotificationYouWasKickedFromDialogue <kickedFromGroup>5__4; //Field offset: 0x20

		public <>c__DisplayClass116_0() { }

		internal bool <NotificationReceived>b__0(UpdatableFriendsInvitation x) { }

		internal bool <NotificationReceived>b__1(UpdatableFriendsInvitation x) { }

		internal bool <NotificationReceived>b__2(UpdatableChatDialogue x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass118_0
	{
		public NotificationFriendRequestCanceled friendRequestCanceled; //Field offset: 0x10

		public <>c__DisplayClass118_0() { }

		internal bool <FriendRequestCanceled>b__0(UpdatableFriendsInvitation x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass120_0
	{
		public string chatRoomId; //Field offset: 0x10

		public <>c__DisplayClass120_0() { }

		internal bool <TryGetDialog>b__0(UpdatableChatDialogue x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass125_0
	{
		public DialogueChatMessage message; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass125_0() { }

		internal void <SendMessage>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass130_0
	{
		public UpdatableChatMember member; //Field offset: 0x10
		public SocialNetwork <>4__this; //Field offset: 0x18
		public Callback callback; //Field offset: 0x20

		public <>c__DisplayClass130_0() { }

		internal bool <SendFriendRequest>b__0(UpdatableFriendsInvitation x) { }

		internal bool <SendFriendRequest>b__1(UpdatableFriendsInvitation x) { }

		internal void <SendFriendRequest>b__2(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass131_0
	{
		public UpdatableChatMember member; //Field offset: 0x10

		public <>c__DisplayClass131_0() { }

		internal bool <CancelFriendRequest>b__0(UpdatableFriendsInvitation x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass132_0
	{
		public UpdatableFriendsInvitation invitation; //Field offset: 0x10
		public SocialNetwork <>4__this; //Field offset: 0x18
		public UpdatableFriendsInvitation request; //Field offset: 0x20
		public Action callback; //Field offset: 0x28

		public <>c__DisplayClass132_0() { }

		internal bool <AcceptFriendRequest>b__0(UpdatableFriendsInvitation x) { }

		internal void <AcceptFriendRequest>b__1(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass134_0
	{
		public UpdatableFriendsInvitation invitation; //Field offset: 0x10

		public <>c__DisplayClass134_0() { }

		internal bool <DeclineFriendRequest>b__0(UpdatableFriendsInvitation x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass146_0
	{
		public UpdatableChatDialogue dialogue; //Field offset: 0x10

		public <>c__DisplayClass146_0() { }

		internal bool <LeaveDialogue>b__0(UpdatableChatDialogue x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass147_0
	{
		public Action callback; //Field offset: 0x10

		public <>c__DisplayClass147_0() { }

		internal void <GetChatServersList>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass149_0
	{
		public SocialNetwork <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass149_0() { }

		internal void <FindAccountByNickname>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass151_0
	{
		public UpdatableChatMember member; //Field offset: 0x10
		public Func <>9__1; //Field offset: 0x18

		public <>c__DisplayClass151_0() { }

		internal bool <GetInvitationByProfile>b__0(UpdatableFriendsInvitation item) { }

		internal bool <GetInvitationByProfile>b__1(UpdatableFriendsInvitation item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass153_0
	{
		public UpdatableChatDialogue dialogue; //Field offset: 0x10
		public SocialNetwork <>4__this; //Field offset: 0x18
		public DialogueChatMessage message; //Field offset: 0x20

		public <>c__DisplayClass153_0() { }

		internal void <DisplayMessage>b__0(Result arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass155_0
	{
		public DialogueChatMessage messageToDelete; //Field offset: 0x10

		public <>c__DisplayClass155_0() { }

		internal bool <RemoveMessage>b__1(UpdatableChatMember y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass157_0
	{
		public SocialNetwork <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass157_0() { }

		internal void <ReadDialogues>b__1(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass163_0
	{
		public UpdatableChatMember member; //Field offset: 0x10

		public <>c__DisplayClass163_0() { }

		internal void <PinFriend>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass164_0
	{
		public UpdatableChatMember member; //Field offset: 0x10

		public <>c__DisplayClass164_0() { }

		internal void <UnpinFriend>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass165_0
	{
		public UpdatableChatDialogue dialogue; //Field offset: 0x10

		public <>c__DisplayClass165_0() { }

		internal void <PinDialog>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass166_0
	{
		public SocialNetwork <>4__this; //Field offset: 0x10
		public string dialogId; //Field offset: 0x18
		public Action callback; //Field offset: 0x20

		public <>c__DisplayClass166_0() { }

		internal void <AllAttachmentsFromDialog>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass167_0
	{
		public UpdatableChatDialogue dialogue; //Field offset: 0x10

		public <>c__DisplayClass167_0() { }

		internal void <UnpinDialog>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__Create; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <AcceptAllFriendRequests>d__133 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SocialNetwork <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CancelFriendRequest>d__131 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UpdatableChatMember member; //Field offset: 0x20
		public SocialNetwork <>4__this; //Field offset: 0x28
		private UpdatableFriendsInvitation <sentInvite>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteDialog>d__127 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SocialNetwork <>4__this; //Field offset: 0x28
		public UpdatableChatDialogue dialogue; //Field offset: 0x30
		private bool <isSelected>5__2; //Field offset: 0x38
		private bool <isUnpinned>5__3; //Field offset: 0x39
		private bool <isPinned>5__4; //Field offset: 0x3A
		private string <dialogueId>5__5; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteDialogMessages>d__126 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public UpdatableChatDialogue dialogue; //Field offset: 0x28
		public SocialNetwork <>4__this; //Field offset: 0x30
		private UpdatableChatDialogue <deletingDialogueBackup>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__109 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SocialNetwork <>4__this; //Field offset: 0x20
		public ISocial session; //Field offset: 0x28
		public string matchingVersion; //Field offset: 0x30
		private IDisposable <>7__wrap1; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RedeemProfileRewards>d__119 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable rewards; //Field offset: 0x20
		public SocialNetwork <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncSteamFriends>d__115 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SocialNetwork <>4__this; //Field offset: 0x20
		private IResult <operationResult>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateDialogueList>d__123 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SocialNetwork <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const int MAXIMUM_MESSAGES_RECEIVE_COUNT = 30; //Field offset: 0x0
	public const int MAXIMUM_DIALOGUES_RECEIVE_COUNT = 30; //Field offset: 0x0
	private const int MAXIMUM_LETTERS_IN_MESSAGE = 500; //Field offset: 0x0
	private const int MAXIMUM_MESSAGES_IN_DIALOG = 100; //Field offset: 0x0
	private const string SYSTEM_MEMBER_ID = "59e7125688a45068a6249071"; //Field offset: 0x0
	private const string TOO_MANY_REQUESTS_HEADER = "NetworkError/TooManyFriendRequestsHeader"; //Field offset: 0x0
	private const string TOO_MANY_REQUESTS_MESSAGE = "NetworkError/TooManyFriendRequestsMessage"; //Field offset: 0x0
	[CompilerGenerated]
	private static UpdatableBindableList <IgnoringYouList>k__BackingField; //Field offset: 0x0
	public static bool MuteChatSounds; //Field offset: 0x8
	public static readonly Dictionary AllMembers; //Field offset: 0x10
	public static readonly Dictionary AllMessages; //Field offset: 0x18
	[CompilerGenerated]
	private UpdatableBindableList <PinnedDialogues>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private UpdatableBindableList <UnpinnedDialogues>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List <ReadDialoguesQueue>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private DialogueChatMessage <ReplyToMessage>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private UpdatableChatDialogue <SelectedDialogue>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private UpdatableChatMember <PlayerMember>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private UpdatableChatMember <SystemMember>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private ChatSendDelegate <ChatSendDelegate>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private UpdatableBindableList <SearchedFriendsList>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private UpdatableBindableList <FriendsList>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private UpdatableBindableList <EftFriendsList>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private UpdatableBindableList <SteamOnlyFriendsList>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private UpdatableBindableList <InputFriendsInvitations>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private UpdatableBindableList <OutputFriendsInvitations>k__BackingField; //Field offset: 0x78
	public readonly BindableEvent OnLastMessageUpdatedGlobal; //Field offset: 0x80
	public readonly BindableEvent OnDialogueSelectedGlobal; //Field offset: 0x88
	private readonly List _pendingInvitations; //Field offset: 0x90
	private ISocial _session; //Field offset: 0x98
	private string _matchingVersion; //Field offset: 0xA0
	private bool _sendingFriendsRequest; //Field offset: 0xA8
	private bool _chatScreenOpen; //Field offset: 0xA9
	private readonly Dictionary _nextFriendRequest; //Field offset: 0xB0
	private DateTime _steamSyncReadyAt; //Field offset: 0xB8
	private readonly HashSet _allSteamFriendIds; //Field offset: 0xC0
	private Action _eftFriendsUnsubscribe; //Field offset: 0xC8
	private Action _steamFriendsUnsubscribe; //Field offset: 0xD0
	[CompilerGenerated]
	private bool <FullyRead>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private bool <MessageListUpdating>k__BackingField; //Field offset: 0xD9
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0xDA
	[CompilerGenerated]
	private Action InitializationFinishedEvent; //Field offset: 0xE0

	public event Action InitializationFinishedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public private ChatSendDelegate ChatSendDelegate
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public IEnumerable Dialogues
	{
		 get { } //Length: 67
	}

	public private UpdatableBindableList EftFriendsList
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private UpdatableBindableList FriendsList
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool FullyRead
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private static UpdatableBindableList IgnoringYouList
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		private set { } //Length: 167
	}

	public private UpdatableBindableList InputFriendsInvitations
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsSteamLinked
	{
		 get { } //Length: 234
	}

	public private bool MessageListUpdating
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private UpdatableBindableList OutputFriendsInvitations
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private UpdatableBindableList PinnedDialogues
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private UpdatableChatMember PlayerMember
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private List ReadDialoguesQueue
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private DialogueChatMessage ReplyToMessage
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool ReportAvailable
	{
		 get { } //Length: 81
	}

	public private UpdatableBindableList SearchedFriendsList
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private UpdatableChatDialogue SelectedDialogue
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private UpdatableBindableList SteamOnlyFriendsList
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private int SteamSyncCooldownSeconds
	{
		private get { } //Length: 60
	}

	public private UpdatableChatMember SystemMember
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private UpdatableBindableList UnpinnedDialogues
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static SocialNetwork() { }

	public SocialNetwork() { }

	[CompilerGenerated]
	private bool <UpdateFriendsWithSteam>b__110_1(UpdatableChatMember x) { }

	[AsyncStateMachine(typeof(<AcceptAllFriendRequests>d__133))]
	public Task AcceptAllFriendRequests() { }

	public void AcceptFriendRequest(UpdatableFriendsInvitation invitation, Action callback) { }

	[CompilerGenerated]
	public void add_InitializationFinishedEvent(Action value) { }

	private void AddDialogueToReadQueue(UpdatableChatDialogue dialogue) { }

	public void AddTraderDialogueInviteMessage(string chatId, DialogInvitationMessageData invitationMessageData) { }

	public void AllAttachmentsFromDialog(string dialogId, Action callback) { }

	public void BanPlayer(UpdatableChatMember member, TimeSpan duration) { }

	[AsyncStateMachine(typeof(<CancelFriendRequest>d__131))]
	public Task CancelFriendRequest(UpdatableChatMember member) { }

	public bool CanReadDialogue(UpdatableChatDialogue dialogue) { }

	public bool CanSyncSteam() { }

	[CanBeNull]
	public UpdatableChatDialogue CreateDialogue(ChatRoomInformation roomInformation, bool select = false) { }

	public void CreateGroupDialogue(string name, string[] members, Callback callback) { }

	public void DeclineFriendRequest(UpdatableFriendsInvitation invitation, Callback callback) { }

	[AsyncStateMachine(typeof(<DeleteDialog>d__127))]
	public void DeleteDialog(UpdatableChatDialogue dialogue) { }

	[AsyncStateMachine(typeof(<DeleteDialogMessages>d__126))]
	public void DeleteDialogMessages(UpdatableChatDialogue dialogue) { }

	public void DeleteMessage(UpdatableChatDialogue dialogue, DialogueChatMessage message) { }

	public void DisplayMessage(DialogueChatMessage message, UpdatableChatDialogue dialogue) { }

	private void DisplayMessage(DialogueChatMessage message, string dialogueId) { }

	public void FindAccountByNickname(string nickname, Action callback) { }

	private void FriendRequestCanceled(NotificationFriendRequestCanceled friendRequestCanceled) { }

	[CompilerGenerated]
	private ChatSendDelegate get_ChatSendDelegate() { }

	public IEnumerable get_Dialogues() { }

	[CompilerGenerated]
	public UpdatableBindableList get_EftFriendsList() { }

	[CompilerGenerated]
	public UpdatableBindableList get_FriendsList() { }

	[CompilerGenerated]
	public bool get_FullyRead() { }

	[CompilerGenerated]
	public static UpdatableBindableList get_IgnoringYouList() { }

	[CompilerGenerated]
	public UpdatableBindableList get_InputFriendsInvitations() { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	public bool get_IsSteamLinked() { }

	[CompilerGenerated]
	public bool get_MessageListUpdating() { }

	[CompilerGenerated]
	public UpdatableBindableList get_OutputFriendsInvitations() { }

	[CompilerGenerated]
	public UpdatableBindableList get_PinnedDialogues() { }

	[CompilerGenerated]
	public UpdatableChatMember get_PlayerMember() { }

	[CompilerGenerated]
	private List get_ReadDialoguesQueue() { }

	[CompilerGenerated]
	public DialogueChatMessage get_ReplyToMessage() { }

	public bool get_ReportAvailable() { }

	[CompilerGenerated]
	public UpdatableBindableList get_SearchedFriendsList() { }

	[CompilerGenerated]
	public UpdatableChatDialogue get_SelectedDialogue() { }

	[CompilerGenerated]
	public UpdatableBindableList get_SteamOnlyFriendsList() { }

	private int get_SteamSyncCooldownSeconds() { }

	[CompilerGenerated]
	public UpdatableChatMember get_SystemMember() { }

	[CompilerGenerated]
	public UpdatableBindableList get_UnpinnedDialogues() { }

	public void GetChatServersList(Action callback) { }

	public string GetDialogueHeaderByType(UpdatableChatDialogue info) { }

	[CanBeNull]
	public UpdatableFriendsInvitation GetInvitationByProfile(UpdatableChatMember member) { }

	public int GetSteamSyncCooldownSeconds() { }

	internal void Init(ISocial session, string matchingVersion, ChatContacts chatContacts, Result roomInformation) { }

	[AsyncStateMachine(typeof(<Init>d__109))]
	internal Task Init(ISocial session, string matchingVersion) { }

	public void InviteToDialogue(UpdatableChatDialogue dialogue, List members, Callback callback) { }

	public bool IsPlatformLinked(ELinkedPlatform platform) { }

	public void LeaveDialogue(UpdatableChatDialogue dialogue, Callback callback) { }

	private void MessageReceivedHandler(DialogueChatMessage message, string dialogueId) { }

	public void MutePlayer(UpdatableChatMember member, Callback callback) { }

	private void NewFriendRequestReceived(NotificationNewFriendsRequest newFriend) { }

	private void NotificationReceived(Notification notification) { }

	public void PinDialog(UpdatableChatDialogue dialogue) { }

	public void PinFriend(UpdatableChatMember member) { }

	public bool PlayerAlreadyReported(string aId, EReportType reportType) { }

	public void ReadDialogues(Action callback = null) { }

	private void RebuildCombinedFriendsList() { }

	[AsyncStateMachine(typeof(<RedeemProfileRewards>d__119))]
	public Task RedeemProfileRewards(IEnumerable rewards) { }

	[CompilerGenerated]
	public void remove_InitializationFinishedEvent(Action value) { }

	public void RemoveDialogue(UpdatableChatDialogue dialogue) { }

	private void RemoveDialogueFromReadQueue(UpdatableChatDialogue dialogue) { }

	public void RemoveFromFriendsList(UpdatableChatMember member, Callback callback) { }

	public void RemoveMemberFromDialogue(UpdatableChatDialogue dialogue, UpdatableChatMember member, Callback callback) { }

	private void RemoveMessage(UpdatableChatDialogue dialogue, DialogueChatMessage messageToDelete) { }

	public void RemoveTraderDialogueInvitationMessage(string chatId) { }

	public void ReportNickname(string playerId, Callback callback) { }

	public void SendFriendRequest(UpdatableChatMember member, Callback callback) { }

	public void SendMessage(UpdatableChatDialogue dialogue, EMessageType messageType, DialogueChatMessage message, Action callback) { }

	[CompilerGenerated]
	public void set_ChatSendDelegate(ChatSendDelegate value) { }

	[CompilerGenerated]
	private void set_EftFriendsList(UpdatableBindableList value) { }

	[CompilerGenerated]
	private void set_FriendsList(UpdatableBindableList value) { }

	[CompilerGenerated]
	private void set_FullyRead(bool value) { }

	[CompilerGenerated]
	private static void set_IgnoringYouList(UpdatableBindableList value) { }

	[CompilerGenerated]
	private void set_InputFriendsInvitations(UpdatableBindableList value) { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	[CompilerGenerated]
	private void set_MessageListUpdating(bool value) { }

	[CompilerGenerated]
	private void set_OutputFriendsInvitations(UpdatableBindableList value) { }

	[CompilerGenerated]
	private void set_PinnedDialogues(UpdatableBindableList value) { }

	[CompilerGenerated]
	private void set_PlayerMember(UpdatableChatMember value) { }

	[CompilerGenerated]
	private void set_ReadDialoguesQueue(List value) { }

	[CompilerGenerated]
	private void set_ReplyToMessage(DialogueChatMessage value) { }

	[CompilerGenerated]
	private void set_SearchedFriendsList(UpdatableBindableList value) { }

	[CompilerGenerated]
	private void set_SelectedDialogue(UpdatableChatDialogue value) { }

	[CompilerGenerated]
	private void set_SteamOnlyFriendsList(UpdatableBindableList value) { }

	[CompilerGenerated]
	private void set_SystemMember(UpdatableChatMember value) { }

	[CompilerGenerated]
	private void set_UnpinnedDialogues(UpdatableBindableList value) { }

	public void SetBannedPlayerStatus(UpdatableChatMember member, DateTime toDateTime) { }

	public void SetChatScreenOpenStatus(bool status) { }

	private void SetDialogueSelected(UpdatableChatDialogue dialogue, bool isSelected) { }

	public void SetReplyToMessage(DialogueChatMessage replyMessage) { }

	public void SetSelectedStatus(UpdatableChatDialogue dialogue, bool isSelected) { }

	public void SetUnbannedPlayerStatus(UpdatableChatMember member) { }

	private void ShowTooManyRequestsMessage(int secondsLeft) { }

	[AsyncStateMachine(typeof(<SyncSteamFriends>d__115))]
	public Task SyncSteamFriends() { }

	private DialogueChatMessage SystemMessage(UpdatableChatMember member, EMessageParamsAction paramsAction) { }

	public void TransferLeadership(UpdatableChatDialogue dialogue, UpdatableChatMember to, Callback callback) { }

	public bool TryGetDialog(string chatRoomId, out UpdatableChatDialogue dialog) { }

	public void UnbanPlayer(UpdatableChatMember member) { }

	public void UnmutePlayer(UpdatableChatMember member, Callback callback) { }

	public void UnpinDialog(UpdatableChatDialogue dialogue) { }

	public void UnpinFriend(UpdatableChatMember member) { }

	public void UpdateDialogMessages(UpdatableChatDialogue dialogue, double time) { }

	[AsyncStateMachine(typeof(<UpdateDialogueList>d__123))]
	public Task UpdateDialogueList() { }

	private void UpdateDialogueList(Result dialogListResult) { }

	private void UpdateFriendsWithSteam(UpdatableChatMember[] steamMembers) { }

	public void UpdateReadMessages() { }

}

