namespace EFT.UI.Chat;

public sealed class DialogueData
{
	public DateTime LocalDateTime; //Field offset: 0x10
	public bool Pinned; //Field offset: 0x18
	public TMP_Text UsersCountLabel; //Field offset: 0x20
	public ChatMessageSendBlock ChatMessageSendBlock; //Field offset: 0x28
	public Action OnDialogueSelected; //Field offset: 0x30
	public Action OnDialogueRemoved; //Field offset: 0x38
	public SocialNetwork SocialNetwork; //Field offset: 0x40
	public UpdatableChatDialogue Dialogue; //Field offset: 0x48
	public Action OnPinned; //Field offset: 0x50
	public Action OnTransferAll; //Field offset: 0x58
	public Action OnContextMenuCalled; //Field offset: 0x60
	public Action OnChannelListCalled; //Field offset: 0x68

	public DialogueData() { }

	public static int Comparer(DialogueData data1, DialogueData data2) { }

}

