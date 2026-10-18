namespace EFT;

public struct ShowStatNotificationPacket : INestable
{
	public uint LocalizationKey1; //Field offset: 0x0
	public uint LocalizationKey2; //Field offset: 0x4
	public int Value; //Field offset: 0x8
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

