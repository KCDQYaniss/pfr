namespace EFT.UI.Matchmaker;

public sealed class RaidSettingsWindow : BaseUiWindow
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__34_0; //Field offset: 0x8
		public static Func <>9__34_1; //Field offset: 0x10
		public static Func <>9__34_2; //Field offset: 0x18
		public static Func <>9__34_3; //Field offset: 0x20
		public static Func <>9__34_4; //Field offset: 0x28
		public static Func <>9__34_5; //Field offset: 0x30
		public static Func <>9__34_6; //Field offset: 0x38
		public static Func <>9__34_7; //Field offset: 0x40
		public static Func <>9__34_8; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal string <Show>b__34_0(string difficulty) { }

		internal string <Show>b__34_1(string amount) { }

		internal string <Show>b__34_2(string place) { }

		internal string <Show>b__34_3(string clouds) { }

		internal string <Show>b__34_4(string rain) { }

		internal string <Show>b__34_5(string wind) { }

		internal string <Show>b__34_6(string fog) { }

		internal string <Show>b__34_7(string timeFlow) { }

		internal string <Show>b__34_8(string bossType) { }

	}

	[HideInInspector]
	public readonly UnityEvent OnRaidSettingsChanged; //Field offset: 0x80
	[SerializeField]
	private UpdatableToggle _coopModeToggle; //Field offset: 0x88
	[SerializeField]
	private UiElementBlocker _coopModeBlocker; //Field offset: 0x90
	[Header("Game settings")]
	[SerializeField]
	private UpdatableToggle _metabolismDisabledToggle; //Field offset: 0x98
	[SerializeField]
	private UpdatableToggle _randomTimeToggle; //Field offset: 0xA0
	[SerializeField]
	private UpdatableToggle _randomWeatherToggle; //Field offset: 0xA8
	[SerializeField]
	private DropDownBox _playersSpawnPlaceDropdown; //Field offset: 0xB0
	[SerializeField]
	private DropDownBox _cloudinessDropdown; //Field offset: 0xB8
	[SerializeField]
	private DropDownBox _rainDropdown; //Field offset: 0xC0
	[SerializeField]
	private DropDownBox _windSpeedDropdown; //Field offset: 0xC8
	[SerializeField]
	private DropDownBox _fogDropdown; //Field offset: 0xD0
	[SerializeField]
	private DropDownBox _timeFlowDropdown; //Field offset: 0xD8
	[SerializeField]
	private DropDownBox _timeOfDayDropdown; //Field offset: 0xE0
	[SerializeField]
	private List _playersSpawnPlaceCanvasGroups; //Field offset: 0xE8
	[SerializeField]
	private List _randomTimeAndWeatherCanvasGroups; //Field offset: 0xF0
	[SerializeField]
	private List _waterAndFoodCanvasGroups; //Field offset: 0xF8
	[SerializeField]
	private List _timeCanvasGroups; //Field offset: 0x100
	[SerializeField]
	private List _weatherCanvasGroups; //Field offset: 0x108
	[Header("PVE settings")]
	[SerializeField]
	private UpdatableToggle _enableBosses; //Field offset: 0x110
	[SerializeField]
	private UpdatableToggle _taggedAndCursed; //Field offset: 0x118
	[SerializeField]
	private UpdatableToggle _scavWars; //Field offset: 0x120
	[SerializeField]
	private DropDownBox _bossPickDropdown; //Field offset: 0x128
	[SerializeField]
	private DropDownBox _aiDifficultyDropdown; //Field offset: 0x130
	[SerializeField]
	private DropDownBox _aiAmountDropdown; //Field offset: 0x138
	[SerializeField]
	private CanvasGroup _aiAmountCanvasGroup; //Field offset: 0x140
	[SerializeField]
	private CanvasGroup _aiDifficultyCanvasGroup; //Field offset: 0x148
	[SerializeField]
	private List _wavesCanvasGroups; //Field offset: 0x150
	private readonly List _canvasGroups; //Field offset: 0x158
	private RaidSettings _raidSettings; //Field offset: 0x160
	private RaidSettings _backupRaidSettings; //Field offset: 0x168
	private ProfileInfo _profileInfo; //Field offset: 0x170
	private MatchmakerPlayersController _matchmaker; //Field offset: 0x178
	private ProfileBan _onlineBan; //Field offset: 0x180

	public RaidSettingsWindow() { }

	[CompilerGenerated]
	private void <Awake>b__33_0(int index) { }

	[CompilerGenerated]
	private void <InitDropdown>b__37_0(int _) { }

	[CompilerGenerated]
	private void <InitToggle>b__36_0(bool _) { }

	[CompilerGenerated]
	private void <Show>b__34_9() { }

	protected virtual void Awake() { }

	private void BanChangedHandler(EBanType banType = 4) { }

	private void CheckCoopAvailable() { }

	private void InitDropdown(DropDownBox dropDown, IEnumerable values, int initValue) { }

	private void InitToggle(UpdatableToggle toggle, bool initValue) { }

	public void RestoreOriginalOfflineSettings() { }

	private void SetBots(bool value) { }

	private void SetLocalGame(bool value) { }

	private void SetOnlinePveMode(bool value) { }

	private void SetTimeAndWeather(bool val) { }

	public void Show(RaidSettings raidSettings, ProfileInfo profileInfo, MatchmakerPlayersController matchmaker) { }

	private void UpdateRaidSettings() { }

}

