namespace EFT;

public struct WeaponOverheatPacket : INestable
{
	public string WeaponId; //Field offset: 0x0
	public float LastShotTime; //Field offset: 0x8
	public float LastOverheat; //Field offset: 0xC
	public bool SlideOnOverheatReached; //Field offset: 0x10
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

