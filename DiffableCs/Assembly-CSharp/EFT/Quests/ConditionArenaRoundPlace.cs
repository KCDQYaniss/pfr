namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionArenaRoundPlace : Condition, ICanResetConditionProgress
{

	public virtual string FormattedDescription
	{
		 get { } //Length: 324
	}

	public ConditionArenaRoundPlace() { }

	private string GenerateFormattedDescription() { }

	public virtual string get_FormattedDescription() { }

}

