namespace EFT;

public struct KeyUsagePacket : INestable
{
	public string ItemId; //Field offset: 0x0
	public int NumberOfUsages; //Field offset: 0x8
	public bool Removed; //Field offset: 0xC
	[CompilerGenerated]
	private INestable <Nested>k__BackingField; //Field offset: 0x10

	public override INestable Nested
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[CompilerGenerated]
	[IsReadOnly]
	public override INestable get_Nested() { }

	[CompilerGenerated]
	public override void set_Nested(INestable value) { }

}

