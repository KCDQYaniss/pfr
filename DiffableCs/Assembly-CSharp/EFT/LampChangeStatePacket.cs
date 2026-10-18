namespace EFT;

public struct LampChangeStatePacket : INestable
{
	public int NetId; //Field offset: 0x0
	public EState State; //Field offset: 0x4
	[CompilerGenerated]
	private INestable <Nested>k__BackingField; //Field offset: 0x8

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

