namespace EFT.UI;

public sealed class PlayersInviteWindow : Window
{
	[SerializeField]
	private FriendListInvitePlayerPanel _friendListInvitePlayerPanel; //Field offset: 0xB8
	[SerializeField]
	private SimpleContextMenu _contextMenu; //Field offset: 0xC0
	private IMatchmakerController _matchmaker; //Field offset: 0xC8

	protected virtual bool ShowOnTop
	{
		 get { } //Length: 3
	}

	public PlayersInviteWindow() { }

	[CompilerGenerated]
	private void <Show>b__5_0() { }

	protected virtual bool get_ShowOnTop() { }

	private void MatchmakerPlayerContextRequestHandler(RaidPlayer raidPlayer, Vector2 position, bool allowFriendPin) { }

	public WindowContext Show(string profileAid, BindableList friendsList, IMatchmakerController matchmakerPlayersController, float offsetX = 0, float offsetY = 0) { }

}

