namespace EFT.Quests;

public sealed class QuestNote
{
	private readonly QuestNoteTemplate _template; //Field offset: 0x10
	private readonly Profile _profile; //Field offset: 0x18
	private Nullable _hasChapter; //Field offset: 0x20

	public MongoID Id
	{
		 get { } //Length: 43
	}

	public IEnumerable LinkedItems
	{
		 get { } //Length: 77
	}

	public IEnumerable Links
	{
		 get { } //Length: 27
	}

	public string Locale
	{
		 get { } //Length: 27
	}

	public QuestNote(QuestNoteTemplate template, Profile profile) { }

	[CompilerGenerated]
	private bool <CheckChapter>b__11_0(QuestStatusData data) { }

	public bool CheckChapter(bool enableWarnings) { }

	public bool FromChapter(QuestChapter chapter) { }

	public MongoID get_Id() { }

	public IEnumerable get_LinkedItems() { }

	public IEnumerable get_Links() { }

	public string get_Locale() { }

}

