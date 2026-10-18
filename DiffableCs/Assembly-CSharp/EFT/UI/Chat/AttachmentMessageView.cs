namespace EFT.UI.Chat;

public sealed class AttachmentMessageView : MessageView
{
	[SerializeField]
	private DefaultUIButton _transferButtonSpawner; //Field offset: 0xE8
	[SerializeField]
	private LocalizedText _receivedLabel; //Field offset: 0xF0
	[SerializeField]
	private LocalizedText _outOfTimeLabel; //Field offset: 0xF8
	[SerializeField]
	private TextMeshProUGUI _timeToGetLabel; //Field offset: 0x100
	[SerializeField]
	private Image _messageIcon; //Field offset: 0x108
	[SerializeField]
	private Sprite _insuranceIcon; //Field offset: 0x110
	[SerializeField]
	private Sprite _questIcon; //Field offset: 0x118
	[SerializeField]
	private Sprite _systemIcon; //Field offset: 0x120
	[SerializeField]
	private Sprite _deliveryIcon; //Field offset: 0x128
	[SerializeField]
	private TextMeshProUGUI _messageDescriptionLabel; //Field offset: 0x130
	[SerializeField]
	private Color _insuranceTextColor; //Field offset: 0x138
	[SerializeField]
	private Color _questTextColor; //Field offset: 0x148
	[SerializeField]
	private Color _systemTextColor; //Field offset: 0x158
	[SerializeField]
	private Image _messageBackground; //Field offset: 0x168
	[SerializeField]
	private GameObject _insuranceLimiter; //Field offset: 0x170
	[SerializeField]
	private GameObject _messageAttachmentsObject; //Field offset: 0x178
	[SerializeField]
	private Color _insuranceColor; //Field offset: 0x180
	[SerializeField]
	private Color _questColor; //Field offset: 0x190
	[SerializeField]
	private Color _systemColor; //Field offset: 0x1A0
	[SerializeField]
	private Color _deliveryColor; //Field offset: 0x1B0
	private Action _onTransferAll; //Field offset: 0x1C0
	private Action _onItemsTransfer; //Field offset: 0x1C8
	private DateTime _lastUpdate; //Field offset: 0x1D0
	private TimeSpan _maxStorageTime; //Field offset: 0x1D8
	private long _messageStorageTime; //Field offset: 0x1E0

	private bool AnyAttachments
	{
		private get { } //Length: 32
	}

	private bool AvailableForObtain
	{
		private get { } //Length: 152
	}

	private DateTime PackageExpirationTime
	{
		private get { } //Length: 170
	}

	public AttachmentMessageView() { }

	[CompilerGenerated]
	private void <Awake>b__31_0() { }

	private void Awake() { }

	private bool get_AnyAttachments() { }

	private bool get_AvailableForObtain() { }

	private DateTime get_PackageExpirationTime() { }

	private void OnCultureUpdatedHandler() { }

	private void OnEnable() { }

	private void SetButtonsStatus() { }

	private void SetMessageDescriptionLabel(EMessageType type) { }

	private void SetMessageFormalization(EMessageType type) { }

	public void Show(DialogueChatMessage chatMessage, UpdatableChatMember member, EMessageType dialogueType, MessageQuote quote, Action onMessageClicked, Action onMessageDoubleClicked, Action onItemsTransfer, Action onOfferSelected) { }

	private void Update() { }

	public virtual void UpdateMessageStatus() { }

}

