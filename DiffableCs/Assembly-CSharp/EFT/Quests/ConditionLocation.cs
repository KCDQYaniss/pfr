namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionLocation : Condition
{
	public string[] target; //Field offset: 0xE0

	private static string AnyLocaleLocalizationKey
	{
		private get { } //Length: 49
	}

	public virtual string FormattedDescription
	{
		 get { } //Length: 395
	}

	private static string LocaleLocalizationKey
	{
		private get { } //Length: 49
	}

	public ConditionLocation() { }

	private string GenerateFormattedDescription() { }

	private static string get_AnyLocaleLocalizationKey() { }

	public virtual string get_FormattedDescription() { }

	private static string get_LocaleLocalizationKey() { }

}

