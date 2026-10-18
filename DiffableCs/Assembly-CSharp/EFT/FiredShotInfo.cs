namespace EFT;

public struct FiredShotInfo : INestable
{
	[CompilerGenerated]
	private static class <>O
	{
		public static SerializeDelegate <0>__Serialize; //Field offset: 0x0
		public static DeserializeDelegate <1>__Deserialize; //Field offset: 0x8

	}

	private static readonly Vector3Quantizer DIRECTION_QUANTIZER; //Field offset: 0x0
	private static readonly Vector3Quantizer FIREPORT_DELTA_QUANTIZER; //Field offset: 0x8
	public bool IsPrimaryActive; //Field offset: 0x0
	public int AmmoAfterShot; //Field offset: 0x4
	public EShotType EShotType; //Field offset: 0x8
	public Vector3 ShotPosition; //Field offset: 0xC
	public Vector3 ShotDirection; //Field offset: 0x18
	public Vector3 FireportPosition; //Field offset: 0x24
	public int ChamberIndex; //Field offset: 0x30
	public float Overheat; //Field offset: 0x34
	public bool UnderbarrelShot; //Field offset: 0x38
	[CompilerGenerated]
	private INestable <Nested>k__BackingField; //Field offset: 0x40

	public override INestable Nested
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private static FiredShotInfo() { }

	public static Nullable Deserialize(IBitReaderStream reader) { }

	[CompilerGenerated]
	[IsReadOnly]
	public override INestable get_Nested() { }

	public static void Serialize(IBitWriterStream writer, ref Nullable packet) { }

	[CompilerGenerated]
	public override void set_Nested(INestable value) { }

	public virtual string ToString() { }

}

