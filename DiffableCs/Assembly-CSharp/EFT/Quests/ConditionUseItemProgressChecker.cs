namespace EFT.Quests;

public class ConditionUseItemProgressChecker : ConditionProgressChecker
{
	public ConditionUseItem Condition; //Field offset: 0x50

	public ConditionUseItemProgressChecker(ConditionUseItem condition) { }

	public virtual bool Test(object testValue) { }

}

