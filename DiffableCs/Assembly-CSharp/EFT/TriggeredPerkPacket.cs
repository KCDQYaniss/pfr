namespace EFT;

public struct TriggeredPerkPacket : INestable
{
	public MongoID PerkId; //Field offset: 0x0
	[CompilerGenerated]
	private INestable <Nested>k__BackingField; //Field offset: 0x18

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

