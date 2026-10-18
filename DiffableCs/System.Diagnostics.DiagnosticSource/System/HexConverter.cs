namespace System;

internal static class HexConverter
{
	internal enum Casing
	{
		Upper = 0,
		Lower = 8224,
	}


	public static int FromLowerChar(int c) { }

	public static bool IsHexLowerChar(int c) { }

	public static void ToCharsBuffer(byte value, Span buffer, int startingIndex = 0, Casing casing = 0) { }

}

