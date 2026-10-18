namespace EFT.UI.Quests;

public sealed class MainQuestUnreadWarning : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public QuestController questController; //Field offset: 0x10
		public MainQuestUnreadWarning <>4__this; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public MainQuest mainQuest; //Field offset: 0x10
		public MainQuestUnreadWarning <>4__this; //Field offset: 0x18

		public <>c__DisplayClass33_0() { }

		internal void <AddQuestHandlers>b__0() { }

		internal void <AddQuestHandlers>g__ConditionChangeHandler|1(Quest _) { }

	}

	[Flags]
	internal enum EUnreadWarningType
	{
		Conditions = 1,
		Notes = 2,
		NoteLinks = 4,
		History = 6,
		All = 7,
	}

	[SerializeField]
	private List _hidableObjects; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _counterField; //Field offset: 0x78
	private readonly HashSet _quests; //Field offset: 0x80
	private readonly HashSet _noteIds; //Field offset: 0x88
	private readonly HashSet _readIds; //Field offset: 0x90
	private readonly List _trackedNotes; //Field offset: 0x98
	private bool _trackConditions; //Field offset: 0xA0
	private bool _trackNotes; //Field offset: 0xA1
	private bool _trackLinks; //Field offset: 0xA2
	private QuestNotesData _notes; //Field offset: 0xA8
	private IBindableList _readData; //Field offset: 0xB0
	private string _format; //Field offset: 0xB8
	private bool _trackDependencies; //Field offset: 0xC0
	[CanBeNull]
	private QuestChapter _chapter; //Field offset: 0xC8
	[CanBeNull]
	private IReadOnlyList _chapterQuestIds; //Field offset: 0xD0
	private int _lastUnreadCounter; //Field offset: 0xD8
	private Nullable _lastActiveState; //Field offset: 0xDC
	private bool _suppressUpdate; //Field offset: 0xDE
	private bool _updateRequested; //Field offset: 0xDF
	private int _updateRequestedFrame; //Field offset: 0xE0

	public MainQuestUnreadWarning() { }

	private void AddQuestHandlers(IConditional conditional) { }

	public virtual void Close() { }

	private void NoteAddHandler(QuestNote note) { }

	private void NoteReadHandler(QuestNote note) { }

	private void ReadDataAllItemsRemovedHandler() { }

	private void ReadDataItemAddedHandler(MongoID dataId) { }

	private void ReadDataItemRemovedHandler(MongoID dataId) { }

	private void ReadDataItemsAddedHandler(IEnumerable dataIds) { }

	private void ReadDataItemsRemovedHandler(IEnumerable dataIds) { }

	private void RequestUpdateState() { }

	private void SetVisibility(bool visible) { }

	public void Show(QuestController questController, EUnreadWarningType type, QuestChapter chapter = null, string format = "0") { }

	private bool TrackNote(QuestNote note) { }

	private void Update() { }

	private void UpdateStateImmediate() { }

}

