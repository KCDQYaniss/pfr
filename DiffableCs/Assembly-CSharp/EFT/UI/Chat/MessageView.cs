namespace EFT.UI.Chat;

public class MessageView : UIElement, IPointerClickHandler, IEventSystemHandler
{
	private static readonly EMessageType[] TraderMessageTypes; //Field offset: 0x0
	private const float DoubleClickDelay = 0.3; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _senderName; //Field offset: 0x70
	[SerializeField]
	private ClickableUIText _senderMessage; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _timestampLabel; //Field offset: 0x80
	[SerializeField]
	private GameObject _quoteGameObject; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI _quotedName; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _quotedMessage; //Field offset: 0x98
	[SerializeField]
	private ChatSpecialIcon _specialIcon; //Field offset: 0xA0
	[SerializeField]
	private GameObject _senderNameBlock; //Field offset: 0xA8
	protected DialogueChatMessage DialogueChatMessage; //Field offset: 0xB0
	private UpdatableChatMember _chatMember; //Field offset: 0xB8
	private EMessageType _dialogueType; //Field offset: 0xC0
	private Action _onMessageClicked; //Field offset: 0xC8
	private Action _onMessageDoubleClicked; //Field offset: 0xD0
	private Action _onOfferSelected; //Field offset: 0xD8
	private float _doubleClickTimer; //Field offset: 0xE0
	private bool _mouseClicked; //Field offset: 0xE4
	private bool _showSenderName; //Field offset: 0xE5

	private static MessageView() { }

	public MessageView() { }

	public virtual void Close() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	protected void SetSenderMessage(DialogueChatMessage message) { }

	protected void SetSenderName() { }

	public void Show(DialogueChatMessage chatMessage, UpdatableChatMember chatMember, EMessageType dialogueType, MessageQuote quote, Action onMessageClicked, Action onMessageDoubleClicked, Action onOfferSelected) { }

	private void Update() { }

	public override void UpdateMessageStatus() { }

}

