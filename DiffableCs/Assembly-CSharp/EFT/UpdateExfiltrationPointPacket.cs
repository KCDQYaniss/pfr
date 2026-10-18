namespace EFT;

public struct UpdateExfiltrationPointPacket : INestable
{
	public string PointName; //Field offset: 0x0
	public EExfiltrationStatus Command; //Field offset: 0x8
	public List QueuedPlayers; //Field offset: 0x10
	public bool ItemTransferred; //Field offset: 0x18
	[CompilerGenerated]
	private INestable <Nested>k__BackingField; //Field offset: 0x20

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

