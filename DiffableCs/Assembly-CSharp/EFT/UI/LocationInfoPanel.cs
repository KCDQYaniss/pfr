namespace EFT.UI;

public sealed class LocationInfoPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__27_0; //Field offset: 0x8
		public static Func <>9__27_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Set>b__27_0(BossLocationSpawn x) { }

		internal bool <Set>b__27_1(BossLocationSpawn x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public LocationInfoPanel <>4__this; //Field offset: 0x10
		public ESideType playerSide; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <SetupPveServerModeToggle>b__0() { }

	}

	internal class SpecialInfo
	{
		public Sprite banner; //Field offset: 0x10
		public string name; //Field offset: 0x18
		public string description; //Field offset: 0x20

		public SpecialInfo() { }

	}

	[SerializeField]
	private CustomTextMeshProUGUI _name; //Field offset: 0x70
	[SerializeField]
	private GameObject _lockedPanel; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _availableOnLevelLabel; //Field offset: 0x80
	[SerializeField]
	private GameObject _watchIntro; //Field offset: 0x88
	[SerializeField]
	private Sprite _defaultImage; //Field offset: 0x90
	[SerializeField]
	private Image _banner; //Field offset: 0x98
	[SerializeField]
	private CustomTextMeshProUGUI _description; //Field offset: 0xA0
	[SerializeField]
	private CustomTextMeshProUGUI _area; //Field offset: 0xA8
	[SerializeField]
	private CustomTextMeshProUGUI _playTime; //Field offset: 0xB0
	[SerializeField]
	private CustomTextMeshProUGUI _difficulty; //Field offset: 0xB8
	[SerializeField]
	private CustomTextMeshProUGUI _players; //Field offset: 0xC0
	[SerializeField]
	private GameObject _boss; //Field offset: 0xC8
	[SerializeField]
	private LocationWarningPanel _warningPanel; //Field offset: 0xD0
	[SerializeField]
	private LocationWarningPanel _levelWarningPanel; //Field offset: 0xD8
	[SerializeField]
	private GameObject _bottomPanel; //Field offset: 0xE0
	[SerializeField]
	private Dictionary _specialInfos; //Field offset: 0xE8
	[Header("PveServerMode")]
	[SerializeField]
	[Space]
	private GameObject _pveServerModePanel; //Field offset: 0xF0
	[SerializeField]
	private UpdatableToggle _onlineModeToggle; //Field offset: 0xF8
	[SerializeField]
	private UiElementBlocker _pveServerModeBlocker; //Field offset: 0x100
	private Location _location; //Field offset: 0x108
	private MatchmakerPlayersController _matchmaker; //Field offset: 0x110
	private RaidSettings _raidSettings; //Field offset: 0x118
	private IEftSession _session; //Field offset: 0x120
	private ESideType _chosenSideType; //Field offset: 0x128
	private bool _unavailableByPmcLevel; //Field offset: 0x12C
	private bool _unavailableByQuest; //Field offset: 0x12D

	public LocationInfoPanel() { }

	private string GetUnavailableText(Location location, bool unavailableByQuest, bool unavailableByLevel, ESideType side) { }

	private void HandleOnlineModeToggle(bool isOn) { }

	private void HandlePveServerModeBlock(ESideType playerSide) { }

	private bool IsLocationForcedInRaidMode(ESideType playerSide) { }

	public void Set(Location location, ESideType chosenSideType, int selfLevel, int minPlayerLevel, int maxPlayerLevel, bool unlockedForPlayer, EGameMode gameMode, MatchmakerPlayersController matchmaker, RaidSettings raidSettings, IEftSession session) { }

	private void SetDefault() { }

	public void SetSpecial(int id) { }

	private void SetupPveServerModeToggle(bool isPve, ESideType playerSide) { }

}

