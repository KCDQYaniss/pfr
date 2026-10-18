namespace EFT.UI.Matchmaker;

public sealed class PartyInfoPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public PartyPlayerItem playerView; //Field offset: 0x10
		public PartyInfoPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal void <Show>b__3() { }

	}

	private const string NOT_AVAILABLE_IN_RAID = "Not available in raid"; //Field offset: 0x0
	[SerializeField]
	private PartyPlayerItem _playerItemTemplate; //Field offset: 0x70
	[SerializeField]
	private GameObject _separator; //Field offset: 0x78
	[SerializeField]
	private Transform _playersContainer; //Field offset: 0x80
	[SerializeField]
	private UiElementBlocker _uiElementBlocker; //Field offset: 0x88
	private Profile _profile; //Field offset: 0x90
	private MatchmakerPlayersController _matchmaker; //Field offset: 0x98
	private PlayerEquipmentWindowContext _selectedContext; //Field offset: 0xA0
	private ViewList _views; //Field offset: 0xA8
	[CompilerGenerated]
	private Action OnPlayerClick; //Field offset: 0xB0

	public event Action OnPlayerClick
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public PartyInfoPanel() { }

	[CompilerGenerated]
	private void <Show>b__12_0(RaidPlayer raidPlayer, PartyPlayerItem playerView) { }

	[CompilerGenerated]
	private void <Show>g__HandleOnPlayerEquipmentClick|12_2(RaidPlayer raidPlayer) { }

	[CompilerGenerated]
	private void <Show>g__HandleOnPlayerNameClick|12_1(RaidPlayer raidPlayer) { }

	[CompilerGenerated]
	public void add_OnPlayerClick(Action value) { }

	public virtual void Close() { }

	private void HandleOnPlayerEquipWindowClose() { }

	[CompilerGenerated]
	public void remove_OnPlayerClick(Action value) { }

	public void SetEquipmentViewClicksAvailable(bool available) { }

	public void Show(BindableList groupPlayers, Profile profile, bool isBlocked) { }

}

