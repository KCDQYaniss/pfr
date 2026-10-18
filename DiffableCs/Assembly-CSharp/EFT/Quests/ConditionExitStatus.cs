namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionExitStatus : Condition
{
	public ExitStatus[] status; //Field offset: 0xE0

	public virtual string FormattedDescription
	{
		 get { } //Length: 276
	}

	public ConditionExitStatus() { }

	public virtual string get_FormattedDescription() { }

}

