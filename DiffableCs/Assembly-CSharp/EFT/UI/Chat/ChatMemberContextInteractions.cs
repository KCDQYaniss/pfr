namespace EFT.UI.Chat;

public sealed class ChatMemberContextInteractions : ContextInteractions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8
		public static Func <>9__10_1; //Field offset: 0x10
		public static Callback <>9__18_0; //Field offset: 0x18
		public static Callback <>9__19_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal UpdatableChatMember <.ctor>b__10_0(UpdatableFriendsInvitation x) { }

		internal UpdatableChatMember <.ctor>b__10_1(UpdatableFriendsInvitation x) { }

		internal void <MutePlayer>b__18_0(IResult arg) { }

		internal void <UnmutePlayer>b__19_0(IResult arg) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Callback <0>__HandleFailedResultAsWarning; //Field offset: 0x0

	}

	public static readonly Dictionary BanTimeNotches; //Field offset: 0x0
	private readonly SocialNetwork _social; //Field offset: 0x38
	private readonly UpdatableChatMember _selectedMember; //Field offset: 0x40
	private readonly UpdatableChatMember _playerMember; //Field offset: 0x48
	[CanBeNull]
	private readonly UpdatableFriendsInvitation _invitation; //Field offset: 0x50
	[CanBeNull]
	private readonly BanTimeWindow _banTimeWindow; //Field offset: 0x58
	private readonly bool _activeInput; //Field offset: 0x60
	private readonly bool _activeOutput; //Field offset: 0x61

	public virtual bool HasIcons
	{
		 get { } //Length: 3
	}

	private static ChatMemberContextInteractions() { }

	public ChatMemberContextInteractions(SocialNetwork social, BanTimeWindow banTimeWindow, UpdatableChatMember member, UpdatableFriendsInvitation invitation) { }

	[CompilerGenerated]
	private void <AcceptFriendsRequest>b__15_0(UpdatableFriendsInvitation result) { }

	[CompilerGenerated]
	private void <BanPlayer>b__23_0(int index) { }

	[CompilerGenerated]
	private void <DeclineFriendsRequest>b__16_0(IResult result) { }

	[CompilerGenerated]
	private void <DeleteFromFriendsList>b__17_0(IResult arg) { }

	[CompilerGenerated]
	private void <KickPlayer>b__20_0(IResult result) { }

	[CompilerGenerated]
	private void <SendFriendsRequest>b__13_0(IResult result) { }

	[CompilerGenerated]
	private void <TransferLeadership>b__26_0(IResult result) { }

	private void AcceptFriendsRequest() { }

	private void BanPlayer() { }

	private void CancelFriendRequest() { }

	private void DeclineFriendsRequest() { }

	private void DeleteFromFriendsList() { }

	protected virtual void ExecuteInteractionInternal(EFriendInteractionButton interaction) { }

	public virtual bool get_HasIcons() { }

	private static void HandleFailedResultAsWarning(IResult result) { }

	private void InviteToGroupDialogue() { }

	public virtual bool IsActive(EFriendInteractionButton button) { }

	public virtual IResult IsInteractive(EFriendInteractionButton button) { }

	private void KickPlayer() { }

	private void MutePlayer() { }

	private void ReportNickname() { }

	private void SendFriendsRequest() { }

	private void ShowBanMessageWindow(Action acceptAction) { }

	private void StartDialogue() { }

	private void TransferLeadership() { }

	private void UnbanPlayer() { }

	private void UnmutePlayer() { }

	private void WatchPlayerProfile() { }

}

