//Type is in global namespace

[Extension]
public static class DigitsToColorExtension
{
	private static readonly Vector3 COLOR_RED_HSV; //Field offset: 0x0
	private static readonly Vector3 COLOR_GREEN_HSV; //Field offset: 0xC

	private static DigitsToColorExtension() { }

	private static double Clamp01(double value) { }

	[Extension]
	private static Color GetColor(double value, double minValue, double maxValue, Vector3 minColorHsv, Vector3 maxColorHsv) { }

	[Extension]
	public static Color GetColor(double value, double minValue, double maxValue) { }

	[Extension]
	public static string GetRichTextColor(Color color) { }

	private static Color HSVToRGB(float h, float s, float v, bool hdr) { }

	private static double InverseLerp(double a, double b, double value) { }

}

