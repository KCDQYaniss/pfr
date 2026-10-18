namespace EFT.Quests;

public class ConditionHealthBuffProgressChecker : ConditionProgressChecker
{
	public ConditionHealthBuff Condition; //Field offset: 0x50

	public ConditionHealthBuffProgressChecker(ConditionHealthBuff condition) { }

	public virtual bool Test(object testValue) { }

}

