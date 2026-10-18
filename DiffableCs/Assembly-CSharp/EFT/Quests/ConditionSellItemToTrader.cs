namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionSellItemToTrader : ConditionMultipleTargets
{
	[JsonProperty("traderId")]
	public string trader; //Field offset: 0xE8

	public virtual string FormattedDescription
	{
		 get { } //Length: 105
	}

	public ConditionSellItemToTrader() { }

	public virtual string get_FormattedDescription() { }

	protected virtual List IdentityFields() { }

}

