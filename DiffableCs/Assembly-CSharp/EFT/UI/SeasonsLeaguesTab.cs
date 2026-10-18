namespace EFT.UI;

public sealed class SeasonsLeaguesTab : UIElement
{
	[CompilerGenerated]
	private struct <ShowWithTab>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsLeaguesTab <>4__this; //Field offset: 0x20
		public bool splitInFrames; //Field offset: 0x28
		public ELeaguesTab tab; //Field offset: 0x2C
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySwitchTab>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsLeaguesTab <>4__this; //Field offset: 0x20
		public ELeaguesTab tab; //Field offset: 0x28
		private Tab <targetTab>5__2; //Field offset: 0x30
		private CancellationToken <cancellationToken>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum ELeaguesTab
	{
		Leaderboard = 0,
		Ranks = 1,
	}

	internal class SeasonsLeaguesTabContext
	{
		public ELeaguesTab InitialTab; //Field offset: 0x10
		public Nullable SelectedRank; //Field offset: 0x14
		public Nullable LeaguesScrollValue; //Field offset: 0x1C

		public SeasonsLeaguesTabContext() { }

	}

	internal sealed class SeasonsLeaguesTabController : UIElementTabController
	{
		private readonly SeasonsHubScreenController _context; //Field offset: 0x18

		public SeasonsLeaguesTabContext LeaguesContext
		{
			 get { } //Length: 30
		}

		public SeasonsLeaguesTabController(SeasonsLeaguesTab content, SeasonsHubScreenController context) { }

		public SeasonsLeaguesTabContext get_LeaguesContext() { }

		public virtual void Show() { }

	}

	[Header("Tabs")]
	[SerializeField]
	private Tab _tabLeaderBoard; //Field offset: 0x70
	[SerializeField]
	private Tab _tabRanks; //Field offset: 0x78
	[Header("Panels")]
	[SerializeField]
	private SeasonsLeaderboardTab _leaderboardPanel; //Field offset: 0x80
	[SerializeField]
	private SeasonsRanksTab _ranksPanel; //Field offset: 0x88
	[SerializeField]
	private TMP_Text _timerPanel; //Field offset: 0x90
	[SerializeField]
	private Button _infoButton; //Field offset: 0x98
	[SerializeField]
	private GameObject _timerRoot; //Field offset: 0xA0
	private readonly Dictionary _tabDictionary; //Field offset: 0xA8
	private TabGroup _tabs; //Field offset: 0xB0
	private SeasonsHubScreenController _context; //Field offset: 0xB8
	private DateTime _leagueEndTime; //Field offset: 0xC0

	public SeasonsLeaguesTab() { }

	private void Awake() { }

	public virtual void Close() { }

	private ITabController CreateTabController(ELeaguesTab tab) { }

	private void InitializeTabDictionary() { }

	private void InitTabs(out Tab[] tabs, out Tab initialTab) { }

	private void Show(SeasonsHubScreenController context) { }

	private void ShowTutorial() { }

	[AsyncStateMachine(typeof(<ShowWithTab>d__20))]
	private Task ShowWithTab(ELeaguesTab tab, bool splitInFrames) { }

	[AsyncStateMachine(typeof(<TrySwitchTab>d__21))]
	private Task TrySwitchTab(ELeaguesTab tab) { }

	private void Update() { }

}

