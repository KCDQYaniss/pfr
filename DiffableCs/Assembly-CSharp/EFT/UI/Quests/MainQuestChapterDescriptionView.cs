namespace EFT.UI.Quests;

public sealed class MainQuestChapterDescriptionView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public QuestController quests; //Field offset: 0x10
		public QuestChapter chapter; //Field offset: 0x18
		public MainQuestChapterDescriptionView <>4__this; //Field offset: 0x20

		public <>c__DisplayClass3_0() { }

		internal void <Show>b__0() { }

		internal void <Show>g__QuestChangeHandler|1(Conditional quest) { }

	}

	[SerializeField]
	private Image _image; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _nameField; //Field offset: 0x78
	[SerializeField]
	private Dictionary _statusObjects; //Field offset: 0x80

	public MainQuestChapterDescriptionView() { }

	public void Show(IChaptersViewController viewController) { }

	private Task UpdateImage(QuestChapter chapter, IImageLoader loader) { }

	private void UpdateStatus(QuestChapter chapter) { }

}

