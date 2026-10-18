namespace EFT.Quests;

public class ConditionLocationTriggerChecker : ConditionProgressChecker
{
	public ConditionLocationTrigger Condition; //Field offset: 0x50

	public ConditionLocationTriggerChecker(ConditionLocationTrigger condition) { }

	public virtual bool Test(object testValue) { }

}

