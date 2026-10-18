//Type is in global namespace

public sealed class MathUtil
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__Floor; //Field offset: 0x0
		public static Func <1>__Ceiling; //Field offset: 0x8
		public static Func <2>__Round; //Field offset: 0x10

	}


	public MathUtil() { }

	public static float Ceil(float value, int decimals = 0) { }

	public static float Floor(float value, int decimals = 0) { }

	public static float Round(float value, int decimals = 0) { }

	private static float Round(float value, int decimals, Func rounder) { }

}

