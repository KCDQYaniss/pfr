namespace EFT.Dialogs;

public sealed class VariableValueCondition : DialogCondition
{
	[CompilerGenerated]
	private MongoID <Variable>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Value>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ECompareMethod <Comparator>k__BackingField; //Field offset: 0x2C

	[JsonProperty("operator")]
	public private ECompareMethod Comparator
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public virtual EDialogConditionType Type
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

	public VariableValueCondition(MongoID variable, int value, ECompareMethod comparator = 1) { }

	public VariableValueCondition() { }

	[CompilerGenerated]
	public ECompareMethod get_Comparator() { }

	public virtual EDialogConditionType get_Type() { }

	[CompilerGenerated]
	public int get_Value() { }

	[CompilerGenerated]
	public MongoID get_Variable() { }

	[CompilerGenerated]
	private void set_Comparator(ECompareMethod value) { }

	[CompilerGenerated]
	private void set_Value(int value) { }

	[CompilerGenerated]
	private void set_Variable(MongoID value) { }

	public virtual bool Test(IDialogContext context) { }

	public virtual string ToString() { }

}

