namespace EFT.UI.Quests;

public sealed class MainQuestChapterIconView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public QuestController questController; //Field offset: 0x10
		public MainQuestChapterIconView <>4__this; //Field offset: 0x18
		public QuestChapter chapter; //Field offset: 0x20

		public <>c__DisplayClass10_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

		internal void <Show>g__QuestChangeHandler|4(Conditional quest) { }

		internal void <Show>g__SelectionHandler|3(QuestChapter _) { }

	}

	[SerializeField]
	private Image _chapterIcon; //Field offset: 0x70
	[SerializeField]
	private MainQuestUnreadWarning _unreadWarning; //Field offset: 0x78
	[SerializeField]
	private GameObject _selectionObject; //Field offset: 0x80
	[SerializeField]
	private Dictionary _statusObjects; //Field offset: 0x88
	[SerializeField]
	private Dictionary _statusObjectsSelected; //Field offset: 0x90
	[SerializeField]
	private Dictionary _statusIcons; //Field offset: 0x98
	[SerializeField]
	private Button _button; //Field offset: 0xA0
	[SerializeField]
	private HoverTrigger _buttonHoverTrigger; //Field offset: 0xA8
	private QuestChapter _chapter; //Field offset: 0xB0
	private IChaptersViewController _viewController; //Field offset: 0xB8

	public MainQuestChapterIconView() { }

	[CompilerGenerated]
	internal static void <Show>g__PlayHoverSound|10_6(PointerEventData eventData) { }

	[CompilerGenerated]
	internal static void <Show>g__PlaySound|10_5(EUISoundType soundType) { }

	private void ActivateObjects(Nullable currentStatus, Dictionary objects) { }

	public void Show(QuestChapter chapter, IChaptersViewController viewController) { }

	private Task ShowIcon(QuestChapter chapter, IImageLoader loader) { }

	private void UpdateSelection(QuestChapter chapter, IChaptersViewController chaptersView) { }

	private void UpdateStatus(QuestChapter chapter, bool selected) { }

}

