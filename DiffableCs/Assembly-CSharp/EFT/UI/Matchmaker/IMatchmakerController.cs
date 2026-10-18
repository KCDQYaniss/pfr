namespace EFT.UI.Matchmaker;

public interface IMatchmakerController
{

	public event Action OnMatchingTypeUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnPlayerContextRequest
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnRaidReadyStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public string CurrentProfileAid
	{
		 get { } //Length: 0
	}

	public bool Enabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool EnforceLocationGroupLimit
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public MatchmakerUpdatableGroup Group
	{
		 get { } //Length: 0
	}

	public string GroupId
	{
		 get { } //Length: 0
	}

	public bool GroupIsFull
	{
		 get { } //Length: 0
	}

	public BindableList GroupPlayers
	{
		 get { } //Length: 0
	}

	public BindableState GroupState
	{
		 get { } //Length: 0
	}

	public bool IsLocalGame
	{
		 get { } //Length: 0
	}

	public bool IsLookingForGroup
	{
		 get { } //Length: 0
	}

	public bool IsOwner
	{
		 get { } //Length: 0
	}

	public bool IsSearchingForGame
	{
		 get { } //Length: 0
	}

	public bool LeaderRaidReadyStatus
	{
		 get { } //Length: 0
	}

	public bool LookingForGroupBlocked
	{
		 get { } //Length: 0
	}

	public MatchingProgress MatchingProgress
	{
		 get { } //Length: 0
	}

	public int MaxGroupPlayersCount
	{
		 get { } //Length: 0
	}

	public GroupPlayer MyPlayer
	{
		 get { } //Length: 0
	}

	public Location SelectedLocation
	{
		 get { } //Length: 0
	}

	public BindableList SentInvites
	{
		 get { } //Length: 0
	}

	public int TotalReadyGroupPlayers
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnMatchingTypeUpdate(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerContextRequest(Action value) { }

	[CompilerGenerated]
	public void add_OnRaidReadyStatusChanged(Action value) { }

	public void CancelInvite(string selectedPlayerAccountId, Action action) { }

	public bool CanReportPlayer(string accountId, EReportType reportType) { }

	public void CreateGroupForSoloPlayer() { }

	public void DisbandGroup(Action action) { }

	public string get_CurrentProfileAid() { }

	public bool get_Enabled() { }

	public bool get_EnforceLocationGroupLimit() { }

	public MatchmakerUpdatableGroup get_Group() { }

	public string get_GroupId() { }

	public bool get_GroupIsFull() { }

	public BindableList get_GroupPlayers() { }

	public BindableState get_GroupState() { }

	public bool get_IsLocalGame() { }

	public bool get_IsLookingForGroup() { }

	public bool get_IsOwner() { }

	public bool get_IsSearchingForGame() { }

	public bool get_LeaderRaidReadyStatus() { }

	public bool get_LookingForGroupBlocked() { }

	public MatchingProgress get_MatchingProgress() { }

	public int get_MaxGroupPlayersCount() { }

	public GroupPlayer get_MyPlayer() { }

	public Location get_SelectedLocation() { }

	public BindableList get_SentInvites() { }

	public int get_TotalReadyGroupPlayers() { }

	public RaidGroupContextInteractions GetContextInteractions(GroupPlayer player, bool canShowProfile, bool inLobby = false, bool allowFriendPin = false) { }

	public EMatchingType GetMatchingType(string accountId) { }

	public bool IsInGroup(string accountId) { }

	public bool IsInvitedByMe(string profileAid) { }

	public Task LeaveGroup() { }

	public void OpenPlayerProfile(string accountId) { }

	[CompilerGenerated]
	public void remove_OnMatchingTypeUpdate(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerContextRequest(Action value) { }

	[CompilerGenerated]
	public void remove_OnRaidReadyStatusChanged(Action value) { }

	public void RemovePlayerFromGroup(string selectedPlayerAccountId, Action action) { }

	public void ReportNickname(string selectedPlayerId) { }

	public void RequestContextMenuForPlayer(RaidPlayer player, Vector2 position, bool allowFriendPin = false) { }

	public void SendInvite(string selectedPlayerAccountId, bool inLobby, Action action) { }

	public void set_Enabled(bool value) { }

	public void set_EnforceLocationGroupLimit(bool value) { }

	public Task StartLookingForGroup() { }

	public Task StopLookingForGroup() { }

	public void TransferLeadership(string selectedPlayerAccountId, Action action) { }

}

