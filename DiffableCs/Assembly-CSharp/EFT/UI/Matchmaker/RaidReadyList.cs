namespace EFT.UI.Matchmaker;

public sealed class RaidReadyList : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public RaidReadyList <>4__this; //Field offset: 0x10
		public IList friends; //Field offset: 0x18
		public BindableList invites; //Field offset: 0x20
		public string profileAid; //Field offset: 0x28

		public <>c__DisplayClass22_0() { }

		internal RaidReadyPlayerPanel <Show>b__0(RaidPlayer _) { }

		internal void <Show>b__1(RaidPlayer player, RaidReadyPlayerPanel playerPanel) { }

	}

	internal sealed class RaidPlayerComparer : IComparer
	{
		public static readonly RaidPlayerComparer Instance; //Field offset: 0x0
		private static readonly List _priorities; //Field offset: 0x8

		private static RaidPlayerComparer() { }

		public RaidPlayerComparer() { }

		public override int Compare(RaidPlayer x, RaidPlayer y) { }

		private static int GetPriority(EMemberCategory memberCategory) { }

	}

	[CompilerGenerated]
	private Action OnPlayerClick; //Field offset: 0x70
	[SerializeField]
	private TMP_InputField _inputField; //Field offset: 0x78
	[SerializeField]
	private LightScroller _lightScroller; //Field offset: 0x80
	[SerializeField]
	private RaidReadyPlayerPanel _playerPanelTemplate; //Field offset: 0x88
	private readonly List _stalePanelKeys; //Field offset: 0x90
	private readonly List _panelAliasKeys; //Field offset: 0x98
	private readonly List _sortedPlayersBuffer; //Field offset: 0xA0
	private readonly HashSet _friendAccountIds; //Field offset: 0xA8
	private readonly HashSet _pinnedAccountIds; //Field offset: 0xB0
	private readonly HashSet _displayAccountIds; //Field offset: 0xB8
	private readonly BindableList _displayPlayersList; //Field offset: 0xC0
	private readonly Dictionary _playerPanels; //Field offset: 0xC8
	private IList _friends; //Field offset: 0xD0
	private string _profileAid; //Field offset: 0xD8
	private UpdatableBindableList _playersList; //Field offset: 0xE0
	private bool _allowFriendPin; //Field offset: 0xE8
	private readonly List _pinUnsubscribes; //Field offset: 0xF0
	private string _filter; //Field offset: 0xF8

	public event Action OnPlayerClick
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public RaidReadyList() { }

	[CompilerGenerated]
	private void <Awake>b__21_0(string arg) { }

	[CompilerGenerated]
	public void add_OnPlayerClick(Action value) { }

	private void Awake() { }

	private void CleanupStalePanels() { }

	private void ClearPinSubscriptions() { }

	public virtual void Close() { }

	private int ComparePlayers(RaidPlayer x, RaidPlayer y) { }

	private static bool IsPanelAlive(RaidReadyPlayerPanel panel) { }

	private void OnPlayersListChanged() { }

	private void PlayerPanelOnPlayerClick(RaidPlayer player, Vector2 position) { }

	private void RebuildDisplayList() { }

	private void RebuildSortedPlayers() { }

	[CompilerGenerated]
	public void remove_OnPlayerClick(Action value) { }

	private void RemovePanelAliases(RaidReadyPlayerPanel panel, string accountId) { }

	private void ResubscribePins() { }

	public void Show(UpdatableBindableList playersList, BindableList invites, IList friends, string profileAid, bool allowFriendPin = false) { }

	private void ShowPlayer(RaidPlayer player, RaidReadyPlayerPanel playerPanel, IList friends, BindableList invites, string profileAid) { }

}

