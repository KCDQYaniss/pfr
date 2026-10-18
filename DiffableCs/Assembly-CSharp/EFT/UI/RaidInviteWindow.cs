namespace EFT.UI;

public sealed class RaidInviteWindow : DialogWindow
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <TryGetAccessToLocation>b__16_0(KeyValuePair item) { }

	}

	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0xD8
	[SerializeField]
	private TextMeshProUGUI _locationName; //Field offset: 0xE0
	[SerializeField]
	private LocationConditionsPanel _locationConditionsPanel; //Field offset: 0xE8
	[SerializeField]
	private GameObject _footer; //Field offset: 0xF0
	[SerializeField]
	private Image _redLight; //Field offset: 0xF8
	[SerializeField]
	private TextMeshProUGUI _footerText; //Field offset: 0x100
	[SerializeField]
	private GameObject[] _questItemsNotificationObjects; //Field offset: 0x108
	private ChatSpecialIconSettings _iconsSettings; //Field offset: 0x110
	private RaidSettings _raidSettings; //Field offset: 0x118
	private OfflineInventoryController _inventoryController; //Field offset: 0x120
	private EGameMode _gameMode; //Field offset: 0x128

	public RaidInviteWindow() { }

	private bool HasAnyValidAccessRequirement(IEnumerable inventoryItems, IReadOnlyDictionary accessKeyCount) { }

	private bool IsLocationAvailable(IEnumerable unlockedLocations) { }

	private bool NeedUnloadQuestItems() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public DialogWindowContext Show(IMatchmakerSession session, GroupPlayer player, RaidSettings raidSettings, OfflineInventoryController inventoryController) { }

	private void ToggleAccessFooter(bool active) { }

	private void ToggleQuestsItemsFooter(bool state) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private bool TryGetAccessToLocation(out string names, int profileLevel) { }

}

