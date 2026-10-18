namespace EFT.UI.Matchmaker;

public sealed class MatchMakerSelectionLocationScreen : MatchmakerEftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__28_0; //Field offset: 0x8
		public static Func <>9__28_1; //Field offset: 0x10
		public static Func <>9__33_2; //Field offset: 0x18
		public static Action <>9__33_4; //Field offset: 0x20
		public static Func <>9__34_0; //Field offset: 0x28
		public static Func <>9__34_1; //Field offset: 0x30
		public static Func <>9__36_0; //Field offset: 0x38
		public static Func <>9__36_1; //Field offset: 0x40
		public static Func <>9__41_0; //Field offset: 0x48
		public static Func <>9__41_1; //Field offset: 0x50
		public static Func <>9__42_0; //Field offset: 0x58

		private static <>c() { }

		public <>c() { }

		internal int <GetLocationByLevel>b__42_0(RaidPlayer p) { }

		internal bool <GetLocationByTime>b__41_0(Location x) { }

		internal bool <GetLocationByTime>b__41_1(Location x) { }

		internal int <IsAvailableByLevel>b__36_0(RaidPlayer p) { }

		internal int <IsAvailableByLevel>b__36_1(RaidPlayer p) { }

		internal int <set_SelectedLocation>b__28_0(RaidPlayer p) { }

		internal int <set_SelectedLocation>b__28_1(RaidPlayer p) { }

		internal bool <ShowInternal>b__33_2(<>f__AnonymousType96 x) { }

		internal void <ShowInternal>b__33_4(Location location, LocationLabel locationButton) { }

		internal bool <ShowLocationButton>b__34_0(BossLocationSpawn x) { }

		internal bool <ShowLocationButton>b__34_1(BossLocationSpawn x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public bool transitionEvent; //Field offset: 0x10
		public LocationSettings locations; //Field offset: 0x18
		public MatchMakerSelectionLocationScreen <>4__this; //Field offset: 0x20
		public Location selectedLocation; //Field offset: 0x28

		public <>c__DisplayClass33_0() { }

		internal bool <ShowInternal>b__0(LocationPath x) { }

		internal <>f__AnonymousType96 <ShowInternal>b__1(LocationPath x) { }

		internal void <ShowInternal>b__10() { }

		internal void <ShowInternal>b__3(<>f__AnonymousType96 path, LocationPath pathView) { }

		internal bool <ShowInternal>b__5(Location location) { }

		internal void <ShowInternal>b__6(Location location, LocationButton locationButton) { }

		internal void <ShowInternal>b__7(Location location, LocationButton locationButton) { }

		internal void <ShowInternal>b__8() { }

		internal void <ShowInternal>b__9() { }

	}

	internal sealed class SelectionLocationScreenController : EftMatchmakerScreenController
	{
		public readonly IEftSession Session; //Field offset: 0x78
		public readonly RaidSettings RaidSettings; //Field offset: 0x80
		[CompilerGenerated]
		private Action OnShowPocketMapScreen; //Field offset: 0x88

		public event Action OnShowPocketMapScreen
		{
			[CompilerGenerated]
			 add { } //Length: 251
			[CompilerGenerated]
			 remove { } //Length: 251
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public SelectionLocationScreenController(IEftSession session, ref RaidSettings raidSettings, MatchmakerPlayersController matchmakerPlayersController) { }

		[CompilerGenerated]
		public void add_OnShowPocketMapScreen(Action value) { }

		public virtual bool get_KeyScreen() { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		public void remove_OnShowPocketMapScreen(Action value) { }

		internal void ShowPocketMapScreen() { }

		public void UpdateSelectedDateTime() { }

	}

	private const string MAP_POINT_PATH = "MapPointConfigs/"; //Field offset: 0x0
	[SerializeField]
	private GameObject _mainCapture; //Field offset: 0xB0
	[SerializeField]
	private GameObject _marathonCapture; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _acceptButton; //Field offset: 0xC0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xC8
	[SerializeField]
	private DefaultUIButton _readyButton; //Field offset: 0xD0
	[SerializeField]
	private DefaultUIButton _pocketMapButton; //Field offset: 0xD8
	[SerializeField]
	private LocationButton _locationButtonTemplate; //Field offset: 0xE0
	[SerializeField]
	private LocationLabel _locationLabelTemplate; //Field offset: 0xE8
	[SerializeField]
	private LocationPath _locationPathTemplate; //Field offset: 0xF0
	[SerializeField]
	private Transform _locationButtonsContainer; //Field offset: 0xF8
	[SerializeField]
	private Transform _locationPathsContainer; //Field offset: 0x100
	[SerializeField]
	private MarathonButton _marathonButton; //Field offset: 0x108
	[SerializeField]
	private LocationInfoPanel _infoPanel; //Field offset: 0x110
	[SerializeField]
	private LocationConditionsPanel _conditions; //Field offset: 0x118
	private Location _selectedLocation; //Field offset: 0x120
	private Profile _profile; //Field offset: 0x128
	private ESideType _chosenSideType; //Field offset: 0x130
	private EDateTime _selectedDateTime; //Field offset: 0x134
	private IEftSession _session; //Field offset: 0x138
	private RaidSettings _raidSettings; //Field offset: 0x140
	private MatchmakerPlayersController _matchmaker; //Field offset: 0x148
	private Dictionary _locationButtonDict; //Field offset: 0x150
	private LocationBlockedForPlayersTooltip _locationBlockedForPlayersTooltip; //Field offset: 0x158
	private List _lockedForPlayersList; //Field offset: 0x160

	private Location SelectedLocation
	{
		private get { } //Length: 8
		private set { } //Length: 3098
	}

	public MatchMakerSelectionLocationScreen() { }

	[CompilerGenerated]
	private void <Awake>b__30_0() { }

	[CompilerGenerated]
	private void <Awake>b__30_1() { }

	[CompilerGenerated]
	private void <Awake>b__30_2() { }

	[CompilerGenerated]
	private void <Awake>b__30_3() { }

	[CompilerGenerated]
	private void <Awake>b__30_4() { }

	[CompilerGenerated]
	private void <Awake>b__30_5() { }

	[CompilerGenerated]
	private void <Awake>b__30_6() { }

	[CompilerGenerated]
	private void <Awake>b__30_7() { }

	private bool AvailableBySide(ESideType sideType, bool disabledForScav) { }

	private List AvailableForPlayers(Location location) { }

	private void Awake() { }

	private bool CanDisplayAcceptButton(Location selectedLocation, ESideType chosenSideType) { }

	public virtual void Close() { }

	private bool DisplayLocation(Location location) { }

	private bool EventLocation(Location location) { }

	private Location get_SelectedLocation() { }

	private Location GetLocationByLevel(Location location) { }

	private Location GetLocationByTime(Location location, EDateTime time) { }

	private bool IsAvailableByLevel(ESideType sideType, Location location) { }

	private bool NotEventLocation(Location location) { }

	private void OnLocationSelected(Location location) { }

	private void set_SelectedLocation(Location value) { }

	private bool ShouldHideLocationButton(Location location) { }

	private void Show(IEftSession session, RaidSettings raidSettings, MatchmakerPlayersController matchmaker) { }

	public virtual void Show(SelectionLocationScreenController controller) { }

	private void ShowInternal(RaidSettings raidSettings) { }

	private void ShowLocationButton(Location location, LocationButton locationButton, Location selectedLocation) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UpdateLocationButtons() { }

	private void UpdateSelectedTime(EDateTime time) { }

}

