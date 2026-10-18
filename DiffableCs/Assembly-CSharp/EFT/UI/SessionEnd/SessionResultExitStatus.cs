namespace EFT.UI.SessionEnd;

public sealed class SessionResultExitStatus : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__27_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Awake>b__27_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public TarkovApplication tarkovApplication; //Field offset: 0x10
		public SessionResultExitStatus <>4__this; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <Show>b__0() { }

	}

	internal sealed class ExitStatusScreenController : EftScreenController
	{
		[CompilerGenerated]
		private Action OnShowNextScreen; //Field offset: 0x58
		[CompilerGenerated]
		private Action OnGoToMainMenu; //Field offset: 0x60
		public readonly Profile ActiveProfile; //Field offset: 0x68
		public readonly ESideType PlayerSide; //Field offset: 0x70
		public readonly ExitStatus ExitStatus; //Field offset: 0x74
		public readonly TimeSpan RaidTime; //Field offset: 0x78
		public readonly bool IsOnline; //Field offset: 0x80
		public readonly IEftSession Session; //Field offset: 0x88
		public readonly PlayerVisualRepresentation LastPlayerState; //Field offset: 0x90
		[CompilerGenerated]
		private Profile <LoadedProfile>k__BackingField; //Field offset: 0x98

		public event Action OnGoToMainMenu
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public event Action OnShowNextScreen
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		public private Profile LoadedProfile
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
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

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public ExitStatusScreenController(Profile activeProfile, PlayerVisualRepresentation lastPlayerState, ESideType side, ExitStatus exitStatus, TimeSpan raidTime, IEftSession session, bool isOnline) { }

		[CompilerGenerated]
		public void add_OnGoToMainMenu(Action value) { }

		[CompilerGenerated]
		public void add_OnShowNextScreen(Action value) { }

		public virtual bool get_KeyScreen() { }

		[CompilerGenerated]
		public Profile get_LoadedProfile() { }

		protected virtual bool get_MainEnvironment() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		public void GoToMainMenu() { }

		public void OnGotProfile(Profile profile) { }

		[CompilerGenerated]
		public void remove_OnGoToMainMenu(Action value) { }

		[CompilerGenerated]
		public void remove_OnShowNextScreen(Action value) { }

		[CompilerGenerated]
		private void set_LoadedProfile(Profile value) { }

		public void ShowNextScreen() { }

	}

	private const string WATCH_PROFILE = "WatchProfile"; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _mainMenuButton; //Field offset: 0xA8
	[SerializeField]
	private PlayerLevelPanel _levelPanel; //Field offset: 0xB0
	[SerializeField]
	private PlayerNamePanel _namePanel; //Field offset: 0xB8
	[SerializeField]
	private PlayerNamePanel _killerNamePanel; //Field offset: 0xC0
	[SerializeField]
	private CustomTextMeshProUGUI _bodyPartLabel; //Field offset: 0xC8
	[SerializeField]
	private PlayerModelView _playerModelView; //Field offset: 0xD0
	[SerializeField]
	private GameObject _survivedPanel; //Field offset: 0xD8
	[SerializeField]
	private GameObject _leftPanel; //Field offset: 0xE0
	[SerializeField]
	private GameObject _missingPanel; //Field offset: 0xE8
	[SerializeField]
	private GameObject _killedPanel; //Field offset: 0xF0
	[SerializeField]
	private GameObject _runnerPanel; //Field offset: 0xF8
	[SerializeField]
	private GameObject _warningPanel; //Field offset: 0x100
	[SerializeField]
	private CustomTextMeshProUGUI _warningCaption; //Field offset: 0x108
	[SerializeField]
	private CustomTextMeshProUGUI _warningDescription; //Field offset: 0x110
	[SerializeField]
	private CustomTextMeshProUGUI _raidTime; //Field offset: 0x118
	[SerializeField]
	private CustomTextMeshProUGUI _experience; //Field offset: 0x120
	[SerializeField]
	private GameObject _loaderExperience; //Field offset: 0x128
	[SerializeField]
	private GameObject _loaderAggressor; //Field offset: 0x130
	[SerializeField]
	private ReportPanel _reportPanel; //Field offset: 0x138
	[SerializeField]
	private ComplementaryButton _showProfileButton; //Field offset: 0x140
	[SerializeField]
	private PlayerExperienceIcon _expIcon; //Field offset: 0x148
	private IEftSession _session; //Field offset: 0x150
	private Profile _activeProfile; //Field offset: 0x158
	private ExitStatus _exitStatus; //Field offset: 0x160

	public SessionResultExitStatus() { }

	[CompilerGenerated]
	private void <ShowAggressor>b__33_0(bool arg) { }

	private void ApplyGameOverSaveStatus(RpcGameOverSaveStatusMessage message) { }

	private void ApplyLoadedProfile(Profile profile) { }

	private void Awake() { }

	public void DisableAggressorState() { }

	private void OnMainMenu() { }

	private void OnNextScreen() { }

	private void SetButtonsInteractable(bool state) { }

	private void SetExperienceState(Nullable experience = null) { }

	private void SetupExperienceBonus(Profile profile) { }

	public virtual void Show(ExitStatusScreenController controller) { }

	private void Show(Profile activeProfile, PlayerVisualRepresentation lastPlayerState, ESideType side, ExitStatus exitStatus, TimeSpan raidTime, IEftSession session, bool isOnline) { }

	private void ShowAggressor(Profile profile) { }

	private void ShowAggressorPlayerProfile() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

