namespace EFT.UI;

public abstract class BaseGroupPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public BindableState group; //Field offset: 0x10
		public BaseGroupPanel <>4__this; //Field offset: 0x18
		public BindableList groupPlayers; //Field offset: 0x20

		public <>c__DisplayClass25_0() { }

		internal void <Show>b__0(RaidPlayer player, GroupMemberView playerPanel) { }

		internal void <Show>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_1
	{
		public GroupMemberView playerPanel; //Field offset: 0x10
		public <>c__DisplayClass25_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass25_1() { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public RaidPlayer raidPlayer; //Field offset: 0x10

		public <>c__DisplayClass30_0() { }

		internal bool <AddVisibleGroupPlayers>b__0(RaidPlayer p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public EmptyMemberView emptyView; //Field offset: 0x10
		public BaseGroupPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass36_0() { }

		internal void <SetEmptySlots>b__0() { }

	}

	protected const string IN_RAID_LABEL = "InRaidButton"; //Field offset: 0x0
	[CompilerGenerated]
	private Action RaidReadyButtonPressed; //Field offset: 0x70
	[SerializeField]
	protected SimpleContextMenu _contextMenu; //Field offset: 0x78
	[SerializeField]
	private Transform _groupListContainer; //Field offset: 0x80
	[SerializeField]
	private Transform _emptyMemberContainer; //Field offset: 0x88
	[SerializeField]
	private GroupMemberView _groupMemberTemplate; //Field offset: 0x90
	[SerializeField]
	private EmptyMemberView _emptyMemberTemplate; //Field offset: 0x98
	[SerializeField]
	protected Button _inRaidButton; //Field offset: 0xA0
	[SerializeField]
	private TextMeshProUGUI _inRaidButtonLabel; //Field offset: 0xA8
	[SerializeField]
	private GameObject _groupPanelBlocker; //Field offset: 0xB0
	[SerializeField]
	private HoverTooltipArea _blockerTooltip; //Field offset: 0xB8
	private readonly List _emptyViews; //Field offset: 0xC0
	protected IMatchmakerController _matchmaker; //Field offset: 0xC8
	private BindableList _visibleGroupPlayers; //Field offset: 0xD0
	private bool _leaderReady; //Field offset: 0xD8
	protected bool _onForbiddenScreenForGoInRaid; //Field offset: 0xD9
	private BindableViewList _views; //Field offset: 0xE0
	protected SocialNetwork _socialNetwork; //Field offset: 0xE8
	private bool _isGoInRaidButtonBlocked; //Field offset: 0xF0
	protected string _buttonLabel; //Field offset: 0xF8

	public event Action RaidReadyButtonPressed
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	protected override bool CanShowInRaidButton
	{
		 get { } //Length: 472
	}

	protected BaseGroupPanel() { }

	[CompilerGenerated]
	public void add_RaidReadyButtonPressed(Action value) { }

	private void AddVisibleGroupPlayers(RaidPlayer raidPlayer) { }

	protected override void Awake() { }

	private void ClearVisibleGroupPlayers() { }

	protected override bool get_CanShowInRaidButton() { }

	private bool IsLocationAvailable(IEnumerable unlockedLocations) { }

	private void MatchingTypeUpdateHandler(EMatchingType _) { }

	protected abstract void OnEmptyViewClickHandler(PointerEventData eventData) { }

	private void OnRaidReadyButtonPressed() { }

	private void ReadyStatusChangedHandler(RaidPlayer player, bool _) { }

	[CompilerGenerated]
	public void remove_RaidReadyButtonPressed(Action value) { }

	private void RemoveVisibleGroupPlayers(RaidPlayer raidPlayer) { }

	private void SetEmptySlots() { }

	public override void SetGroupsAvailability(bool available, string tooltip) { }

	public void SetGroupViewsActive(bool active) { }

	public override void Show(IMatchmakerController matchmakerPlayersController, SocialNetwork socialNetwork) { }

	public abstract void ShowContextMenu(GroupPlayer player, PointerEventData eventData) { }

	private void UpdateLeader(RaidPlayer leader) { }

	protected override void UpdateRaidReadyButton() { }

}

