namespace EFT.UI;

[Obfuscation(Exclude = True)]
public sealed class TasksScreen : UIElement
{
	[CompilerGenerated]
	private struct <<StartAddNote>g__AddNote|66_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TasksScreen <>4__this; //Field offset: 0x28
		public string text; //Field offset: 0x30
		private Locker <>7__wrap1; //Field offset: 0x38
		private Note <note>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__71_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <OnSearchTextChanged>b__71_0(JournalNote x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public TasksScreen <>4__this; //Field offset: 0x10
		public CanvasGroup canvasGroup; //Field offset: 0x18

		public <>c__DisplayClass59_0() { }

		internal void <ShowCurrentTab>b__0() { }

		internal void <ShowCurrentTab>b__2(bool show) { }

		internal void <ShowCurrentTab>b__3(bool show) { }

		internal void <ShowCurrentTab>b__4(bool show) { }

		internal void <ShowCurrentTab>g__QuestAddedHandler|1(Quest quest) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public Note note; //Field offset: 0x10

		public <>c__DisplayClass68_0() { }

		internal bool <GetNoteView>b__0(JournalNote journalNote) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		private struct <<StartEditNote>g__EditNote|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass69_0 <>4__this; //Field offset: 0x28
			public string text; //Field offset: 0x30
			private Locker <>7__wrap1; //Field offset: 0x38
			private TaskAwaiter <>u__1; //Field offset: 0x40

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public TasksScreen <>4__this; //Field offset: 0x10
		public Note note; //Field offset: 0x18

		public <>c__DisplayClass69_0() { }

		internal void <StartEditNote>b__0() { }

		[AsyncStateMachine(typeof(<<StartEditNote>g__EditNote|1>d))]
		internal void <StartEditNote>g__EditNote|1(string text) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__IsChapter; //Field offset: 0x0
		public static Func <1>__IsRegularQuest; //Field offset: 0x8
		public static Func <2>__IsDailyQuest; //Field offset: 0x10

	}

	[CompilerGenerated]
	private struct <DestroyNote>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TasksScreen <>4__this; //Field offset: 0x28
		public Note note; //Field offset: 0x30
		private Locker <>7__wrap1; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class TasksTabController : UIElementTabController
	{
		private readonly InventoryController _inventoryController; //Field offset: 0x18
		private readonly QuestController _questController; //Field offset: 0x20
		private readonly IEftSession _session; //Field offset: 0x28
		private readonly NotesManager _notesManager; //Field offset: 0x30
		private readonly InventoryScreenController _screenController; //Field offset: 0x38
		private readonly ItemContext _sourceContext; //Field offset: 0x40

		public TasksTabController(TasksScreen tasksTab, InventoryController inventoryController, QuestController questController, IEftSession session, NotesManager notesManager, InventoryScreenController screenController, ItemContext sourceContext) { }

		public virtual void Show() { }

	}

	public static Action OnQuestItemSelected; //Field offset: 0x0
	[SerializeField]
	private UIAnimatedToggleSpawner _mainQuestToggleSpawner; //Field offset: 0x70
	[SerializeField]
	private UIAnimatedToggleSpawner _defaultQuestsToggleSpawner; //Field offset: 0x78
	[SerializeField]
	private UIAnimatedToggleSpawner _dailyQuestsToggleSpawner; //Field offset: 0x80
	[SerializeField]
	private HoverTooltipArea _mainQuestTooltip; //Field offset: 0x88
	[SerializeField]
	private UIAnimatedToggleSpawner _notesToggleSpawner; //Field offset: 0x90
	[SerializeField]
	private UIAnimatedToggleSpawner _questItemsToggleSpawner; //Field offset: 0x98
	[SerializeField]
	private GameObject _inventoryBlocker; //Field offset: 0xA0
	[SerializeField]
	private GameObject _notesPart; //Field offset: 0xA8
	[SerializeField]
	private GameObject _questItemsPart; //Field offset: 0xB0
	[SerializeField]
	private TasksPanel _tasksPanel; //Field offset: 0xB8
	[SerializeField]
	private MainQuestTabView _mainQuestView; //Field offset: 0xC0
	[SerializeField]
	private NoteWindow _noteWindow; //Field offset: 0xC8
	[SerializeField]
	private GameObject _notesIsBusySpinner; //Field offset: 0xD0
	[SerializeField]
	private CanvasGroup _notesCanvasGroup; //Field offset: 0xD8
	[SerializeField]
	private JournalNote _noteTemplate; //Field offset: 0xE0
	[SerializeField]
	private RectTransform _notesContent; //Field offset: 0xE8
	[SerializeField]
	private DefaultUIButton _addNoteButton; //Field offset: 0xF0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xF8
	[SerializeField]
	[Space]
	private GridView _questRaidGrid; //Field offset: 0x100
	[SerializeField]
	private GridView _questStashGrid; //Field offset: 0x108
	[SerializeField]
	private CanvasGroup _transferCanvasGroup; //Field offset: 0x110
	[SerializeField]
	private DefaultUIButton _transferButtonSpawner; //Field offset: 0x118
	[SerializeField]
	private Image _transferIcon; //Field offset: 0x120
	[SerializeField]
	private Sprite _downTransferSprite; //Field offset: 0x128
	[SerializeField]
	private Sprite _upTransferSprite; //Field offset: 0x130
	[SerializeField]
	private Image _warningImage; //Field offset: 0x138
	[SerializeField]
	private GameObject _noActiveTasksObject; //Field offset: 0x140
	[SerializeField]
	private TextMeshProUGUI _notesCounter; //Field offset: 0x148
	[SerializeField]
	private TMP_InputField _searchField; //Field offset: 0x150
	[SerializeField]
	private MainQuestUnreadWarning _mainUnreadWarning; //Field offset: 0x158
	[SerializeField]
	private TasksFilterInput _questSearchInputField; //Field offset: 0x160
	[CompilerGenerated]
	private Action OnBackButtonClick; //Field offset: 0x168
	private SimpleTooltip _tooltip; //Field offset: 0x170
	private QuestItemView _selectedItemView; //Field offset: 0x178
	private InventoryController _inventoryController; //Field offset: 0x180
	private NotesManager _notesManager; //Field offset: 0x188
	private readonly List _notes; //Field offset: 0x190
	private CompoundItem _questRaidItem; //Field offset: 0x198
	private CompoundItem _questStashItem; //Field offset: 0x1A0
	private IEftSession _session; //Field offset: 0x1A8
	private QuestController _questController; //Field offset: 0x1B0
	private Func _questsAdditionalFilter; //Field offset: 0x1B8
	private bool _isInventoryBlocked; //Field offset: 0x1C0
	private ItemContext _sourceContext; //Field offset: 0x1C8
	private InventoryScreenController _screenController; //Field offset: 0x1D0

	public event Action OnBackButtonClick
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	private bool CanTransferQuestItems
	{
		private get { } //Length: 85
	}

	private bool IsInRaid
	{
		private get { } //Length: 59
	}

	private string RaidQuestWarningText
	{
		private get { } //Length: 236
	}

	private bool SelectedItemInRaidStash
	{
		private get { } //Length: 312
	}

	public TasksScreen() { }

	[CompilerGenerated]
	private void <Awake>b__57_0(bool arg) { }

	[CompilerGenerated]
	private void <Awake>b__57_1(bool arg) { }

	[CompilerGenerated]
	private void <Awake>b__57_2() { }

	[CompilerGenerated]
	private void <Awake>b__57_3(PointerEventData _) { }

	[CompilerGenerated]
	private void <Awake>b__57_4(PointerEventData _) { }

	[CompilerGenerated]
	private void <Awake>b__57_5() { }

	[CompilerGenerated]
	private void <Show>b__58_0() { }

	[CompilerGenerated]
	private void <Show>b__58_1(bool newValue) { }

	[CompilerGenerated]
	internal static void <ShowCurrentTab>g__ShowTab|59_5(bool show, Action showMethod) { }

	[CompilerGenerated]
	private void <StartAddNote>b__66_0() { }

	[AsyncStateMachine(typeof(<<StartAddNote>g__AddNote|66_1>d))]
	[CompilerGenerated]
	private void <StartAddNote>g__AddNote|66_1(string text) { }

	[CompilerGenerated]
	public void add_OnBackButtonClick(Action value) { }

	private void Awake() { }

	private void CleanNotes() { }

	private void CreateNote(Note note) { }

	private void CreateNotes() { }

	[AsyncStateMachine(typeof(<DestroyNote>d__70))]
	private void DestroyNote(Note note) { }

	private bool get_CanTransferQuestItems() { }

	private bool get_IsInRaid() { }

	private string get_RaidQuestWarningText() { }

	private bool get_SelectedItemInRaidStash() { }

	[CanBeNull]
	private JournalNote GetNoteView(Note note) { }

	private static bool IsChapter(Quest quest) { }

	public static bool IsDailyQuest(Quest quest) { }

	public static bool IsRegularQuest(Quest quest) { }

	private void OnSearchTextChanged(string newText) { }

	private void QuestItemSelectedHandler(QuestItemView itemView) { }

	[CompilerGenerated]
	public void remove_OnBackButtonClick(Action value) { }

	private void Show(InventoryController inventoryController, QuestController questController, IEftSession session, NotesManager notesManager, InventoryScreenController screenController, ItemContext sourceContext) { }

	private void ShowCurrentTab() { }

	private void ShowDailyQuests(bool forced) { }

	private void ShowMainQuests(bool forced) { }

	private void ShowSideQuests(bool forced) { }

	private void StartAddNote() { }

	private void StartEditNote(Note note) { }

}

