namespace EFT.Quests;

public sealed class MainQuest : Quest
{
	private QuestChapter _chapter; //Field offset: 0x98
	private readonly QuestBook _questBook; //Field offset: 0xA0

	public QuestChapter Chapter
	{
		 get { } //Length: 630
	}

	public virtual string Name
	{
		 get { } //Length: 90
	}

	public MainQuest(QuestBook questBook, QuestTemplate template, QuestStatusData statusData, Dictionary conditionCounters, bool fromServer, bool inRaid) { }

	public QuestChapter get_Chapter() { }

	public virtual string get_Name() { }

	public virtual bool IsConditionDone(Condition condition) { }

	public void SetIconSprite(Sprite sprite) { }

	public virtual bool TryGetStatusNote(EQuestStatus status, out MongoID noteId) { }

}

