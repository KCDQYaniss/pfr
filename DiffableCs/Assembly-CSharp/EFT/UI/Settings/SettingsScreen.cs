namespace EFT.UI.Settings;

public sealed class SettingsScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__41_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <DisplayRevertMessage>b__41_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public ESettingsGroup key; //Field offset: 0x10
		public SettingsGroupObjects value; //Field offset: 0x18
		public SettingsScreen <>4__this; //Field offset: 0x28

		public <>c__DisplayClass26_0() { }

		internal void <Awake>b__1(bool isOn) { }

		internal void <Awake>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public ProfileInfo profileInfo; //Field offset: 0x10
		public bool toggleEnabled; //Field offset: 0x18

		public <>c__DisplayClass30_0() { }

		internal void <SettingsHandler>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public ProfileInfo profileInfo; //Field offset: 0x10
		public EMemberCategory value; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

		internal void <MemberCategoryHandler>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private struct <SaveButtonAction>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SettingsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum ESettingsGroup
	{
		Screen = 0,
		Game = 1,
		Sound = 2,
		Control = 3,
		PostFX = 4,
	}

	internal sealed class RaidSettingsScreenController : SettingsScreenController
	{

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		public virtual bool IsInRaidUiBlockersActive
		{
			 get { } //Length: 3
		}

		public virtual bool IsPostFxVisualizationEnable
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
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

		public RaidSettingsScreenController(IEftSession backEndSession) { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		public virtual bool get_IsInRaidUiBlockersActive() { }

		public virtual bool get_IsPostFxVisualizationEnable() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		protected virtual EShadingStateSwitcher get_ShadingType() { }

		protected virtual EStateSwitcher get_ShowEnvironment() { }

		protected virtual EStateSwitcher get_ShowEnvironmentCamera() { }

	}

	[IsReadOnly]
	private struct SettingsGroupObjects
	{
		public readonly SettingsTab Tab; //Field offset: 0x0
		public readonly UIAnimatedToggleSpawner Toggle; //Field offset: 0x8

		public SettingsGroupObjects(SettingsTab tab, UIAnimatedToggleSpawner toggle) { }

	}

	internal sealed class SettingsInMatchingScreenController : SettingsScreenController
	{

		public virtual bool IsInRaidUiBlockersActive
		{
			 get { } //Length: 3
		}

		public SettingsInMatchingScreenController(IEftSession backEndSession) { }

		public virtual bool get_IsInRaidUiBlockersActive() { }

	}

	internal class SettingsScreenController : EftScreenController
	{
		[CompilerGenerated]
		private struct <CloseScreenInterruption>d__18 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public SettingsScreenController <>4__this; //Field offset: 0x20
			public bool moveForward; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <SaveSettings>d__19 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public SettingsScreenController <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		internal sealed class SettingsGroups
		{
			[CompilerGenerated]
			private struct <ApplyTo>d__7 : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public SettingsManager manager; //Field offset: 0x20
				public SettingsGroups <>4__this; //Field offset: 0x28
				private TaskAwaiter <>u__1; //Field offset: 0x30

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			public GameSettingsGroup Game; //Field offset: 0x10
			public SoundSettingsGroup Sound; //Field offset: 0x18
			public PostFxSettingsGroup PostFx; //Field offset: 0x20
			public GraphicsSettingsGroup Graphics; //Field offset: 0x28
			public ControlSettingsGroup Control; //Field offset: 0x30

			public SettingsGroups() { }

			[AsyncStateMachine(typeof(<ApplyTo>d__7))]
			public Task ApplyTo(SettingsManager manager) { }

			public static SettingsGroups CopyFromManager(SettingsManager manager) { }

			public bool HasSameSettings(SettingsManager manager) { }

		}

		public readonly IEftSession BackEndSession; //Field offset: 0x58
		public SettingsGroups TempSettings; //Field offset: 0x60
		public GesturesCommandsStorage GesturesStorage; //Field offset: 0x68
		public ESettingsGroup CurrentGroup; //Field offset: 0x70
		public bool IgnoreScreenInterruptionCheck; //Field offset: 0x74
		private SettingsManager _settingsManager; //Field offset: 0x78

		public override bool IsInRaidUiBlockersActive
		{
			 get { } //Length: 3
		}

		public override bool IsPostFxVisualizationEnable
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 3
		}

		public SettingsManager OriginalSettings
		{
			 get { } //Length: 5
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public SettingsScreenController(IEftSession backEndSession) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(bool moveForward) { }

		[CompilerGenerated]
		private void <CloseScreenInterruption>b__18_0() { }

		[CompilerGenerated]
		private void <CloseScreenInterruption>b__18_1() { }

		private void ApplyOldSettings() { }

		[AsyncStateMachine(typeof(<CloseScreenInterruption>d__18))]
		protected virtual Task CloseScreenInterruption(bool moveForward) { }

		public override bool get_IsInRaidUiBlockersActive() { }

		public override bool get_IsPostFxVisualizationEnable() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public SettingsManager get_OriginalSettings() { }

		public virtual EEftScreenType get_ScreenType() { }

		public void InitSettings(SettingsManager settingsManager) { }

		[AsyncStateMachine(typeof(<SaveSettings>d__19))]
		public Task SaveSettings() { }

		public void TakeFromDefault() { }

		private void UpdateTempSettings() { }

	}

	private static readonly Dictionary _tabs; //Field offset: 0x0
	[SerializeField]
	private GameObject _loader; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _saveButton; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _defaultButton; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _creditsButton; //Field offset: 0xC0
	[SerializeField]
	[Space]
	private UIAnimatedToggleSpawner _gameButton; //Field offset: 0xC8
	[SerializeField]
	private UIAnimatedToggleSpawner _graphicsButton; //Field offset: 0xD0
	[SerializeField]
	private UIAnimatedToggleSpawner _postFXButton; //Field offset: 0xD8
	[SerializeField]
	private UIAnimatedToggleSpawner _soundButton; //Field offset: 0xE0
	[SerializeField]
	private UIAnimatedToggleSpawner _controlsButton; //Field offset: 0xE8
	[SerializeField]
	[Space]
	private GameSettingsTab _gameSettingsScreen; //Field offset: 0xF0
	[SerializeField]
	private GraphicsSettingsTab _graphicsSettingsScreen; //Field offset: 0xF8
	[SerializeField]
	private PostFXSettingsTab _postFXSettingsScreen; //Field offset: 0x100
	[SerializeField]
	private SoundSettingsTab _soundSettingsScreen; //Field offset: 0x108
	[SerializeField]
	private ControlSettingsTab _controlsSettingsTabScreen; //Field offset: 0x110
	private SettingsTab _currentTab; //Field offset: 0x118
	private IEftSession _session; //Field offset: 0x120
	private ProfileInfo _profileInfo; //Field offset: 0x128
	private BodyCustomization _customization; //Field offset: 0x130
	private readonly HashSet _initializedTabs; //Field offset: 0x138

	private static SettingsScreen() { }

	public SettingsScreen() { }

	[CompilerGenerated]
	private void <Awake>b__26_0() { }

	[CompilerGenerated]
	private void <DisplayRevertMessage>b__41_0() { }

	private void Awake() { }

	public virtual void Close() { }

	private void CloseAll() { }

	private void DisplayNoSaveMessage(Action accept, Action cancel) { }

	private void DisplayRevertMessage() { }

	private void EnsureTabInitialized(ESettingsGroup group) { }

	private void MemberCategoryHandler(EMemberCategory value) { }

	private void OnLoadingProgressHandler(bool inProgress) { }

	private void OpenGroup(ESettingsGroup desiredGroup) { }

	[AsyncStateMachine(typeof(<SaveButtonAction>d__43))]
	private void SaveButtonAction() { }

	private void SetSaveButtonActive(bool status) { }

	private void SettingsHandler(bool toggleEnabled) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	private void Show() { }

	public virtual void Show(SettingsScreenController controller) { }

	private void ShowCreditsScreen() { }

	private void ShowScreen(ESettingsGroup group) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

