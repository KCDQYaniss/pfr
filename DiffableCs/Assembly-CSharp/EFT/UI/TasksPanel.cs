namespace EFT.UI;

public sealed class TasksPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__29_1; //Field offset: 0x8
		public static Func <>9__32_0; //Field offset: 0x10
		public static Func <>9__32_1; //Field offset: 0x18
		public static Func <>9__35_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <FilterSort>b__35_0(KeyValuePair x) { }

		internal bool <Show>b__29_1(Quest x) { }

		internal bool <ValidateFavoriteQuestSeparator>b__32_0(KeyValuePair x) { }

		internal string <ValidateFavoriteQuestSeparator>b__32_1(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public NotesTask view; //Field offset: 0x10
		public TasksPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <Show>b__8() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public TasksPanel <>4__this; //Field offset: 0x10
		public int targetIndex; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <ValidateFavoriteQuestSeparator>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public TasksPanel <>4__this; //Field offset: 0x10
		public RectTransform rectTransform; //Field offset: 0x18

		public <>c__DisplayClass33_0() { }

		internal void <TaskSelectedHandler>b__0() { }

	}

	[SerializeField]
	private NotesTask _notesTaskTemplate; //Field offset: 0x70
	[SerializeField]
	private GameObject _notesTaskDescriptionTemplate; //Field offset: 0x78
	[SerializeField]
	private GameObject _objectTempContainer; //Field offset: 0x80
	[SerializeField]
	private QuestsSortPanel _questsSortPanel; //Field offset: 0x88
	[SerializeField]
	private RectTransform _notesTaskContent; //Field offset: 0x90
	[SerializeField]
	private ScrollRect _scrollRect; //Field offset: 0x98
	[SerializeField]
	private GameObject _noActiveTasksObject; //Field offset: 0xA0
	[SerializeField]
	private GameObject _emptyFilterResultObject; //Field offset: 0xA8
	[SerializeField]
	private Transform _favoriteQuestSeparator; //Field offset: 0xB0
	private EQuestsSortType _sortType; //Field offset: 0xB8
	private bool _sortAscend; //Field offset: 0xBC
	private bool _isInRaid; //Field offset: 0xBD
	private readonly Dictionary _questsAvailability; //Field offset: 0xC0
	private string _currentLocationId; //Field offset: 0xC8
	private IEftSession _session; //Field offset: 0xD0
	private Profile _activeProfile; //Field offset: 0xD8
	private QuestController _questController; //Field offset: 0xE0
	private QuestProgressComparer _questProgressComparer; //Field offset: 0xE8
	private QuestStatusComparer _questStatusComparer; //Field offset: 0xF0
	private QuestTierAccessoryComparer _questTierAccessoryComparer; //Field offset: 0xF8
	private QuestLocationComparer _questLocationComparer; //Field offset: 0x100
	private Dictionary _locations; //Field offset: 0x108
	private ViewList _questsViewList; //Field offset: 0x110
	private InventoryController _inventoryController; //Field offset: 0x118
	private FavoriteQuestManager _favoriteQuests; //Field offset: 0x120
	private TasksFilterInput _questFilterInput; //Field offset: 0x128
	private TasksFilterManager _filterManager; //Field offset: 0x130
	private NotesTaskDescriptionShort _description; //Field offset: 0x138

	public TasksPanel() { }

	[CompilerGenerated]
	private void <Show>b__29_0() { }

	[CompilerGenerated]
	private bool <Show>b__29_2(Quest quest) { }

	[CompilerGenerated]
	private void <Show>b__29_3(Quest quest, NotesTask view) { }

	[CompilerGenerated]
	private void <Show>b__29_4() { }

	[CompilerGenerated]
	private void <Show>b__29_5() { }

	[CompilerGenerated]
	private void <Show>b__29_6() { }

	[CompilerGenerated]
	private void <Show>b__29_7() { }

	[CompilerGenerated]
	private bool <Sort>b__36_0(Quest quest) { }

	[CompilerGenerated]
	private bool <Sort>b__36_1(Quest quest) { }

	private void FavoriteQuestAddOrRemoveHandler() { }

	private static bool FilterInGame(bool inRaid, QuestController questController, Quest quest) { }

	private void FilterSort() { }

	public void Init(InventoryController inventoryController, QuestController questController, IEftSession session, TasksFilterInput questFilterInput) { }

	public void Show(Func questsAdditionalFilter) { }

	private void Sort(IComparer comparer, bool sortAscend) { }

	private void Sort(EQuestsSortType sortType, bool sortDirection) { }

	private void TaskSelectedHandler(RectTransform rectTransform) { }

	private void ValidateFavoriteQuestSeparator() { }

	private void ValidateQuestFilter(string input, bool force) { }

	private void ValidateQuestFilter(string input) { }

}

