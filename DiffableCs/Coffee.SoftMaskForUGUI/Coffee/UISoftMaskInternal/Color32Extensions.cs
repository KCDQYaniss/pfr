namespace Coffee.UISoftMaskInternal;

[Extension]
internal static class Color32Extensions
{
	private static readonly List s_Colors; //Field offset: 0x0
	private static byte[] s_LinearToGammaLut; //Field offset: 0x8
	private static byte[] s_GammaToLinearLut; //Field offset: 0x10

	private static Color32Extensions() { }

	[Extension]
	public static byte GammaToLinear(byte self) { }

	[Extension]
	public static void GammaToLinear(Mesh self) { }

	[Extension]
	public static byte LinearToGamma(byte self) { }

	[Extension]
	public static void LinearToGamma(Mesh self) { }

}

