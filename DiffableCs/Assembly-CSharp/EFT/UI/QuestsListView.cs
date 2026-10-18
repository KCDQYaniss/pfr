namespace EFT.UI;

[Obfuscation(Exclude = True)]
public sealed class QuestsListView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public InventoryController inventoryController; //Field offset: 0x10
		public QuestsListView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass30_0() { }

		internal void <Show>b__0() { }

	}

	private const string TIERED_DISPLAY_MODE_TOOLTIP = "UI/Quests/DisplayMode/Tiered"; //Field offset: 0x0
	private const string FLAT_DISPLAY_MODE_TOOLTIP = "UI/Quests/DisplayMode/Flat"; //Field offset: 0x0
	private static Nullable _listShowLocked; //Field offset: 0x0
	private static Nullable _listShowOldDisplay; //Field offset: 0x2
	private static readonly ETierAccessoryType[] FallbackCategoryOrder; //Field offset: 0x8
	[SerializeField]
	private RectTransform _displayContainer; //Field offset: 0x70
	[SerializeField]
	private FlatQuestListDisplayView _flatDisplayPrefab; //Field offset: 0x78
	[SerializeField]
	private TieredQuestListDisplayView _tieredDisplayPrefab; //Field offset: 0x80
	[SerializeField]
	private TMP_Text _questsCounterText; //Field offset: 0x88
	[SerializeField]
	private Toggle _toggleShowCompleted; //Field offset: 0x90
	[SerializeField]
	private Toggle _toggleShowLocked; //Field offset: 0x98
	[SerializeField]
	private ToggleGroupEFT _displayModeToggleGroup; //Field offset: 0xA0
	[SerializeField]
	private ToggleEFT _tieredDisplayToggle; //Field offset: 0xA8
	[SerializeField]
	private ToggleEFT _flatDisplayToggle; //Field offset: 0xB0
	private QuestController _questController; //Field offset: 0xB8
	private QuestView _questView; //Field offset: 0xC0
	private IEftSession _backendSession; //Field offset: 0xC8
	private InventoryController _inventoryController; //Field offset: 0xD0
	private Trader _trader; //Field offset: 0xD8
	private BaseQuestListDisplayView _activeDisplay; //Field offset: 0xE0
	private QuestListItemView _selectedQuestView; //Field offset: 0xE8
	private readonly List _questListExcludeFilter; //Field offset: 0xF0
	private bool _questStatusRefreshPending; //Field offset: 0xF8
	private bool _listShowCompleted; //Field offset: 0xF9

	private bool ListShowLocked
	{
		private get { } //Length: 386
		private set { } //Length: 296
	}

	private bool ListShowOldDisplay
	{
		private get { } //Length: 389
		private set { } //Length: 298
	}

	private static QuestsListView() { }

	public QuestsListView() { }

	private void AutoSelectQuest() { }

	private void Awake() { }

	private void ClearDisplay() { }

	private static void ClearLastSelectedQuestId(string traderId) { }

	private void ClearQuestSelection() { }

	public virtual void Close() { }

	private QuestListDisplayContext CreateDisplayContext() { }

	private Quest FindTraderQuest(string questId) { }

	private bool get_ListShowLocked() { }

	private bool get_ListShowOldDisplay() { }

	private static string GetLastSelectedQuestId(string traderId) { }

	private static string GetLastSelectedQuestKey(string traderId) { }

	private static ETierAccessoryType GetQuestCategory(Quest quest) { }

	private void InitDisplayModeToggles() { }

	private bool IsCurrentSelectionVisible() { }

	private void OnFlatDisplayToggle(bool isOn) { }

	private void OnInventoryItemAdded(AddItemEventArgs eventArgs) { }

	private void OnInventoryItemRefreshed(RefreshItemEventArgs _) { }

	private void OnInventoryItemRemoved(RemoveItemEventArgs eventArgs) { }

	private void OnQuestRemovedFromList(Quest removedQuest) { }

	private void OnQuestSelected(QuestListItemView view) { }

	private void OnTieredDisplayToggle(bool isOn) { }

	private void OnToggleShowCompleted(bool show) { }

	private void OnToggleShowLocked(bool show) { }

	private void SelectQuestView(QuestListItemView view, bool savePreference) { }

	private void set_ListShowLocked(bool value) { }

	private void set_ListShowOldDisplay(bool value) { }

	private void SetDisplayMode(bool useOldDisplay) { }

	private static void SetLastSelectedQuestId(string traderId, string questId) { }

	private void SetupDisplayModeToggleTooltip(ToggleEFT toggle, string localizationKey) { }

	public void Show(IEftSession backendSession, InventoryController inventoryController, QuestController questController, Trader trader, QuestView questView) { }

	private void SpawnDisplay() { }

	private void SyncExcludeFilter() { }

	private bool TrySelectFallbackQuest() { }

	private bool TrySelectFirstInCategory(ETierAccessoryType category) { }

	private bool TrySelectLastSelectedQuest() { }

	private void Update() { }

	private void UpdateCounterText(int successCount, int totalCount) { }

}

