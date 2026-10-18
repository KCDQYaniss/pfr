namespace EFT;

public struct ConditionValueChangedPacket : INestable
{
	public ConditionalProgressData ProgressData; //Field offset: 0x0
	[CompilerGenerated]
	private INestable <Nested>k__BackingField; //Field offset: 0x50

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

	public virtual string ToString() { }

}

