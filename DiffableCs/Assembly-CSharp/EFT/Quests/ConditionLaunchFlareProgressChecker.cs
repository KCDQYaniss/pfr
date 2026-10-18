namespace EFT.Quests;

public sealed class ConditionLaunchFlareProgressChecker : ConditionProgressChecker
{
	public ConditionLaunchFlare Condition; //Field offset: 0x50

	public ConditionLaunchFlareProgressChecker(ConditionLaunchFlare condition) { }

	public virtual bool Test(object testValue) { }

}

