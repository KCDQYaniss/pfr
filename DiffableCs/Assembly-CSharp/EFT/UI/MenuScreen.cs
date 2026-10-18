namespace EFT.UI;

public sealed class MenuScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public MenuScreen <>4__this; //Field offset: 0x10
		public Profile profile; //Field offset: 0x18
		public SeasonalRewardController seasonalRewardController; //Field offset: 0x20
		public Action <>9__3; //Field offset: 0x28

		public <>c__DisplayClass24_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2(MongoID _) { }

		internal void <Show>b__3(BattlePassReward _) { }

	}

	[CompilerGenerated]
	private struct <RunMemoryCleanup>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal abstract class MainMenuBaseScreenController : EftScreenController
	{
		public readonly MatchmakerPlayersController Matchmaker; //Field offset: 0x58
		public readonly GameModeDescriptor ModeDescriptor; //Field offset: 0x60
		public readonly Profile Profile; //Field offset: 0x68
		public readonly ExpansionsPlayerInfo ExpansionsPlayerInfo; //Field offset: 0x70
		public readonly SeasonalRewardControllerClient SeasonalRewardController; //Field offset: 0x78
		[CompilerGenerated]
		private Action OnMenuItemSelected; //Field offset: 0x80

		public event Action OnMenuItemSelected
		{
			[CompilerGenerated]
			 add { } //Length: 278
			[CompilerGenerated]
			 remove { } //Length: 278
		}

		protected virtual EStateSwitcher CameraBlur
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		protected virtual bool MainEnvironment
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EShadingStateSwitcher ShadingType
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher ShowEnvironment
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironmentCamera
		{
			 get { } //Length: 6
		}

		protected MainMenuBaseScreenController(Profile profile = null, MatchmakerPlayersController matchmaker = null, ExpansionsPlayerInfo expansionsPlayerInfo = null, GameModeDescriptor modeDescriptor = null, SeasonalRewardControllerClient seasonalRewardController = null) { }

		[CompilerGenerated]
		public void add_OnMenuItemSelected(Action value) { }

		protected virtual EStateSwitcher get_CameraBlur() { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		public virtual bool get_KeyScreen() { }

		protected virtual bool get_MainEnvironment() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EShadingStateSwitcher get_ShadingType() { }

		protected virtual EStateSwitcher get_ShowEnvironment() { }

		protected virtual EStateSwitcher get_ShowEnvironmentCamera() { }

		[CompilerGenerated]
		public void remove_OnMenuItemSelected(Action value) { }

		public void SelectMenuItem(EMenuType itemType) { }

		protected virtual void ShowAction(MenuScreen screen) { }

	}

	internal sealed class MainMenuReconnectScreenController : MainMenuBaseScreenController
	{

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public MainMenuReconnectScreenController() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		protected virtual void ShowAction(MenuScreen screen) { }

	}

	internal sealed class MainMenuScreenController : MainMenuBaseScreenController
	{

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public MainMenuScreenController(Profile profile, MatchmakerPlayersController matchmaker, ExpansionsPlayerInfo expansionsPlayerInfo, GameModeDescriptor modeDescriptor, SeasonalRewardControllerClient seasonalRewardController) { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		protected virtual void ShowAction(MenuScreen screen) { }

	}

	internal sealed class RaidMainMenuScreenController : MainMenuBaseScreenController
	{
		[CompilerGenerated]
		private Action OnLeave; //Field offset: 0x88

		public event Action OnLeave
		{
			[CompilerGenerated]
			 add { } //Length: 251
			[CompilerGenerated]
			 remove { } //Length: 251
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher UnrestrictedFrameRate
		{
			 get { } //Length: 6
		}

		public RaidMainMenuScreenController() { }

		[CompilerGenerated]
		public void add_OnLeave(Action value) { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		protected virtual EStateSwitcher get_UnrestrictedFrameRate() { }

		public void Leave() { }

		[CompilerGenerated]
		public void remove_OnLeave(Action value) { }

		protected virtual void ShowAction(MenuScreen screen) { }

	}

	[SerializeField]
	private DefaultUIButton _playButton; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _playerButton; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _tradeButton; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _exitButton; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _disconnectButton; //Field offset: 0xC0
	[SerializeField]
	private DefaultUIButton _hideoutButton; //Field offset: 0xC8
	[SerializeField]
	private Button _logoutButton; //Field offset: 0xD0
	[SerializeField]
	private ChangeGameModeButton _changeGameModeButton; //Field offset: 0xD8
	[SerializeField]
	private ExpansionsHeroButton _expansionsHeroButton; //Field offset: 0xE0
	[SerializeField]
	private SeasonWidget _seasonWidget; //Field offset: 0xE8
	[SerializeField]
	private DefaultUIButton _hideScreenButton; //Field offset: 0xF0
	[SerializeField]
	private GameObject _warningGameObject; //Field offset: 0xF8
	private bool _reconnectAvailable; //Field offset: 0x100
	private EnvironmentUI _environment; //Field offset: 0x108
	private bool _inGameScreenStatus; //Field offset: 0x110
	private MatchmakerPlayersController _matchmaker; //Field offset: 0x118
	private GameModeDescriptor _modeDescriptor; //Field offset: 0x120

	public MenuScreen() { }

	[CompilerGenerated]
	private void <Awake>b__22_0() { }

	[CompilerGenerated]
	private void <Awake>b__22_1() { }

	[CompilerGenerated]
	private void <Awake>b__22_2() { }

	[CompilerGenerated]
	private void <Awake>b__22_3() { }

	[CompilerGenerated]
	private void <Awake>b__22_4() { }

	[CompilerGenerated]
	private void <Awake>b__22_5() { }

	[CompilerGenerated]
	private void <Awake>b__22_6() { }

	[CompilerGenerated]
	private void <Awake>b__22_7() { }

	private void Awake() { }

	private void ChangeScreenInGameStatus(bool minimized) { }

	private void ChangeToReconnectionAvailable(bool reconnectAvailable) { }

	private void Click(EMenuType menuType) { }

	private void HandleChangeGameModeButtonClick(EHeroButtonAvailableState intent) { }

	private void HandleExpansionsButtonClick(EHeroButtonAvailableState intent) { }

	private void HandleSeasonWidgetClick() { }

	public void Init(EnvironmentUI environment) { }

	private void OnMatchingTypeUpdate(EMatchingType matchingType) { }

	private void RefreshSeasonWidget(Profile profile, SeasonalRewardController seasonalRewardController) { }

	[AsyncStateMachine(typeof(<RunMemoryCleanup>d__27))]
	private Task RunMemoryCleanup() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	private void Show(MatchmakerPlayersController matchmaker, ExpansionsPlayerInfo expansionsInfo, GameModeDescriptor modeDescriptor, Profile profile, SeasonalRewardController seasonalRewardController) { }

	public virtual void Show(MainMenuBaseScreenController controller) { }

	private void ShowInRaid() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

