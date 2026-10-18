namespace EFT.Quests;

public interface IConditional
{

	public CompletedConditionsCollection CompletedConditions
	{
		 get { } //Length: 0
	}

	public ConditionCounterManager ConditionCountersManager
	{
		 get { } //Length: 0
	}

	public ConditionsDict Conditions
	{
		 get { } //Length: 0
	}

	public EQuestStatus[] CurrentStatusTransitions
	{
		 get { } //Length: 0
	}

	public string Id
	{
		 get { } //Length: 0
	}

	public bool InstantComplete
	{
		 get { } //Length: 0
	}

	public ETaskPlayerSide PlayerSide
	{
		 get { } //Length: 0
	}

	public Dictionary ProgressCheckers
	{
		 get { } //Length: 0
	}

	public EQuestStatus QuestStatus
	{
		 get { } //Length: 0
	}

	public void CheckForStatusChange(bool fromServer, bool canFail, bool notify = true) { }

	public bool CheckVisibilityStatus(Condition condition) { }

	public void DisconnectConditions() { }

	public CompletedConditionsCollection get_CompletedConditions() { }

	public ConditionCounterManager get_ConditionCountersManager() { }

	public ConditionsDict get_Conditions() { }

	public EQuestStatus[] get_CurrentStatusTransitions() { }

	public string get_Id() { }

	public bool get_InstantComplete() { }

	public ETaskPlayerSide get_PlayerSide() { }

	public Dictionary get_ProgressCheckers() { }

	public EQuestStatus get_QuestStatus() { }

	public Condition GetCondition(MongoID conditionId) { }

	public Condition GetVisibilityCondition(MongoID conditionId) { }

	public bool IsConditionDone(Condition condition) { }

	public bool IsDone() { }

	public void SetStatus(EQuestStatus status, bool notify, bool fromServer) { }

}

