namespace EFT.Quests;

public interface IQuestObject
{

	public string ConditionId
	{
		 get { } //Length: 0
	}

	public string Id
	{
		 get { } //Length: 0
	}

	public int NetworkId
	{
		 get { } //Length: 0
	}

	public string QuestTemplateId
	{
		 get { } //Length: 0
	}

	public string get_ConditionId() { }

	public string get_Id() { }

	public int get_NetworkId() { }

	public string get_QuestTemplateId() { }

	public void SetQuestObjectActiveState(bool state) { }

}

