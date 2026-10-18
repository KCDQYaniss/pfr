namespace EFT.Quests;

public class ConditionExitStatusProgressChecker : ConditionProgressChecker
{
	public ConditionExitStatus Condition; //Field offset: 0x50

	public ConditionExitStatusProgressChecker(ConditionExitStatus condition) { }

	public virtual bool Test(object testValue) { }

}

