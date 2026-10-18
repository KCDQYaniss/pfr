namespace EFT.Quests;

public sealed class RepeatableQuestTemplate : QuestTemplate
{
	private const string DAILY_QUEST_NAME_PREFIX = "DailyQuestName/"; //Field offset: 0x0
	[CompilerGenerated]
	private int <ExpirationTime>k__BackingField; //Field offset: 0x138

	public int ExpirationTime
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public virtual string NameLocaleKey
	{
		 get { } //Length: 137
	}

	public RepeatableQuestTemplate() { }

	public virtual Quest CreateNewQuest(QuestBook questBook, QuestStatusData statusData, Dictionary conditionCounters, bool fromServer, bool inRaid) { }

	[CompilerGenerated]
	public int get_ExpirationTime() { }

	public virtual string get_NameLocaleKey() { }

	[CompilerGenerated]
	public void set_ExpirationTime(int value) { }

}

