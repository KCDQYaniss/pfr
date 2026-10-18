namespace UI.Matchmaker.Group;

public sealed class FriendListInvitePlayerPanel : UIElement
{
	[SerializeField]
	private RaidReadyList _friendsList; //Field offset: 0x70
	[SerializeField]
	private GroupPlayersList _groupPlayersList; //Field offset: 0x78
	private IMatchmakerController _matchmaker; //Field offset: 0x80
	private UpdatableBindableList _friendPlayers; //Field offset: 0x88
	private BindableList _friendsBindableList; //Field offset: 0x90
	private readonly HashSet _groupMemberAccountIds; //Field offset: 0x98
	private readonly Dictionary _cachedRaidPlayers; //Field offset: 0xA0
	private readonly GroupPlayer _groupPlayerBuffer; //Field offset: 0xA8
	private readonly List _rebuiltFriendPlayers; //Field offset: 0xB0

	public FriendListInvitePlayerPanel() { }

	[CompilerGenerated]
	private void <Show>b__9_0() { }

	private void RebuildFriendList() { }

	private void RequestFriendContextMenu(RaidPlayer player, Vector2 position) { }

	private void RequestGroupContextMenu(RaidPlayer player, Vector2 position) { }

	public void Show(string profileAid, BindableList friendsList, IMatchmakerController matchmakerPlayersController) { }

}

