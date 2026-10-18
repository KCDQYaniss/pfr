namespace EFT.UI;

[Obfuscation(Exclude = True)]
public sealed class AchievementsScreen : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static LightScrollerDataTypeGetter <>9__23_0; //Field offset: 0x8
		public static Func <>9__24_0; //Field offset: 0x10
		public static Func <>9__24_1; //Field offset: 0x18
		public static Func <>9__24_2; //Field offset: 0x20
		public static Func <>9__24_3; //Field offset: 0x28
		public static Func <>9__28_0; //Field offset: 0x30
		public static Func <>9__28_1; //Field offset: 0x38
		public static Func <>9__28_2; //Field offset: 0x40
		public static Func <>9__28_3; //Field offset: 0x48
		public static Func <>9__28_4; //Field offset: 0x50

		private static <>c() { }

		public <>c() { }

		internal float <GetSortedAchievements>b__24_0(Achievement a) { }

		internal bool <GetSortedAchievements>b__24_1(Achievement a) { }

		internal DateTime <GetSortedAchievements>b__24_2(Achievement a) { }

		internal int <GetSortedAchievements>b__24_3(Achievement a) { }

		internal bool <SetupOverallPanel>b__28_0(Achievement a) { }

		internal bool <SetupOverallPanel>b__28_1(Achievement a) { }

		internal bool <SetupOverallPanel>b__28_2(Achievement a) { }

		internal bool <SetupOverallPanel>b__28_3(Achievement a) { }

		internal bool <SetupOverallPanel>b__28_4(Achievement a) { }

		internal Enum <ShowAchievements>b__23_0(AchievementListItem listItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public AchievementsScreen <>4__this; //Field offset: 0x10
		public NotesTaskDescriptionShort description; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal void <ShowAchievements>b__1(AchievementListItem listItem, UIElement view) { }

	}

	private sealed class AchievementEntryListItem : AchievementListItem
	{
		public readonly Achievement Achievement; //Field offset: 0x18

		public AchievementEntryListItem(Achievement achievement) { }

	}

	private abstract class AchievementListItem
	{
		public readonly EAchievementListItemType ItemType; //Field offset: 0x10

		protected AchievementListItem(EAchievementListItemType itemType) { }

	}

	internal sealed class AchievementsTabController : UIElementTabController
	{
		private readonly AchievementsController _achievementsController; //Field offset: 0x18
		private readonly IEftSession _session; //Field offset: 0x20
		private readonly Profile _profile; //Field offset: 0x28
		[CanBeNull]
		private readonly InventoryController _inventoryController; //Field offset: 0x30

		public AchievementsTabController(Profile profile, AchievementsScreen achievementsScreen, AchievementsController achievementsController, InventoryController inventoryController, IEftSession session) { }

		public virtual void Show() { }

	}

	private enum EAchievementListItemType
	{
		Achievement = 0,
		HiddenAchievements = 1,
	}

	private sealed class HiddenAchievementsListItem : AchievementListItem
	{
		public readonly int HiddenAchievementsCount; //Field offset: 0x18

		public HiddenAchievementsListItem(int hiddenAchievementsCount) { }

	}

	[SerializeField]
	private LocalizedText _overallLabelText; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _currentProgressValueText; //Field offset: 0x78
	[SerializeField]
	private Image _progressBar; //Field offset: 0x80
	[SerializeField]
	private TMP_Text _commonAchievementsCountText; //Field offset: 0x88
	[SerializeField]
	private TMP_Text _rareAchievementsCountText; //Field offset: 0x90
	[SerializeField]
	private TMP_Text _legendaryAchievementsCountText; //Field offset: 0x98
	[SerializeField]
	private TMP_Text _seasonalAchievementsCountText; //Field offset: 0xA0
	[SerializeField]
	private AchievementView _achievementViewTemplate; //Field offset: 0xA8
	[SerializeField]
	private HiddenAchievementsSummaryView _hiddenAchievementsViewTemplate; //Field offset: 0xB0
	[SerializeField]
	private GameObject _taskDescriptionTemplate; //Field offset: 0xB8
	[SerializeField]
	private GameObject _taskDescription; //Field offset: 0xC0
	[SerializeField]
	private LightScroller _scroller; //Field offset: 0xC8
	[SerializeField]
	private AchievementsSortPanel _achievementsSortPanel; //Field offset: 0xD0
	[SerializeField]
	private CanvasGroup _allPlayersPercentCanvasGroup; //Field offset: 0xD8
	private AchievementsController _achievementsController; //Field offset: 0xE0
	private IEftSession _session; //Field offset: 0xE8
	public InventoryPlayerModelWithStatsWindow PlayerModelWithStatsWindow; //Field offset: 0xF0

	public AchievementsScreen() { }

	private static BindableList BuildAchievementListItems(List achievements) { }

	public virtual void Close() { }

	private UIElement GetAchievementListItemView(AchievementListItem listItem) { }

	private List GetSortedAchievements(EAchievementsSortType sortType, bool sortAscend) { }

	private void SetupOverallPanel(List achievements) { }

	private void Show(Profile profile, AchievementsController achievementsController, InventoryController inventoryController, IEftSession session) { }

	private void ShowAchievementListItem(AchievementListItem listItem, UIElement view, NotesTaskDescriptionShort description) { }

	private void ShowAchievements(EAchievementsSortType sortType, bool sortAscend) { }

	public void Sort(EAchievementsSortType sortType, bool sortDirection) { }

}

