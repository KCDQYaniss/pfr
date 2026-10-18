namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionArenaMatchPlace : Condition, ICanResetConditionProgress
{

	public virtual string FormattedDescription
	{
		 get { } //Length: 324
	}

	public ConditionArenaMatchPlace() { }

	private string GenerateFormattedDescription() { }

	public virtual string get_FormattedDescription() { }

}

