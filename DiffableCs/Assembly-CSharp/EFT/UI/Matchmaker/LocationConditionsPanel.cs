namespace EFT.UI.Matchmaker;

public sealed class LocationConditionsPanel : UIElement
{
	public const string DATE_TIME_FORMAT = "HH:mm:ss"; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _currentPhaseTime; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _nextPhaseTime; //Field offset: 0x78
	[SerializeField]
	private Image _weatherIcon; //Field offset: 0x80
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x88
	[SerializeField]
	private Toggle _amTimeToggle; //Field offset: 0x90
	[SerializeField]
	private Toggle _pmTimeToggle; //Field offset: 0x98
	[SerializeField]
	private ZombieEventLocationInfectionInfo _infectionInfo; //Field offset: 0xA0
	[SerializeField]
	private GameObject _expRoot; //Field offset: 0xA8
	[SerializeField]
	private HoverTooltipArea _expHover; //Field offset: 0xB0
	[CompilerGenerated]
	private Action OnTimeChanged; //Field offset: 0xB8
	private bool _needTimerUpdate; //Field offset: 0xC0
	private IMatchmakerSession _session; //Field offset: 0xC8
	private EDateTime _selectedDateTime; //Field offset: 0xD0
	private bool _takeFromCurrent; //Field offset: 0xD4

	public event Action OnTimeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	private static DateTime FactoryDayTime
	{
		private get { } //Length: 117
	}

	private static DateTime FactoryNightTime
	{
		private get { } //Length: 117
	}

	private DateTime GetCurrentLocationTime
	{
		private get { } //Length: 78
	}

	private static DateTime IcebreakerFixedTime
	{
		private get { } //Length: 117
	}

	public EDateTime SelectedDateTime
	{
		 get { } //Length: 7
		 set { } //Length: 34
	}

	public LocationConditionsPanel() { }

	[CompilerGenerated]
	private void <Start>b__28_0(bool arg) { }

	[CompilerGenerated]
	private void <Start>b__28_1(bool arg) { }

	[CompilerGenerated]
	public void add_OnTimeChanged(Action value) { }

	private static DateTime get_FactoryDayTime() { }

	private static DateTime get_FactoryNightTime() { }

	private DateTime get_GetCurrentLocationTime() { }

	private static DateTime get_IcebreakerFixedTime() { }

	public EDateTime get_SelectedDateTime() { }

	private void InitZombieEvent(Location location) { }

	[CompilerGenerated]
	public void remove_OnTimeChanged(Action value) { }

	public void Set(IMatchmakerSession session, RaidSettings raidSettings, bool takeFromCurrent) { }

	public void Set(MatchmakerPlayersController matchmakerPlayersController, IMatchmakerSession session, RaidSettings raidSettings, bool takeFromCurrent) { }

	public void set_SelectedDateTime(EDateTime value) { }

	private void SetGroupBonusPanelActive(bool active) { }

	private void SetupGroupBonusPanel(bool hasEditionBonus, string groupPlayerName, string gameVersion, float value, int referralPercent) { }

	private void Start() { }

	private void Update() { }

	private void UpdateConditions() { }

	public void UpdateTeamGroupBonusPanel(MatchmakerPlayersController mm) { }

}

