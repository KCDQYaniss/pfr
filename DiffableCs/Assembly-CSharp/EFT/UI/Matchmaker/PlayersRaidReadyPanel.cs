namespace EFT.UI.Matchmaker;

public sealed class PlayersRaidReadyPanel : UIElement
{
	[SerializeField]
	private RaidReadyList _raidReadyList; //Field offset: 0x70
	[SerializeField]
	private GroupPlayersList _groupPlayersList; //Field offset: 0x78
	private MatchmakerPlayersController _matchmaker; //Field offset: 0x80

	public PlayersRaidReadyPanel() { }

	[CompilerGenerated]
	private void <Show>b__3_0() { }

	public void RequestContextMenuForPlayer(RaidPlayer player, Vector2 position) { }

	public void Show(string profileAid, BindableList friendsList, MatchmakerPlayersController matchmakerPlayersController, bool showRaidReady = true) { }

}

