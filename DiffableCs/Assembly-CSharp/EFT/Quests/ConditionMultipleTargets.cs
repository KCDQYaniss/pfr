namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public abstract class ConditionMultipleTargets : Condition
{
	public string[] target; //Field offset: 0xE0

	protected ConditionMultipleTargets() { }

	protected virtual List IdentityFields() { }

}

