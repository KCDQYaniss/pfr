namespace EFT.Dialogs;

public sealed class TraderReputation : DialogCondition
{
	[CompilerGenerated]
	private MongoID <TraderId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ECompareMethod <CompareMethod>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private double <ReputationValue>k__BackingField; //Field offset: 0x30

	[JsonProperty("Operator")]
	public private ECompareMethod CompareMethod
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("ReputationValue")]
	public private double ReputationValue
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

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

	public TraderReputation(MongoID traderId, ECompareMethod compareMethod, double reputationValue) { }

	public TraderReputation() { }

	[CompilerGenerated]
	public ECompareMethod get_CompareMethod() { }

	[CompilerGenerated]
	public double get_ReputationValue() { }

	[CompilerGenerated]
	public MongoID get_TraderId() { }

	public virtual EDialogConditionType get_Type() { }

	[CompilerGenerated]
	private void set_CompareMethod(ECompareMethod value) { }

	[CompilerGenerated]
	private void set_ReputationValue(double value) { }

	[CompilerGenerated]
	private void set_TraderId(MongoID value) { }

	public virtual bool Test(IDialogContext context) { }

	public virtual string ToString() { }

}

