namespace EFT.UI.Quests;

public sealed class MainQuestTabView : UIElement, IChaptersViewController
{
	[SerializeField]
	private MainQuestChapterListView _chaptersListView; //Field offset: 0x70
	[SerializeField]
	private MainQuestChapterDescriptionView _chapterDescriptionView; //Field offset: 0x78
	[SerializeField]
	private MainQuestLinkedItemsListView _linkedItemsView; //Field offset: 0x80
	[SerializeField]
	private MainQuestNotesListView _historyView; //Field offset: 0x88
	[SerializeField]
	private MainQuestNoteView _shortHistoryView; //Field offset: 0x90
	[SerializeField]
	private MainQuestUnreadWarning _unreadHistoryWarning; //Field offset: 0x98
	[SerializeField]
	private Button _expandHistoryButton; //Field offset: 0xA0
	[SerializeField]
	private MainQuestChapterTasksView _tasksView; //Field offset: 0xA8
	[SerializeField]
	private GameObject _noTasksWarning; //Field offset: 0xB0
	[SerializeField]
	private Button _expandTasksButton; //Field offset: 0xB8
	[SerializeField]
	private List _objectsToActivate; //Field offset: 0xC0
	private readonly BindableEvent _onChapterSelected; //Field offset: 0xC8
	private QuestChapter _selectedChapter; //Field offset: 0xD0
	private QuestController _questController; //Field offset: 0xD8
	private InventoryController _inventoryController; //Field offset: 0xE0
	private Profile _profile; //Field offset: 0xE8
	private IImageLoader _imageLoader; //Field offset: 0xF0
	private bool _showUnread; //Field offset: 0xF8
	private ItemContext _sourceContext; //Field offset: 0x100
	private bool _showFullHistory; //Field offset: 0x108
	private bool _showExpandedTasks; //Field offset: 0x109
	private Nullable _showChapterTime; //Field offset: 0x110
	private InventoryScreenController _screenController; //Field offset: 0x120

	private override IImageLoader EFT.UI.Quests.IChaptersViewController.ImageLoader
	{
		private get { } //Length: 8
	}

	private override ItemController EFT.UI.Quests.IChaptersViewController.ItemController
	{
		private get { } //Length: 8
	}

	private override IBindableEvent EFT.UI.Quests.IChaptersViewController.OnChapterSelected
	{
		private get { } //Length: 8
	}

	private override Profile EFT.UI.Quests.IChaptersViewController.Profile
	{
		private get { } //Length: 8
	}

	private override QuestController EFT.UI.Quests.IChaptersViewController.QuestController
	{
		private get { } //Length: 8
	}

	private override InventoryScreenController EFT.UI.Quests.IChaptersViewController.ScreenController
	{
		private get { } //Length: 8
	}

	private override QuestChapter EFT.UI.Quests.IChaptersViewController.SelectedChapter
	{
		private get { } //Length: 8
	}

	private override bool EFT.UI.Quests.IChaptersViewController.ShowUnread
	{
		private get { } //Length: 8
	}

	private override ItemContext EFT.UI.Quests.IChaptersViewController.SourceContext
	{
		private get { } //Length: 8
	}

	public MainQuestTabView() { }

	[CompilerGenerated]
	private void <Show>b__37_0() { }

	public override void DialogStartHandler(DialogStartData dialogStartData) { }

	private override IImageLoader EFT.UI.Quests.IChaptersViewController.get_ImageLoader() { }

	private override ItemController EFT.UI.Quests.IChaptersViewController.get_ItemController() { }

	private override IBindableEvent EFT.UI.Quests.IChaptersViewController.get_OnChapterSelected() { }

	private override Profile EFT.UI.Quests.IChaptersViewController.get_Profile() { }

	private override QuestController EFT.UI.Quests.IChaptersViewController.get_QuestController() { }

	private override InventoryScreenController EFT.UI.Quests.IChaptersViewController.get_ScreenController() { }

	private override QuestChapter EFT.UI.Quests.IChaptersViewController.get_SelectedChapter() { }

	private override bool EFT.UI.Quests.IChaptersViewController.get_ShowUnread() { }

	private override ItemContext EFT.UI.Quests.IChaptersViewController.get_SourceContext() { }

	private override bool EFT.UI.Quests.IChaptersViewController.IsConditionRead(Condition condition) { }

	private override void EFT.UI.Quests.IChaptersViewController.ReadChapterConditions(QuestChapter chapter, EChapterConditionType type) { }

	private override void EFT.UI.Quests.IChaptersViewController.SelectChapter(QuestChapter chapter) { }

	private void ExpandHistoryHandler() { }

	private void ExpandTasksHandler() { }

	public override bool IsLinkedItemRead(QuestNoteLinkItemBase linkedItem) { }

	public override bool IsQuestNoteRead(QuestNote note) { }

	private void ReadAllNotesHandler() { }

	public override void ReadQuestNote(QuestNote note) { }

	public override void ReadQuestNoteLink(QuestNoteLinkItemBase link) { }

	private void SelectChapter(QuestChapter chapter) { }

	private void SelectFirstChapter() { }

	public void Show(QuestController questController, InventoryController itemController, IImageLoader imageLoader, bool showUnread, InventoryScreenController screenController, ItemContext sourceContext) { }

	private void ShowHistory() { }

	private void TryReadAll() { }

}

