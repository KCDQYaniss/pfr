namespace EFT.Quests;

public class ConditionInZoneProgressChecker : ConditionProgressChecker
{
	public ConditionInZone Condition; //Field offset: 0x50

	public ConditionInZoneProgressChecker(ConditionInZone condition) { }

	public virtual bool Test(object testValue) { }

}

