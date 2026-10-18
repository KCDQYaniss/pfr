namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionBlock : Condition
{

	public virtual float value
	{
		 get { } //Length: 9
	}

	public ConditionBlock() { }

	public virtual float get_value() { }

}

