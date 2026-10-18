namespace EFT;

public static class SerializationContext
{
	[CompilerGenerated]
	private static Vector3Quantizer <UsualPositionQuantizer>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static Vector3Quantizer <PrecisePositionQuantizer>k__BackingField; //Field offset: 0x8

	public private static Vector3Quantizer PrecisePositionQuantizer
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 151
	}

	public private static Vector3Quantizer UsualPositionQuantizer
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 151
	}

	[CompilerGenerated]
	public static Vector3Quantizer get_PrecisePositionQuantizer() { }

	[CompilerGenerated]
	public static Vector3Quantizer get_UsualPositionQuantizer() { }

	[CompilerGenerated]
	private static void set_PrecisePositionQuantizer(Vector3Quantizer value) { }

	[CompilerGenerated]
	private static void set_UsualPositionQuantizer(Vector3Quantizer value) { }

	public static void SetupPositionQuantizer(Bounds levelBounds) { }

}

