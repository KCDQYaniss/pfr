namespace EFT.Dialogs;

public sealed class CurrentTraderCondition : DialogCondition
{
	[CompilerGenerated]
	private MongoID <TraderId>k__BackingField; //Field offset: 0x10

	[JsonProperty("traderId")]
	public private MongoID TraderId
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public virtual EDialogConditionType Type
	{
		 get { } //Length: 6
	}

	public CurrentTraderCondition() { }

	public CurrentTraderCondition(MongoID traderId) { }

	[CompilerGenerated]
	public MongoID get_TraderId() { }

	public virtual EDialogConditionType get_Type() { }

	[CompilerGenerated]
	private void set_TraderId(MongoID value) { }

	public virtual bool Test(IDialogContext context) { }

}

