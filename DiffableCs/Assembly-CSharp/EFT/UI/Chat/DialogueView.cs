namespace EFT.UI.Chat;

public sealed class DialogueView : UIElement, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler, IPointerClickHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public TraderSettings traderSettings; //Field offset: 0x10

		public <>c__DisplayClass48_0() { }

		internal UpdatableChatMember <SetValuesByDialogueType>b__0(string id) { }

	}

	[SerializeField]
	private TextMeshProUGUI _playerNameLabel; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _lastMessageLabel; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _timeStamp; //Field offset: 0x80
	[SerializeField]
	private GameObject _dialogueInvitationObject; //Field offset: 0x88
	[SerializeField]
	private GameObject _newMessagesObject; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _newMessagesCount; //Field offset: 0x98
	[SerializeField]
	private GameObject _newAttachmentsMessagesObject; //Field offset: 0xA0
	[SerializeField]
	private TextMeshProUGUI _newAttachmentsMessagesCount; //Field offset: 0xA8
	[SerializeField]
	private ChatSpecialIcon _specialIcon; //Field offset: 0xB0
	[SerializeField]
	private Toggle _pinButton; //Field offset: 0xB8
	[SerializeField]
	private Image _pinImage; //Field offset: 0xC0
	[SerializeField]
	private Sprite _pinnedSprite; //Field offset: 0xC8
	[SerializeField]
	private Sprite _unpinnedSprite; //Field offset: 0xD0
	[SerializeField]
	private Button _settingsButton; //Field offset: 0xD8
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0xE0
	[SerializeField]
	private Toggle _dialogueToggle; //Field offset: 0xE8
	[SerializeField]
	private Image _dialogueIcon; //Field offset: 0xF0
	[SerializeField]
	private Sprite _singleDialogueSprite; //Field offset: 0xF8
	[SerializeField]
	private Sprite _groupDialogueSprite; //Field offset: 0x100
	[SerializeField]
	private Sprite _systemDialogueSprite; //Field offset: 0x108
	[SerializeField]
	private Color _defaultImageColor; //Field offset: 0x110
	[SerializeField]
	private Color _hoverImageColor; //Field offset: 0x120
	[SerializeField]
	private Color _selectedImageColor; //Field offset: 0x130
	[SerializeField]
	private Color _defaultHeaderColor; //Field offset: 0x140
	[SerializeField]
	private Color _selectedHeaderColor; //Field offset: 0x150
	[SerializeField]
	private Color _defaultTimestampColor; //Field offset: 0x160
	[SerializeField]
	private Color _defaultMessageColor; //Field offset: 0x170
	[SerializeField]
	private Color _selectedMessageColor; //Field offset: 0x180
	private Action _onPinButtonPressed; //Field offset: 0x190
	private Action _onTransferAll; //Field offset: 0x198
	private Action _onContextMenuClicked; //Field offset: 0x1A0
	private Action _onDialogueSelected; //Field offset: 0x1A8
	private Action _onDialogueRemoved; //Field offset: 0x1B0
	private Action _onChannelListClicked; //Field offset: 0x1B8
	private bool _selected; //Field offset: 0x1C0
	private SocialNetwork _social; //Field offset: 0x1C8
	private UpdatableChatDialogue _dialogue; //Field offset: 0x1D0
	private UpdatableChatMember _playerProfileMember; //Field offset: 0x1D8
	private ChatMessageSendBlock _chatMessageSendBlock; //Field offset: 0x1E0
	private TMP_Text _dialogueUsersCountLabel; //Field offset: 0x1E8

	private int NewAttachmentsMessagesCount
	{
		private set { } //Length: 341
	}

	private int NewMessagesCount
	{
		private set { } //Length: 341
	}

	public DialogueView() { }

	[CompilerGenerated]
	private void <Awake>b__44_0() { }

	[CompilerGenerated]
	private void <SetSendMessageBlockPanel>b__52_0() { }

	private void Awake() { }

	private void Clear() { }

	public virtual void Close() { }

	private void CloseSendBlock() { }

	private void OnCultureUpdatedHandler() { }

	private void OnDialogueRemoved() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void SelectView(bool value) { }

	private void set_NewAttachmentsMessagesCount(int value) { }

	private void set_NewMessagesCount(int value) { }

	private void SetLastMessage(DialogueChatMessage message) { }

	private void SetPinState(bool state) { }

	private void SetSelectedStatus(bool selected) { }

	private void SetSendMessageBlockPanel() { }

	private void SetToggle(bool value) { }

	private void SetUsersCountLabel() { }

	private void SetValuesByDialogueType() { }

	public void Show(DialogueData data) { }

	private void UpdateLastMessage(DialogueChatMessage message) { }

}

