namespace EFT.Quests;

public abstract class QuestNoteLinksDataBase
{
	public readonly IEnumerable Items; //Field offset: 0x10

	protected QuestNoteLinksDataBase(IEnumerable[] links) { }

}

