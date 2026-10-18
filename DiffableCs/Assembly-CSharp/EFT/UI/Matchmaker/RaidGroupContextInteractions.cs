namespace EFT.UI.Matchmaker;

public sealed class RaidGroupContextInteractions : ContextInteractions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__17_1; //Field offset: 0x8
		public static Action <>9__18_1; //Field offset: 0x10
		public static Action <>9__25_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <RemovePlayer>b__18_1() { }

		internal void <ReportNickname>b__25_1() { }

		internal void <TransferLeadership>b__17_1() { }

	}

	private readonly string _accountId; //Field offset: 0x38
	private readonly GroupPlayer _selectedPlayer; //Field offset: 0x40
	private readonly Action _onButtonSelected; //Field offset: 0x48
	private readonly IMatchmakerController _matchmakerPlayersController; //Field offset: 0x50
	private readonly bool _inLobby; //Field offset: 0x58
	private readonly bool _canShowProfile; //Field offset: 0x59
	private readonly bool _allowFriendPin; //Field offset: 0x5A

	public virtual bool HasIcons
	{
		 get { } //Length: 3
	}

	private bool IsLookingForGroup
	{
		private get { } //Length: 78
	}

	private bool LookingForGroupBlocked
	{
		private get { } //Length: 98
	}

	public RaidGroupContextInteractions(string accountId, GroupPlayer selectedPlayer, IMatchmakerController matchmakerPlayersController, bool inLobby, bool canShowProfile, Action onButtonSelected, bool allowFriendPin = false) { }

	[CompilerGenerated]
	private void <CancelInvite>b__21_0() { }

	[CompilerGenerated]
	private void <DisbandGroup>b__19_0() { }

	[CompilerGenerated]
	private void <DisbandGroup>b__19_1() { }

	[CompilerGenerated]
	private void <InviteInGroup>b__20_0() { }

	[CompilerGenerated]
	private void <LeaveGroup>b__16_0() { }

	[CompilerGenerated]
	private void <RemovePlayer>b__18_0() { }

	[CompilerGenerated]
	private void <ReportNickname>b__25_0() { }

	[CompilerGenerated]
	private void <TransferLeadership>b__17_0() { }

	private void CancelInvite() { }

	private void CancelLookingForGroup() { }

	private bool CanReportPlayer(string aId, EReportType reportType) { }

	private bool CanToggleFriendPin(bool pinned) { }

	private void CreateGroup() { }

	private void DisbandGroup() { }

	protected virtual void ExecuteInteractionInternal(ERaidPlayerButton interaction) { }

	private UpdatableChatMember FindEftFriend() { }

	public virtual bool get_HasIcons() { }

	private bool get_IsLookingForGroup() { }

	private bool get_LookingForGroupBlocked() { }

	private void InviteInGroup() { }

	public virtual bool IsActive(ERaidPlayerButton button) { }

	public virtual IResult IsInteractive(ERaidPlayerButton button) { }

	private bool IsInvited(string profileAid) { }

	private void LeaveGroup() { }

	private void RemovePlayer() { }

	private void ReportNickname() { }

	private void SetFriendPinned(bool pinned) { }

	private void StartLookingForGroup() { }

	private void TransferLeadership() { }

	private void WatchProfile() { }

}

