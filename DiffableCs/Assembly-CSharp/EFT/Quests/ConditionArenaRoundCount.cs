namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionArenaRoundCount : Condition, ICanResetConditionProgress
{

	public virtual string FormattedDescription
	{
		 get { } //Length: 18
	}

	public ConditionArenaRoundCount() { }

	private string GenerateFormattedDescription() { }

	public virtual string get_FormattedDescription() { }

}

