namespace EFT.UI;

public sealed class SeasonsAboutTab : UIInputNode
{
	[CompilerGenerated]
	private struct <ShowWithTab>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsAboutTab <>4__this; //Field offset: 0x20
		public bool splitInFrames; //Field offset: 0x28
		public EAboutTab tab; //Field offset: 0x2C
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySwitchTab>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsAboutTab <>4__this; //Field offset: 0x20
		public EAboutTab tab; //Field offset: 0x28
		private Tab <targetTab>5__2; //Field offset: 0x30
		private CancellationToken <cancellationToken>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum EAboutTab
	{
		SeasonalRewards = 0,
		AboutSeason = 1,
	}

	internal sealed class SeasonsAboutTabController : UIElementTabController
	{
		private readonly SeasonsHubScreenController _context; //Field offset: 0x18

		public SeasonsAboutTabController(SeasonsAboutTab content, SeasonsHubScreenController context) { }

		public virtual void Show() { }

	}

	private const string COUNTDOWN_KEY = "Seasons/AboutTab/Countdown{0}"; //Field offset: 0x0
	[Header("Tabs")]
	[SerializeField]
	private Tab _tabSeasonalRewards; //Field offset: 0x80
	[SerializeField]
	private Tab _tabAboutSeason; //Field offset: 0x88
	[Header("Panels")]
	[SerializeField]
	private SeasonsSeasonRewardsTab _seasonalRewardsTab; //Field offset: 0x90
	[SerializeField]
	private SeasonsSeasonInfoTab _aboutSeasonTab; //Field offset: 0x98
	[Header("Season header")]
	[SerializeField]
	private TextMeshProUGUI _seasonCountdownLabel; //Field offset: 0xA0
	[SerializeField]
	private StreamingVideoPlayer _logoVideoPlayer; //Field offset: 0xA8
	[SerializeField]
	private StreamingVideoPlayer _smokeVideoPlayer; //Field offset: 0xB0
	private readonly Dictionary _tabDictionary; //Field offset: 0xB8
	private TabGroup _tabs; //Field offset: 0xC0
	private SeasonsHubScreenController _context; //Field offset: 0xC8
	private DateTime _seasonEndTimeUtc; //Field offset: 0xD0
	private DateTime _lastCountdownUpdateUtc; //Field offset: 0xD8
	private bool _countdownActive; //Field offset: 0xE0

	public SeasonsAboutTab() { }

	public virtual void Close() { }

	private ITabController CreateTabController(EAboutTab tab) { }

	private void InitializeTabDictionary() { }

	private void InitTabs(out Tab[] tabs, out Tab initialTab) { }

	private void SetLogoVideoPlaying(bool playing) { }

	private void SetupSeasonCountdown() { }

	private void Show(SeasonsHubScreenController context) { }

	[AsyncStateMachine(typeof(<ShowWithTab>d__24))]
	private Task ShowWithTab(EAboutTab tab, bool splitInFrames) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	[AsyncStateMachine(typeof(<TrySwitchTab>d__25))]
	private Task TrySwitchTab(EAboutTab tab) { }

	private void Update() { }

	private void UpdateSeasonCountdown(DateTime now) { }

}

