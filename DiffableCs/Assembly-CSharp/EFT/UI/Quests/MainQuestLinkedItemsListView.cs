namespace EFT.UI.Quests;

public sealed class MainQuestLinkedItemsListView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Profile profile; //Field offset: 0x10
		public IChaptersViewController viewController; //Field offset: 0x18
		public MainQuestLinkedItemsListView <>4__this; //Field offset: 0x20
		public QuestChapter chapter; //Field offset: 0x28

		public <>c__DisplayClass5_0() { }

		internal void <Show>b__0() { }

		internal void <Show>g__NoteAddedHandler|2(QuestNote note) { }

		internal void <Show>g__QuestChangeHandler|3(Conditional quest) { }

		internal void <Show>g__SelectChapterHandler|1(QuestChapter _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public MainQuestLinkedItemView itemView; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private RectTransform _itemsContainer; //Field offset: 0x70
	[SerializeField]
	private MainQuestLinkedItemView _itemViewTemplate; //Field offset: 0x78
	[SerializeField]
	private GameObject _parentPanel; //Field offset: 0x80
	private readonly List _linkedItems; //Field offset: 0x88

	public MainQuestLinkedItemsListView() { }

	public void Show(QuestNote note, IChaptersViewController viewController) { }

	public void Show(IChaptersViewController viewController) { }

	private void Show(IEnumerable linkedItems, IChaptersViewController viewController) { }

}

