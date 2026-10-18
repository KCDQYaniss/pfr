namespace EFT.UI.Chat;

public class MessageFork : UIElement
{
	[SerializeField]
	private MessageView _yourChatMessage; //Field offset: 0x70
	[SerializeField]
	private MessageView _opponentChatMessage; //Field offset: 0x78
	[SerializeField]
	private MessageView _systemMessage; //Field offset: 0x80
	[SerializeField]
	private AttachmentMessageView _attachmentMessage; //Field offset: 0x88
	[SerializeField]
	private GameObject _dateLabel; //Field offset: 0x90
	[SerializeField]
	private TMP_Text _dateText; //Field offset: 0x98

	public MessageFork() { }

	public virtual void Close() { }

	public void Show(MessageData data) { }

}

