namespace EFT.Quests;

public class ConditionHealthEffectProgressChecker : ConditionProgressChecker
{
	public ConditionHealthEffect Condition; //Field offset: 0x50

	public ConditionHealthEffectProgressChecker(ConditionHealthEffect condition) { }

	public virtual bool Test(object testValue) { }

}

