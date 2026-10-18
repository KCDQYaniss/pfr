namespace EFT.Dialogs;

public sealed class BackendDialogVariableConditionData : BackendDialogNodeConditionData
{
	[CompilerGenerated]
	private MongoID <Variable>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <Value>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private ECompareMethod <CompareMethod>k__BackingField; //Field offset: 0x44

	[JsonProperty("operator")]
	public private ECompareMethod CompareMethod
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public virtual EConditionType Type
	{
		 get { } //Length: 3
	}

	[JsonProperty("value")]
	public private int Value
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("variableId")]
	public private MongoID Variable
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public BackendDialogVariableConditionData() { }

	[CompilerGenerated]
	public ECompareMethod get_CompareMethod() { }

	public virtual EConditionType get_Type() { }

	[CompilerGenerated]
	public int get_Value() { }

	[CompilerGenerated]
	public MongoID get_Variable() { }

	[CompilerGenerated]
	private void set_CompareMethod(ECompareMethod value) { }

	[CompilerGenerated]
	private void set_Value(int value) { }

	[CompilerGenerated]
	private void set_Variable(MongoID value) { }

	public virtual DialogCondition ToDialogCondition() { }

}

