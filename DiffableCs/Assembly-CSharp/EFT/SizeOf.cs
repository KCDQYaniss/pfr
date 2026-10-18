namespace EFT;

public sealed class SizeOf : ISerializableMessage
{
	[CompilerGenerated]
	private string <Size>k__BackingField; //Field offset: 0x10

	public private string Size
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public SizeOf() { }

	public SizeOf(string Size) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public string get_Size() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	private void set_Size(string value) { }

}

