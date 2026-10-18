namespace EFT.Quests;

public sealed class QuestNoteTemplate
{
	public readonly MongoID Id; //Field offset: 0x10
	public readonly string ChapterId; //Field offset: 0x28
	public readonly string Locale; //Field offset: 0x30
	public readonly IEnumerable Links; //Field offset: 0x38

	[JsonConstructor]
	private QuestNoteTemplate(MongoID id, string chapterId, QuestNoteLinksData linksData) { }

}

