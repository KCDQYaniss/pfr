namespace EFT.UI.Quests;

public sealed class MainQuestNotesListView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public QuestNotesData questNotes; //Field offset: 0x10
		public MainQuestNotesListView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

	}

	[SerializeField]
	private RectTransform _container; //Field offset: 0x70
	[SerializeField]
	private MainQuestNoteView _noteViewTemplate; //Field offset: 0x78
	[SerializeField]
	private ScrollRectNoDrag _scroll; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnReadAll; //Field offset: 0x88
	private IChaptersViewController _viewController; //Field offset: 0x90
	private Nullable _showChapterTime; //Field offset: 0x98
	private MainQuestNoteView _lastNoteView; //Field offset: 0xA8
	private UiElementPool _pool; //Field offset: 0xB0

	public event Action OnReadAll
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public MainQuestNotesListView() { }

	[CompilerGenerated]
	public void add_OnReadAll(Action value) { }

	private void AddNote(QuestNote note, bool isLast) { }

	private void NoteAddedHandler(QuestNote note) { }

	[CompilerGenerated]
	public void remove_OnReadAll(Action value) { }

	public void Show(IChaptersViewController viewController) { }

	private void TryReadAll() { }

}

