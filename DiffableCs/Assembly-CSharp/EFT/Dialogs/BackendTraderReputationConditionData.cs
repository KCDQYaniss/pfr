namespace EFT.Dialogs;

public sealed class BackendTraderReputationConditionData : BackendDialogNodeConditionData
{
	[CompilerGenerated]
	private MongoID <TraderId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ECompareMethod <CompareMethod>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private float <Value>k__BackingField; //Field offset: 0x44

	[JsonProperty("operator")]
	public private ECompareMethod CompareMethod
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("traderId")]
	public private MongoID TraderId
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public virtual EConditionType Type
	{
		 get { } //Length: 6
	}

	[JsonProperty("reputationValue")]
	public private float Value
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public BackendTraderReputationConditionData() { }

	[CompilerGenerated]
	public ECompareMethod get_CompareMethod() { }

	[CompilerGenerated]
	public MongoID get_TraderId() { }

	public virtual EConditionType get_Type() { }

	[CompilerGenerated]
	public float get_Value() { }

	[CompilerGenerated]
	private void set_CompareMethod(ECompareMethod value) { }

	[CompilerGenerated]
	private void set_TraderId(MongoID value) { }

	[CompilerGenerated]
	private void set_Value(float value) { }

	public virtual DialogCondition ToDialogCondition() { }

}

