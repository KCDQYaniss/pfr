namespace EFT.Quests;

public sealed class QuestNoteLinksData : QuestNoteLinksDataBase
{

	[JsonConstructor]
	private QuestNoteLinksData(IEnumerable items, IEnumerable offers, IEnumerable crafts) { }

}

