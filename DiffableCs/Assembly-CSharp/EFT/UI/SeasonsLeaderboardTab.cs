namespace EFT.UI;

public class SeasonsLeaderboardTab : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public string aid; //Field offset: 0x10
		public SeasonsLeaderboardTab <>4__this; //Field offset: 0x18
		public LeaderboardPlayerInfo ownerItem; //Field offset: 0x20
		public SeasonsLeaderboardInfo leaderboardInfo; //Field offset: 0x28

		public <>c__DisplayClass31_0() { }

		internal bool <ShowLeaderboard>b__0(LeaderboardPlayerInfo x) { }

		internal void <ShowLeaderboard>g__ShowAction|2(LeaderboardPlayerInfo playerData, SeasonsLeaderboardView view) { }

		internal SeasonsLeaderboardView <ShowLeaderboard>g__ViewFactory|1(LeaderboardPlayerInfo playerData) { }

	}

	[CompilerGenerated]
	private struct <ShowAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsHubScreenController context; //Field offset: 0x20
		public SeasonsLeaderboardTab <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class SeasonsLeaderboardTabController : UIElementTabController
	{
		private readonly SeasonsHubScreenController _context; //Field offset: 0x18

		public SeasonsLeaderboardTabController(SeasonsLeaderboardTab content, SeasonsHubScreenController context) { }

		public virtual void Show() { }

	}

	public const string ONLY_IN_PVP_SEASON = "Seasons/Ranks/Leaderboard/OnlyPvpSeasons"; //Field offset: 0x0
	public const string NOT_LOADED = "Seasons/Ranks/Leaderboard/GoToRaid"; //Field offset: 0x0
	private const int REQUEST_DELAY = 10; //Field offset: 0x0
	[SerializeField]
	private LightScroller _lightScroll; //Field offset: 0x70
	[SerializeField]
	private Scrollbar _scroll; //Field offset: 0x78
	[SerializeField]
	private SeasonsLeaderboardView _viewTemplate; //Field offset: 0x80
	[SerializeField]
	private Image _rankImage; //Field offset: 0x88
	[SerializeField]
	private TMP_Text _currRankLabel; //Field offset: 0x90
	[SerializeField]
	private TMP_Text _totalExpLabel; //Field offset: 0x98
	[SerializeField]
	private TMP_Text _placeLabel; //Field offset: 0xA0
	[SerializeField]
	private TMP_Text _ruleUpLabel; //Field offset: 0xA8
	[SerializeField]
	private TMP_Text _ruleStayLabel; //Field offset: 0xB0
	[SerializeField]
	private TMP_Text _ruleDownLabel; //Field offset: 0xB8
	[SerializeField]
	private GameObject _rulesRoot; //Field offset: 0xC0
	[SerializeField]
	private GameObject _ruleUpRoot; //Field offset: 0xC8
	[SerializeField]
	private GameObject _ruleStayRoot; //Field offset: 0xD0
	[SerializeField]
	private GameObject _ruleDownRoot; //Field offset: 0xD8
	[SerializeField]
	private GameObject _loadingState; //Field offset: 0xE0
	[SerializeField]
	private GameObject _activeState; //Field offset: 0xE8
	[SerializeField]
	private GameObject _disabledState; //Field offset: 0xF0
	[FormerlySerializedAs("_overlayBannerRoot")]
	[SerializeField]
	private GameObject _pendingPanel; //Field offset: 0xF8
	[SerializeField]
	private TMP_Text _disabledLabel; //Field offset: 0x100
	private int _itemsCount; //Field offset: 0x108
	private Task _inspectScreenLoading; //Field offset: 0x110
	private CancellationTokenSource _inspectProfileCancellation; //Field offset: 0x118
	private SeasonsLeaguesTabContext _leaguesContext; //Field offset: 0x120

	public SeasonsLeaderboardTab() { }

	public virtual void Close() { }

	private static bool HasLiveCohort(SeasonsLeaderboardInfo leaderboardInfo, string aid) { }

	private void InspectAction(string aid) { }

	private void ScrollHandler(float value) { }

	public void Show(SeasonsHubScreenController context) { }

	[AsyncStateMachine(typeof(<ShowAsync>d__28))]
	private Task ShowAsync(SeasonsHubScreenController context) { }

	private void ShowDisabledState(string reason) { }

	private void ShowElement(int index) { }

	private void ShowLeaderboard(SeasonsLeaderboardInfo leaderboardInfo, SeasonsRanksPlayerState rankState, string aid) { }

	private void ShowPendingState(SeasonsRanksPlayerState rankState) { }

	private void ShowRank(int rank) { }

	private void ShowSync(SeasonsHubScreenController context) { }

}

