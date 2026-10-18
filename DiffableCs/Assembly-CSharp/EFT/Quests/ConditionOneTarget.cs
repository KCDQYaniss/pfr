namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public abstract class ConditionOneTarget : Condition
{
	[JsonProperty("target")]
	public string target; //Field offset: 0xE0

	public virtual string FormattedDescription
	{
		 get { } //Length: 206
	}

	protected ConditionOneTarget() { }

	public virtual string get_FormattedDescription() { }

	protected virtual List IdentityFields() { }

}

