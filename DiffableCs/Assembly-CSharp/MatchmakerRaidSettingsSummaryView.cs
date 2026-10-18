//Type is in global namespace

public sealed class MatchmakerRaidSettingsSummaryView : UIElement
{
	private const string ENABLED_TEXT = "Enabled"; //Field offset: 0x0
	private const string DISABLED_TEXT = "Disabled"; //Field offset: 0x0
	[SerializeField]
	private List _labelsCanvasGroups; //Field offset: 0x70
	[SerializeField]
	private MatchmakerRaidSettingView _coopEnabledSetting; //Field offset: 0x78
	[SerializeField]
	private MatchmakerRaidSettingView _playerSpawnSetting; //Field offset: 0x80
	[SerializeField]
	private MatchmakerRaidSettingView _FoodAndWaterSetting; //Field offset: 0x88
	[SerializeField]
	private MatchmakerRaidSettingView _weatherSettings; //Field offset: 0x90
	[SerializeField]
	private MatchmakerRaidSettingView _dayTimeSettings; //Field offset: 0x98
	[SerializeField]
	private MatchmakerRaidSettingView _randomWeatherSettings; //Field offset: 0xA0
	[SerializeField]
	private MatchmakerRaidSettingView _randomTimeSettings; //Field offset: 0xA8
	[SerializeField]
	private MatchmakerRaidSettingView _timeFlowSettings; //Field offset: 0xB0
	[SerializeField]
	private MatchmakerRaidSettingView _freeCameraSettings; //Field offset: 0xB8
	[SerializeField]
	private MatchmakerRaidSettingView _openedDoorsSettings; //Field offset: 0xC0
	[SerializeField]
	private MatchmakerRaidSettingView _healthSettings; //Field offset: 0xC8
	[SerializeField]
	private MatchmakerRaidSettingView _overloadSettings; //Field offset: 0xD0
	[SerializeField]
	private MatchmakerRaidSettingView _armsStaminaSettings; //Field offset: 0xD8
	[SerializeField]
	private MatchmakerRaidSettingView _legsStaminaSettings; //Field offset: 0xE0
	[SerializeField]
	private MatchmakerRaidSettingView _aiAmountSettings; //Field offset: 0xE8
	[SerializeField]
	private MatchmakerRaidSettingView _aiDifficultySettings; //Field offset: 0xF0
	[SerializeField]
	private MatchmakerRaidSettingView _silentBotsSettings; //Field offset: 0xF8
	[SerializeField]
	private MatchmakerRaidSettingView _bossesEnabledSettings; //Field offset: 0x100
	[SerializeField]
	private MatchmakerRaidSettingView _bossPickSettings; //Field offset: 0x108
	[SerializeField]
	private MatchmakerRaidSettingView _friendlyScavsSettings; //Field offset: 0x110
	[SerializeField]
	private MatchmakerRaidSettingView _scavWarSettings; //Field offset: 0x118
	[SerializeField]
	private MatchmakerRaidSettingView _cursedSettings; //Field offset: 0x120

	public MatchmakerRaidSettingsSummaryView() { }

	public void Show(RaidSettings raidSettings) { }

}

