namespace EFT.UI.Chat;

public sealed class MessagesContainer : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static LightScrollerDataTypeGetter <>9__16_3; //Field offset: 0x8
		public static Action <>9__16_4; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Enum <Show>b__16_3(MessageData messageData) { }

		internal void <Show>b__16_4(MessageData messageData, MessageFork view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public TraderSettings traderSettings; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal UpdatableChatMember <GetProfileByMessage>b__0(string id) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Comparison <0>__Comparer; //Field offset: 0x0

	}

	[SerializeField]
	private LightScroller _scroller; //Field offset: 0x70
	[SerializeField]
	private MessageFork _cellViewPrefab; //Field offset: 0x78
	[SerializeField]
	private GameObject _loader; //Field offset: 0x80
	[SerializeField]
	private SimpleContextMenu _contextMenu; //Field offset: 0x88
	[SerializeField]
	private BanTimeWindow _banTimeWindow; //Field offset: 0x90
	[SerializeField]
	private ChatMembersPanel _chatMembersPanel; //Field offset: 0x98
	[SerializeField]
	private GameObject _dateSeparator; //Field offset: 0xA0
	[SerializeField]
	private TMP_Text _dateText; //Field offset: 0xA8
	private SocialNetwork _social; //Field offset: 0xB0
	private ChatScreen _screen; //Field offset: 0xB8
	private UpdatableChatDialogue _dialogue; //Field offset: 0xC0
	private ConvertedBindableList _messageList; //Field offset: 0xC8
	private IEnumerable _newMessages; //Field offset: 0xD0
	private Action _onOfferSelected; //Field offset: 0xD8
	private Action _onItemsTransfer; //Field offset: 0xE0

	public MessagesContainer() { }

	[CompilerGenerated]
	private void <Show>b__16_0(DialogueChatMessage message) { }

	[CompilerGenerated]
	private void <Show>b__16_1(bool isLoading) { }

	[CompilerGenerated]
	private MessageFork <Show>b__16_2(MessageData messageData) { }

	public virtual void Close() { }

	public virtual void Display() { }

	private UpdatableChatMember GetProfileByMessage(DialogueChatMessage message) { }

	public bool HandleScrollCommand(ECommand command) { }

	private bool MessageDataFromMessage(DialogueChatMessage info, out MessageData messageData) { }

	private void ScrollToTheBottom() { }

	private void SetChatMembersVisibleStatus() { }

	public void Show(SocialNetwork social, ChatScreen screen, UpdatableChatDialogue dialogue, Action onItemsTransferClicked, Action onOfferSelected) { }

	private void ShowContextMenu(DialogueChatMessage message, Vector2 pos) { }

	private void Update() { }

}

