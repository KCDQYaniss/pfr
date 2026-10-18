namespace EFT.UI.Quests;

public sealed class MainQuestChapterListView : UIElement
{
	private const int VIEWS_DEFAULT_CAPACITY = 10; //Field offset: 0x0
	[SerializeField]
	private RectTransform _container; //Field offset: 0x70
	[SerializeField]
	private MainQuestChapterIconView _iconTemplate; //Field offset: 0x78
	private readonly Dictionary _chaptersById; //Field offset: 0x80
	private UiElementPool _pool; //Field offset: 0x88
	private IChaptersViewController _viewController; //Field offset: 0x90
	private QuestController _questController; //Field offset: 0x98

	public MainQuestChapterListView() { }

	[CompilerGenerated]
	private void <Show>b__7_0() { }

	[CompilerGenerated]
	private void <Show>b__7_1() { }

	[CompilerGenerated]
	private void <Show>g__QuestChangeHandler|7_2(Conditional quest) { }

	public void Show(IChaptersViewController viewController) { }

	private void UpdateChapters() { }

}

