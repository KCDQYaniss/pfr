namespace EFT.Dialogs;

public sealed class HasNewQuestsCondition : DialogCondition
{
	[CompilerGenerated]
	private bool <Value>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private MongoID <TraderId>k__BackingField; //Field offset: 0x18

	[JsonProperty("TraderId")]
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

	[JsonProperty("Value")]
	public private bool Value
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public HasNewQuestsCondition(MongoID traderId, bool value) { }

	public HasNewQuestsCondition() { }

	[CompilerGenerated]
	public MongoID get_TraderId() { }

	public virtual EDialogConditionType get_Type() { }

	[CompilerGenerated]
	public bool get_Value() { }

	[CompilerGenerated]
	private void set_TraderId(MongoID value) { }

	[CompilerGenerated]
	private void set_Value(bool value) { }

	public virtual bool Test(IDialogContext context) { }

	public virtual string ToString() { }

}

