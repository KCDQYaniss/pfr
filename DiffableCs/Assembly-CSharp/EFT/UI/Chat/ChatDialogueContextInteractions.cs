namespace EFT.UI.Chat;

public sealed class ChatDialogueContextInteractions : ContextInteractions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__14_1; //Field offset: 0x8
		public static Action <>9__15_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <DeleteDialog>b__15_1() { }

		internal void <DeleteDialogMessages>b__14_1() { }

	}

	private const string LEAVE_GROUP_DIALOG_NOTIFICATION = "You have left the dialogue "; //Field offset: 0x0
	private const string DELETE_ALL_DIALOG_MESSAGES_CONFIRMATION = "Do you really want to delete all messages with user: {0}?"; //Field offset: 0x0
	private const string DELETE_GROUP_DIALOG_CONFIRMATION = "UI/Chat/delete_group_dialog_confirmation"; //Field offset: 0x0
	private const string DELETE_DIALOG_CONFIRMATION = "UI/Chat/delete_dialog_confirmation"; //Field offset: 0x0
	private readonly UpdatableChatMember _playerMember; //Field offset: 0x38
	private readonly ChatInvitePlayersPanel _invitePlayersPanel; //Field offset: 0x40
	private readonly SocialNetwork _social; //Field offset: 0x48
	private readonly UpdatableChatDialogue _selectedDialogue; //Field offset: 0x50

	private UpdatableChatMember GetRandomMember
	{
		private get { } //Length: 248
	}

	public ChatDialogueContextInteractions(SocialNetwork social, ChatInvitePlayersPanel invitePlayersPanel, UpdatableChatDialogue selectedDialogue) { }

	[CompilerGenerated]
	private void <DeleteDialog>b__15_0() { }

	[CompilerGenerated]
	private void <DeleteDialogMessages>b__14_0() { }

	[CompilerGenerated]
	private bool <get_GetRandomMember>b__12_0(UpdatableChatMember item) { }

	[CompilerGenerated]
	private void <LeaveDialogue>b__10_0(IResult result) { }

	[CompilerGenerated]
	private void <LeaveDialogueWithTransfer>b__9_0(IResult callback) { }

	private void DeleteDialog() { }

	private void DeleteDialogMessages() { }

	protected virtual void ExecuteInteractionInternal(EDialogueInteractionButton interaction) { }

	private UpdatableChatMember get_GetRandomMember() { }

	private void InvitePlayersToDialogue() { }

	public virtual bool IsActive(EDialogueInteractionButton button) { }

	public virtual IResult IsInteractive(EDialogueInteractionButton button) { }

	private void LeaveDialogue() { }

	private void LeaveDialogueWithTransfer() { }

	private void WatchProfile() { }

}

