namespace System.Globalization;

public static class CharUnicodeInfo
{

	private static ReadOnlySpan CategoriesValue
	{
		private get { } //Length: 86
	}

	private static ReadOnlySpan CategoryLevel1Index
	{
		private get { } //Length: 86
	}

	private static ReadOnlySpan CategoryLevel2Index
	{
		private get { } //Length: 86
	}

	private static ReadOnlySpan CategoryLevel3Index
	{
		private get { } //Length: 86
	}

	private static ReadOnlySpan get_CategoriesValue() { }

	private static ReadOnlySpan get_CategoryLevel1Index() { }

	private static ReadOnlySpan get_CategoryLevel2Index() { }

	private static ReadOnlySpan get_CategoryLevel3Index() { }

	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	public static UnicodeCategory GetUnicodeCategory(int codePoint) { }

	internal static int InternalConvertToUtf32(string s, int index) { }

	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	internal static bool IsWhiteSpace(string s, int index) { }

	internal static bool IsWhiteSpace(char c) { }

}

