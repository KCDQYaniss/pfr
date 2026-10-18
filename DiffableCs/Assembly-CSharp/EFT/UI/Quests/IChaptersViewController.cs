namespace EFT.UI.Quests;

public interface IChaptersViewController
{
	public const double READ_ALL_DELAY_SEC = 4; //Field offset: 0x0

	public IImageLoader ImageLoader
	{
		 get { } //Length: 0
	}

	public ItemController ItemController
	{
		 get { } //Length: 0
	}

	public IBindableEvent OnChapterSelected
	{
		 get { } //Length: 0
	}

	public Profile Profile
	{
		 get { } //Length: 0
	}

	public QuestController QuestController
	{
		 get { } //Length: 0
	}

	public InventoryScreenController ScreenController
	{
		 get { } //Length: 0
	}

	public QuestChapter SelectedChapter
	{
		 get { } //Length: 0
	}

	public bool ShowUnread
	{
		 get { } //Length: 0
	}

	public ItemContext SourceContext
	{
		 get { } //Length: 0
	}

	public void DialogStartHandler(DialogStartData dialogStartData) { }

	public IImageLoader get_ImageLoader() { }

	public ItemController get_ItemController() { }

	public IBindableEvent get_OnChapterSelected() { }

	public Profile get_Profile() { }

	public QuestController get_QuestController() { }

	public InventoryScreenController get_ScreenController() { }

	public QuestChapter get_SelectedChapter() { }

	public bool get_ShowUnread() { }

	public ItemContext get_SourceContext() { }

	public bool IsConditionRead(Condition condition) { }

	public bool IsLinkedItemRead(QuestNoteLinkItemBase linkedItem) { }

	public bool IsQuestNoteRead(QuestNote note) { }

	public void ReadChapterConditions(QuestChapter chapter, EChapterConditionType type) { }

	public void ReadQuestNote(QuestNote note) { }

	public void ReadQuestNoteLink(QuestNoteLinkItemBase link) { }

	public void SelectChapter(QuestChapter chapter) { }

}

