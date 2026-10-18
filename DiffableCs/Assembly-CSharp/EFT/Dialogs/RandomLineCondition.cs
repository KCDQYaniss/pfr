namespace EFT.Dialogs;

public sealed class RandomLineCondition
{
	[CompilerGenerated]
	private MongoID <VariableName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private uint <StartValue>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private uint <EndValue>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private uint <MaxValue>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <GroupId>k__BackingField; //Field offset: 0x34

	[JsonProperty("EndValue")]
	public private uint EndValue
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("GroupId")]
	public private int GroupId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("MaxValue")]
	public private uint MaxValue
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("StartValue")]
	public private uint StartValue
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonProperty("VariableName")]
	public private MongoID VariableName
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public RandomLineCondition(MongoID variableName, uint testValue, uint maxValue, int groupId) { }

	public RandomLineCondition(MongoID variableName, uint startValue, uint endValue, uint maxValue, int groupId) { }

	public RandomLineCondition() { }

	[CompilerGenerated]
	public uint get_EndValue() { }

	[CompilerGenerated]
	public int get_GroupId() { }

	[CompilerGenerated]
	public uint get_MaxValue() { }

	[CompilerGenerated]
	public uint get_StartValue() { }

	[CompilerGenerated]
	public MongoID get_VariableName() { }

	[CompilerGenerated]
	private void set_EndValue(uint value) { }

	[CompilerGenerated]
	private void set_GroupId(int value) { }

	[CompilerGenerated]
	private void set_MaxValue(uint value) { }

	[CompilerGenerated]
	private void set_StartValue(uint value) { }

	[CompilerGenerated]
	private void set_VariableName(MongoID value) { }

	public bool Test(IDialogContext context) { }

	public virtual string ToString() { }

}

