namespace EFT.Dialogs;

public sealed class VariableDataDto
{
	[CompilerGenerated]
	private MongoID <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Value>k__BackingField; //Field offset: 0x28

	[JsonProperty("id")]
	public private MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	[JsonProperty("value")]
	public private int Value
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public VariableDataDto(MongoID id, int value) { }

	[CompilerGenerated]
	public MongoID get_Id() { }

	[CompilerGenerated]
	public int get_Value() { }

	[CompilerGenerated]
	private void set_Id(MongoID value) { }

	[CompilerGenerated]
	private void set_Value(int value) { }

}

