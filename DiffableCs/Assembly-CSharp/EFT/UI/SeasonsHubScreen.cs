namespace EFT.UI;

public sealed class SeasonsHubScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Tab tab; //Field offset: 0x10
		public SeasonsHubScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal void <InitTabs>b__0() { }

	}

	[CompilerGenerated]
	private struct <ShowWithTab>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsHubScreen <>4__this; //Field offset: 0x20
		public bool splitInFrames; //Field offset: 0x28
		public EHubTab tab; //Field offset: 0x2C
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySwitchTab>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsHubScreen <>4__this; //Field offset: 0x20
		public EHubTab tab; //Field offset: 0x28
		private Tab <targetTab>5__2; //Field offset: 0x30
		private CancellationToken <cancellationToken>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum EHubTab
	{
		BattlePass = 0,
		AboutSeason = 1,
		Leagues = 2,
	}

	internal sealed class SeasonsHubScreenController : EftScreenController
	{
		[CompilerGenerated]
		private readonly IEftSession <Session>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private readonly SeasonalRewardControllerClient <SeasonalRewardController>k__BackingField; //Field offset: 0x60
		private ActiveSeasonResponse _seasonalRewards; //Field offset: 0x68
		public readonly BattlePassController BattlePassController; //Field offset: 0x70
		public EHubTab InitialTab; //Field offset: 0x78
		public SeasonsLeaguesTabContext LeaguesContext; //Field offset: 0x80

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public SeasonalRewardControllerClient SeasonalRewardController
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public IEftSession Session
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public SeasonsHubScreenController(IEftSession session, SeasonalRewardControllerClient seasonalRewardController = null) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		public SeasonalRewardControllerClient get_SeasonalRewardController() { }

		[CompilerGenerated]
		public IEftSession get_Session() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		public SeasonsLeaderboardInfo GetLeaderboardData() { }

		public SeasonsRanksPlayerState GetPlayerState() { }

		public SeasonalReward GetSeasonalReward(SeasonalRewardTemplate reward) { }

		public SeasonData GetSeasonalRewards() { }

	}

	private const string LEAGUES_DISABLED_KEY = "Seasonal/LeaguesDisabled"; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xA0
	[Header("Tabs")]
	[SerializeField]
	private Tab _tabBattlePass; //Field offset: 0xA8
	[SerializeField]
	private Tab _tabAboutSeason; //Field offset: 0xB0
	[SerializeField]
	private Tab _tabLeagues; //Field offset: 0xB8
	[Header("Panels")]
	[SerializeField]
	private SeasonsAboutTab _aboutSeasonTab; //Field offset: 0xC0
	[SerializeField]
	private SeasonsLeaguesTab _leaguesTab; //Field offset: 0xC8
	[SerializeField]
	private BattlePassPanel _battlePassTab; //Field offset: 0xD0
	private readonly Dictionary _tabDictionary; //Field offset: 0xD8
	private TabGroup _tabs; //Field offset: 0xE0

	public SeasonsHubScreen() { }

	public virtual void Close() { }

	private void CloseScreen() { }

	private ITabController CreateTabController(EHubTab tab) { }

	private void InitializeTabDictionary() { }

	private void InitTabs(out Tab[] tabs, out Tab initialTab) { }

	public virtual void Show(SeasonsHubScreenController controller) { }

	[AsyncStateMachine(typeof(<ShowWithTab>d__18))]
	private Task ShowWithTab(EHubTab tab, bool splitInFrames) { }

	private void TabOnSelectionChangedHandler(Tab tab, bool selected) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private bool TryGetInitialTab(out Tab tab) { }

	[AsyncStateMachine(typeof(<TrySwitchTab>d__19))]
	private Task TrySwitchTab(EHubTab tab) { }

}

