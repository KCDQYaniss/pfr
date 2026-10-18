namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionArenaDeathCount : Condition, ICanResetConditionProgress
{

	public virtual string FormattedDescription
	{
		 get { } //Length: 18
	}

	public ConditionArenaDeathCount() { }

	private string GenerateFormattedDescription() { }

	public virtual string get_FormattedDescription() { }

}

