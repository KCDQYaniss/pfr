namespace EFT.Quests;

public class ConditionExitNameProgressChecker : ConditionProgressChecker
{
	public ConditionExitName Condition; //Field offset: 0x50

	public ConditionExitNameProgressChecker(ConditionExitName condition) { }

	public virtual bool Test(object testValue) { }

}

