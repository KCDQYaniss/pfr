namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionCompletableItem : ConditionOneTarget
{

	public virtual float value
	{
		 get { } //Length: 9
	}

	public ConditionCompletableItem() { }

	public virtual float get_value() { }

}

