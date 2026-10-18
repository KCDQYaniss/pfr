//Type is in global namespace

public static class SearchTextMatcher
{

	private static bool CharsEqual(char left, char right) { }

	public static int IndexOf(string source, string search) { }

	public static int IndexOf(string source, string search, int searchStartIndex, int searchEndIndex) { }

	public static bool IsSeparator(char value) { }

	private static bool MatchNormalized(string source, int sourceIndex, string search, int searchIndex) { }

	private static bool MatchNormalized(string source, int sourceIndex, string search, int searchIndex, int searchEndIndex) { }

	private static int SkipSeparators(string text, int index) { }

	public static bool StartsWith(string source, string search) { }

}

