namespace EFT.UI.Chat;

public sealed class ChatScreen : UIScreen, IPointerClickHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__47_2; //Field offset: 0x8
		public static Func <>9__57_1; //Field offset: 0x10
		public static Func <>9__57_2; //Field offset: 0x18
		public static Func <>9__57_3; //Field offset: 0x20
		public static Func <>9__57_4; //Field offset: 0x28
		public static Func <>9__57_0; //Field offset: 0x30
		public static Action <>9__57_5; //Field offset: 0x38
		public static Action <>9__57_6; //Field offset: 0x40
		public static Action <>9__62_0; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__47_2() { }

		internal bool <ProcessRewards>b__57_0(ProfileChangeEvent evt) { }

		internal bool <ProcessRewards>b__57_1(ProfileChangeEvent evt) { }

		internal IEnumerable <ProcessRewards>b__57_2(DialogueChatMessage message) { }

		internal bool <ProcessRewards>b__57_3(Item item) { }

		internal string <ProcessRewards>b__57_4(Item item) { }

		internal void <ProcessRewards>b__57_5(ProfileChangeEvent evt) { }

		internal void <ProcessRewards>b__57_6(DialogueChatMessage message) { }

		internal void <SendInputFieldMessage>b__62_0() { }

	}

	[CompilerGenerated]
	private struct <ProcessRewards>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DialogueChatMessage[] messages; //Field offset: 0x20
		public ChatScreen <>4__this; //Field offset: 0x28
		private List <messagesWithItems>5__2; //Field offset: 0x30
		private List <messagesWithQuestItems>5__3; //Field offset: 0x38
		private List <profileChangeEvents>5__4; //Field offset: 0x40
		private DateTime <expirationTime>5__5; //Field offset: 0x48
		private Item[] <questItems>5__6; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TransferAllQuestItems>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable items; //Field offset: 0x20
		public ChatScreen <>4__this; //Field offset: 0x28
		public List messagesWithQuestItems; //Field offset: 0x30
		private TemporaryGrid <temporaryGrid>5__2; //Field offset: 0x38
		private DefaultItemContext <itemContext>5__3; //Field offset: 0x40
		private ItemUiContext <itemUiContext>5__4; //Field offset: 0x48
		private List <completableItems>5__5; //Field offset: 0x50
		private OperationResult <quickResult>5__6; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class DialoguesListSwitcherTabController : SimpleTabController
	{
		private readonly ChatScreen _screen; //Field offset: 0x10
		private readonly EDialogType _dialogType; //Field offset: 0x18

		public DialoguesListSwitcherTabController(EDialogType dialogType, ChatScreen screen) { }

		public virtual void Show() { }

	}

	private const float UPDATE_DIALOGUE_STATUS_DELAY = 80; //Field offset: 0x0
	[CompilerGenerated]
	private Action DialogStartEvent; //Field offset: 0x90
	[CompilerGenerated]
	private Action CloseEvent; //Field offset: 0x98
	[SerializeField]
	private GameObject _chatScreenObject; //Field offset: 0xA0
	[SerializeField]
	private GameObject _captionPanel; //Field offset: 0xA8
	[SerializeField]
	private ChatMessageSendBlock _inputPanel; //Field offset: 0xB0
	[SerializeField]
	private ChatMembersPanel _chatMembersPanel; //Field offset: 0xB8
	[SerializeField]
	private Button _closeButton; //Field offset: 0xC0
	[SerializeField]
	private SwitchableParamsButton _switchableParamsButton; //Field offset: 0xC8
	[SerializeField]
	private Button _friendsButton; //Field offset: 0xD0
	[SerializeField]
	private CustomTextMeshProUGUI _friendsButtonLabel; //Field offset: 0xD8
	[SerializeField]
	private Button _createGroupDialog; //Field offset: 0xE0
	[SerializeField]
	private GameObject _quoteGameObject; //Field offset: 0xE8
	[SerializeField]
	private CustomTextMeshProUGUI _quoteLabel; //Field offset: 0xF0
	[SerializeField]
	private RectTransform _messagesContainerParent; //Field offset: 0xF8
	[SerializeField]
	private MessagesContainer _messagesContainerTemplate; //Field offset: 0x100
	[SerializeField]
	private DialoguesContainer _dialoguesContainer; //Field offset: 0x108
	[SerializeField]
	private ChatFriendsPanel _chatFriendsPanel; //Field offset: 0x110
	[SerializeField]
	private ChatCreateDialoguePanel _chatCreateDialoguePanel; //Field offset: 0x118
	[SerializeField]
	private ValidationInputField _chatInputField; //Field offset: 0x120
	[SerializeField]
	private DefaultUIButton _sendButton; //Field offset: 0x128
	[SerializeField]
	private ProfileEventsWindow _profileEventsWindow; //Field offset: 0x130
	[SerializeField]
	private UiElementBlocker _friendsBlocker; //Field offset: 0x138
	[SerializeField]
	private Tab _usersTab; //Field offset: 0x140
	[SerializeField]
	private Tab _tradersTab; //Field offset: 0x148
	[SerializeField]
	private DialogueInviteMessageView _dialogueInviteMessageView; //Field offset: 0x150
	private SocialNetwork _social; //Field offset: 0x158
	private ProfileInfo _profileInfo; //Field offset: 0x160
	private ItemController _itemController; //Field offset: 0x168
	private Action _onTransferItems; //Field offset: 0x170
	private Action _onOfferSelected; //Field offset: 0x178
	private DateTime _lastResponse; //Field offset: 0x180
	private int _friendsListCount; //Field offset: 0x188
	private int _requestsCount; //Field offset: 0x18C
	private TabGroup _tabGroup; //Field offset: 0x190
	private EDialogType _selectedDialogsGroup; //Field offset: 0x198
	private readonly Dictionary _instantiatedContainers; //Field offset: 0x1A0

	public event Action CloseEvent
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action DialogStartEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	private GameObject ChatScreenObject
	{
		private get { } //Length: 8
	}

	private DialogueChatMessage GetPlayerChatMessage
	{
		private get { } //Length: 625
	}

	public ChatScreen() { }

	[CompilerGenerated]
	private void <Awake>b__47_0() { }

	[CompilerGenerated]
	private void <Awake>b__47_1() { }

	[CompilerGenerated]
	private void <CreateTabGroup>b__49_0() { }

	[CompilerGenerated]
	private void <DialogueSelected>b__56_0(DialogInvitationMessageData data) { }

	[CompilerGenerated]
	private void <DialogueSelected>b__56_1(DialogueChatMessage chatMessage) { }

	[CompilerGenerated]
	private void <DialogueSelected>b__56_2(string arg) { }

	[CompilerGenerated]
	private void <Show>b__48_0() { }

	[CompilerGenerated]
	private void <TransferAll>b__54_0(DialogueChatMessage[] messages) { }

	[CompilerGenerated]
	public void add_CloseEvent(Action value) { }

	[CompilerGenerated]
	public void add_DialogStartEvent(Action value) { }

	private void Awake() { }

	private void BanChangedHandler(EBanType banType = 5) { }

	public virtual void Close() { }

	private void CreateTabGroup() { }

	private void DialogRemoved(UpdatableChatDialogue dialogue) { }

	private void DialogueSelected(UpdatableChatDialogue dialogue, DialogueView dialogueView) { }

	private bool FilterDialogue(UpdatableChatDialogue dialogue) { }

	private GameObject get_ChatScreenObject() { }

	private DialogueChatMessage get_GetPlayerChatMessage() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	private void OnSelectedDialogChanged(UpdatableChatDialogue dialog) { }

	[AsyncStateMachine(typeof(<ProcessRewards>d__57))]
	private Task ProcessRewards(DialogueChatMessage[] messages) { }

	[CompilerGenerated]
	public void remove_CloseEvent(Action value) { }

	[CompilerGenerated]
	public void remove_DialogStartEvent(Action value) { }

	private void RepeatUpdateReadStatus() { }

	private void SelectInputField() { }

	private void SendInputFieldMessage() { }

	private void SetFriendsLabelText() { }

	private void SetPriority() { }

	public void SetQuotedMessage(DialogueChatMessage message) { }

	private void SetSelectedDialogueGroup() { }

	public void Show(SocialNetwork social, ProfileInfo profileInfo, ItemController itemController, Action onTransferItems, Action onOfferSelected) { }

	private void TransferAll(UpdatableChatDialogue dialog) { }

	[AsyncStateMachine(typeof(<TransferAllQuestItems>d__58))]
	private Task TransferAllQuestItems(List messagesWithQuestItems, IEnumerable items) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

	private void UpdateDialoguesContainer(EDialogType dialogType) { }

}

