namespace Sirenix.Utilities;

[Extension]
public static class ColorExtensions
{
	private static readonly char[] trimRGBStart; //Field offset: 0x0

	private static ColorExtensions() { }

	[Extension]
	public static Color Lerp(Color[] colors, float t) { }

	[Extension]
	public static Color MoveTowards(Color from, Color to, float maxDelta) { }

	[Extension]
	public static Color NormalizeRGB(Color color) { }

	[Extension]
	public static float PerceivedLuminosity(Color color, bool includeAlpha = true) { }

	[Extension]
	public static Color Pow(Color color, float factor) { }

	[Extension]
	public static string ToCSharpColor(Color color) { }

	private static string TrimFloat(float value) { }

	public static bool TryParseString(string colorStr, out Color color) { }

}

