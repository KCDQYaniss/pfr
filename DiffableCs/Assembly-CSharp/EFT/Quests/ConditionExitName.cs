namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionExitName : Condition
{
	public string exitName; //Field offset: 0xE0

	public virtual string FormattedDescription
	{
		 get { } //Length: 413
	}

	private static string LocaleLocalizationKey
	{
		private get { } //Length: 49
	}

	public ConditionExitName() { }

	private string GenerateFormattedDescription() { }

	public virtual string get_FormattedDescription() { }

	private static string get_LocaleLocalizationKey() { }

}

