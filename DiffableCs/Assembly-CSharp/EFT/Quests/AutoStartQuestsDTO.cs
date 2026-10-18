namespace EFT.Quests;

public class AutoStartQuestsDTO
{
	[JsonProperty("quests")]
	public QuestTemplate[] templates; //Field offset: 0x10
	[JsonProperty("deletedQuestItems")]
	public MongoID[] deletedQuestItems; //Field offset: 0x18

	public AutoStartQuestsDTO() { }

}

