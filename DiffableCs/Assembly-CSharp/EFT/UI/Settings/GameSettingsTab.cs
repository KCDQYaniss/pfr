namespace EFT.UI.Settings;

public sealed class GameSettingsTab : SettingsTab
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__26_0; //Field offset: 0x8
		public static Func <>9__26_1; //Field offset: 0x10
		public static Func <>9__26_3; //Field offset: 0x18
		public static Func <>9__27_1; //Field offset: 0x20
		public static Func <>9__27_2; //Field offset: 0x28
		public static Action <>9__29_1; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal void <ShowClearWishlistButton>b__29_1() { }

		internal EEnvironmentUIType <ShowEnvironment>b__26_0(CustomizationEnvironmentUI availableCustomization) { }

		internal EEnvironmentUIType <ShowEnvironment>b__26_1(CustomizationEnvironmentUI x) { }

		internal EEnvironmentUIType <ShowEnvironment>b__26_3(CustomizationEnvironmentUI x) { }

		internal EMemberCategory <ShowProfileIcon>b__27_1(IconsData k) { }

		internal IconsData <ShowProfileIcon>b__27_2(IconsData v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public bool inRaid; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal bool <CreateBlockers>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		private struct <<ShowEnvironment>g__ApplyEnvironmentUi|8>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass26_0 <>4__this; //Field offset: 0x20
			public EEnvironmentUIType value; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public HashSet availableTypes; //Field offset: 0x10
		public GameSettingsTab <>4__this; //Field offset: 0x18
		public ReadOnlyCollection variants; //Field offset: 0x20
		public SettingControl control; //Field offset: 0x28

		public <>c__DisplayClass26_0() { }

		internal bool <ShowEnvironment>b__2(CustomizationEnvironmentUI x) { }

		[AsyncStateMachine(typeof(<<ShowEnvironment>g__ApplyEnvironmentUi|8>d))]
		internal Task <ShowEnvironment>g__ApplyEnvironmentUi|8(EEnvironmentUIType value) { }

		internal void <ShowEnvironment>g__EnvironmentChangeHandler|7(EEnvironmentUIType value) { }

		internal void <ShowEnvironment>g__RemoveLoadingStatus|5() { }

		internal bool <ShowEnvironment>g__Validator|6(int index) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public GameSettingsTab <>4__this; //Field offset: 0x10
		public Dictionary availableIcons; //Field offset: 0x18

		public <>c__DisplayClass27_0() { }

		internal bool <ShowProfileIcon>b__0(IconsData x) { }

		internal void <ShowProfileIcon>g__SettingChangeHandler|3(EMemberCategory value) { }

		internal string <ShowProfileIcon>g__StringConverter|4(EMemberCategory value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public IDictionary languagesDict; //Field offset: 0x10
		public GameSettingsTab <>4__this; //Field offset: 0x18
		public SettingDropDown settingDropdown; //Field offset: 0x20

		public <>c__DisplayClass28_0() { }

		internal string <ShowInterfaceLanguage>b__0(string language) { }

		internal void <ShowInterfaceLanguage>b__1(string _) { }

		internal void <ShowInterfaceLanguage>b__2(string value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public ItemUiContext uiContext; //Field offset: 0x10
		public GameSettingsTab <>4__this; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <ShowClearWishlistButton>g__ClearAction|2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0`1
	{
		public string localizationFormat; //Field offset: 0x0

		public <>c__DisplayClass40_0`1() { }

		internal string <ShowCommonDropDown>b__0(T x) { }

	}

	[CompilerGenerated]
	private struct <ReloadLocale>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameSettingsTab <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TakeSettingsFrom>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SettingsManager settingsManager; //Field offset: 0x20
		public GameSettingsTab <>4__this; //Field offset: 0x28
		private GameSettingsGroup <defaultSettings>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string NICKNAME_CHANGE_COOLDOWN = "NicknameCanBeChangedAfter"; //Field offset: 0x0
	[SerializeField]
	private RectTransform _settingsRoot; //Field offset: 0x98
	[SerializeField]
	private SettingDropDown _dropDownTemplate; //Field offset: 0xA0
	[SerializeField]
	private SettingFloatSlider _floatSliderTemplate; //Field offset: 0xA8
	[SerializeField]
	private SettingToggle _toggleTemplate; //Field offset: 0xB0
	[SerializeField]
	private SettingsTooltip _tooltip; //Field offset: 0xB8
	[SerializeField]
	private ValidationInputField _nicknameInput; //Field offset: 0xC0
	[SerializeField]
	private DefaultUIButton _changeNicknameButton; //Field offset: 0xC8
	[SerializeField]
	private GameObject _nicknameBlocker; //Field offset: 0xD0
	[SerializeField]
	private DefaultUiButtonNewStyle _clearWishlistButton; //Field offset: 0xD8
	[SerializeField]
	private ChatSpecialIconSettings _iconsSettings; //Field offset: 0xE0
	private GameSettingsGroup _gameSettings; //Field offset: 0xE8
	private GameSettingsController _controller; //Field offset: 0xF0
	private IEftSession _backEndSession; //Field offset: 0xF8
	private Profile _profile; //Field offset: 0x100
	private string _changedNickname; //Field offset: 0x108
	private Nullable _changeNicknameDateUtc; //Field offset: 0x110
	private BlockController _inRaidBlockController; //Field offset: 0x120
	private int _currentControlIndex; //Field offset: 0x128
	private bool _isInRaidUiBlockersActive; //Field offset: 0x12C

	public GameSettingsTab() { }

	[CompilerGenerated]
	private void <Awake>b__20_0(string x) { }

	[CompilerGenerated]
	private void <Awake>b__20_1(string x) { }

	[CompilerGenerated]
	private void <Awake>b__20_2(string x) { }

	[CompilerGenerated]
	private void <ChangeNickname>b__42_0(Result changeNicknameResult) { }

	[CompilerGenerated]
	private void <Show>b__22_0(bool x) { }

	[CompilerGenerated]
	private void <ShowClearWishlistButton>g__ClearWishlist|29_0() { }

	[CompilerGenerated]
	internal static string <ShowEnvironment>g__StringConverter|26_4(EEnvironmentUIType value) { }

	private void Awake() { }

	private void ChangeNickname() { }

	public virtual void Close() { }

	private void CreateBlockers(bool inRaid) { }

	private void CreateControls() { }

	protected virtual void OnFirstSelect() { }

	private void RefreshNickname(bool hideStreamerName) { }

	private void RefreshNicknameCooldownMessage(long date) { }

	[AsyncStateMachine(typeof(<ReloadLocale>d__41))]
	private Task ReloadLocale() { }

	public void Show(GameSettingsGroup gameSettings, IEftSession backEndSession, bool isInRaidUiBlockersActive) { }

	private void ShowBlockGroupInvites() { }

	private void ShowClearRam() { }

	private void ShowClearWishlistButton() { }

	private SettingDropDown ShowCommonDropDown(GameSetting setting, RectTransform root, bool twoWays = true, Func validator = null, Action customUpdater = null, string localizationFormat = null) { }

	private void ShowCoreAffinity() { }

	private void ShowEnvironment() { }

	private void ShowFieldOfView() { }

	private void ShowHeadBobbing() { }

	private void ShowHideoutPreload() { }

	private void ShowInterfaceLanguage() { }

	private void ShowMalfunctionVisibility() { }

	private void ShowProfileIcon() { }

	private void ShowSpectatingEnable() { }

	private void ShowStreamerMode() { }

	private void ShowTraderIntermadiate() { }

	[AsyncStateMachine(typeof(<TakeSettingsFrom>d__43))]
	public virtual Task TakeSettingsFrom(SettingsManager settingsManager) { }

	private void Update() { }

	private void UpdateChangeNicknameButton() { }

}

