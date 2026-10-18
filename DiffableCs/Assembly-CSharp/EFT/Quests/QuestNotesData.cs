namespace EFT.Quests;

public sealed class QuestNotesData : IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__19_0; //Field offset: 0x8
		public static Func <>9__19_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal MongoID <ToDescriptor>b__19_0(KeyValuePair kvp) { }

		internal bool <ToDescriptor>b__19_1(KeyValuePair kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public MongoID noteId; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <HasNote>b__0(QuestNote note) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public MongoID noteId; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <GetNoteTemplate>b__0(QuestNoteTemplate noteTemplate) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public QuestNoteTemplate noteTemplate; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <TryGetNote>b__0(QuestNote note) { }

	}

	[CompilerGenerated]
	private Action OnNoteAdded; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnNoteRead; //Field offset: 0x18
	private readonly Dictionary _notesList; //Field offset: 0x20
	private readonly Profile _profile; //Field offset: 0x28

	public event Action OnNoteAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnNoteRead
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public IEnumerable NotesList
	{
		 get { } //Length: 73
	}

	public QuestNotesData(IReadOnlyDictionary data, Profile profile) { }

	[CompilerGenerated]
	public void add_OnNoteAdded(Action value) { }

	[CompilerGenerated]
	public void add_OnNoteRead(Action value) { }

	public QuestNote AddNote(QuestNoteTemplate noteTemplate) { }

	public IEnumerable get_NotesList() { }

	public override IEnumerator GetEnumerator() { }

	private QuestNoteTemplate GetNoteTemplate(MongoID noteId) { }

	public bool HasNote(MongoID noteId) { }

	public bool HasNote(QuestNoteTemplate noteTemplate) { }

	public bool IsRead(QuestNote note) { }

	public void ReadNote(QuestNote note) { }

	[CompilerGenerated]
	public void remove_OnNoteAdded(Action value) { }

	[CompilerGenerated]
	public void remove_OnNoteRead(Action value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public Dictionary ToDescriptor() { }

	public bool TryGetNote(QuestNoteTemplate noteTemplate, out QuestNote note) { }

	public bool TryGetNoteTemplate(MongoID noteId, out QuestNoteTemplate noteTemplate) { }

}

