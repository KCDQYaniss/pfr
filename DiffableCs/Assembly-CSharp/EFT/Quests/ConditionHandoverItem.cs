namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionHandoverItem : ConditionItem, IConditionHandoverItem
{
	private enum ETagHandoverTypes
	{
		Item = 0,
		OnlyFoundInRaid = 1,
		Durability = 2,
		DurabilityStrict = 3,
		IsEncoded = 4,
	}


	public virtual string FormattedDescription
	{
		 get { } //Length: 980
	}

	private string LocalizationActionKey
	{
		private get { } //Length: 49
	}

	public ConditionHandoverItem() { }

	private string GenerateDescription() { }

	public virtual string get_FormattedDescription() { }

	private string get_LocalizationActionKey() { }

}

