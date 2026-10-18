namespace EFT;

public struct QuestCondition
{
	public MongoID ConditionId; //Field offset: 0x0
	public EQuestStatus Status; //Field offset: 0x18
	public double Value; //Field offset: 0x20
	public bool Notify; //Field offset: 0x28

	public virtual string ToString() { }

}

