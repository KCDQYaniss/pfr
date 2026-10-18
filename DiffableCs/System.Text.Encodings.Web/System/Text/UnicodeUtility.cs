namespace System.Text;

internal static class UnicodeUtility
{

	public static int GetUtf16SequenceLength(uint value) { }

	public static void GetUtf16SurrogatesFromSupplementaryPlaneScalar(uint value, out char highSurrogateCodePoint, out char lowSurrogateCodePoint) { }

	public static bool IsAsciiCodePoint(uint value) { }

	public static bool IsBmpCodePoint(uint value) { }

	public static bool IsInRangeInclusive(uint value, uint lowerBound, uint upperBound) { }

	public static bool IsSurrogateCodePoint(uint value) { }

	public static bool IsValidUnicodeScalar(uint value) { }

}

