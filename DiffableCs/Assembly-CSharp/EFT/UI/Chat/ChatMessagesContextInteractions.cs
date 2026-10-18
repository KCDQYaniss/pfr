namespace EFT.UI.Chat;

public sealed class ChatMessagesContextInteractions : ContextInteractions
{
	private readonly DialogueChatMessage _clickedMessage; //Field offset: 0x38
	private readonly UpdatableChatDialogue _selectedDialogue; //Field offset: 0x40
	private readonly ChatScreen _screen; //Field offset: 0x48
	private readonly BanTimeWindow _banTimeWindow; //Field offset: 0x50
	private readonly SocialNetwork _social; //Field offset: 0x58
	private readonly UpdatableChatMember _playerMember; //Field offset: 0x60
	private readonly UpdatableChatMember _selectedMember; //Field offset: 0x68

	public ChatMessagesContextInteractions(ChatScreen screen, SocialNetwork social, BanTimeWindow banTimeWindow, UpdatableChatDialogue dialogue, DialogueChatMessage clickedMessage) { }

	[CompilerGenerated]
	private void <BanPlayer>b__8_0(int index) { }

	private void BanPlayer() { }

	private void DeleteMessage() { }

	protected virtual void ExecuteInteractionInternal(EMessageContextInteraction interaction) { }

	public virtual bool IsActive(EMessageContextInteraction button) { }

	public virtual IResult IsInteractive(EMessageContextInteraction button) { }

	private void SetMessageResponse() { }

	private DialogWindowContext ShowBanMessageWindow(Action acceptAction) { }

	private void UnbanPlayer() { }

}

