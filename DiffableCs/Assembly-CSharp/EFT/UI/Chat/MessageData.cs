namespace EFT.UI.Chat;

public class MessageData
{
	public DateTime LocalDateTime; //Field offset: 0x10
	public DialogueChatMessage Message; //Field offset: 0x18
	public SocialNetwork SocialNetwork; //Field offset: 0x20
	public EMessageType DialogueType; //Field offset: 0x28
	public EMessageViewType MessageType; //Field offset: 0x2C
	public UpdatableChatMember Member; //Field offset: 0x30
	[CanBeNull]
	public MessageQuote Quote; //Field offset: 0x38
	public Action ItemsTransfer; //Field offset: 0x40
	public Action ContextMenuClicked; //Field offset: 0x48
	public Action MessageDoubleClicked; //Field offset: 0x50
	public Action OfferSelected; //Field offset: 0x58
	public bool ShowDateLabel; //Field offset: 0x60

	public MessageData() { }

	public static int Comparer(MessageData data1, MessageData data2) { }

}

