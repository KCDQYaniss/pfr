namespace EFT.UI.Quests;

public sealed class MainQuestNoteView : UIElement
{
	[SerializeField]
	private CanvasGroup _mainCanvasGroup; //Field offset: 0x70
	[SerializeField]
	private CanvasGroup _unreadWarning; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _text; //Field offset: 0x80
	[SerializeField]
	private MainQuestLinkedItemsListView _itemsView; //Field offset: 0x88
	private QuestNote _note; //Field offset: 0x90
	private Profile _profile; //Field offset: 0x98
	private IChaptersViewController _viewController; //Field offset: 0xA0
	private HoverReadTrigger _hoverReadTrigger; //Field offset: 0xA8
	private bool _isLast; //Field offset: 0xB0

	public MainQuestNoteView() { }

	[CompilerGenerated]
	private void <Show>b__9_0() { }

	private void InitReadTrigger() { }

	private void ReadDataChangeHandler(QuestNote readNote) { }

	private void ReadHandler() { }

	public void SetIsLast(bool isLast) { }

	public void Show(QuestNote note, bool showLinks, bool isLast, IChaptersViewController viewController) { }

	private void ShowLinkedItems() { }

	private void UpdateUnreadWarning() { }

}

