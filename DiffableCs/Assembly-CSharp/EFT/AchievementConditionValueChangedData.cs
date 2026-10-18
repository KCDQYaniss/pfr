namespace EFT;

public struct AchievementConditionValueChangedData
{
	public int QuestId; //Field offset: 0x0
	public EQuestStatus Status; //Field offset: 0x4
	public MongoID ConditionId; //Field offset: 0x8
	public double Value; //Field offset: 0x20
	public bool Notify; //Field offset: 0x28

	public AchievementConditionValueChangedData(int questId, EQuestStatus status, MongoID conditionId, double value, bool notify) { }

}

