namespace System.IO.Enumeration;

public static class FileSystemName
{
	private static readonly char[] s_wildcardChars; //Field offset: 0x0
	private static readonly char[] s_simpleWildcardChars; //Field offset: 0x8

	private static FileSystemName() { }

	public static bool MatchesSimpleExpression(ReadOnlySpan expression, ReadOnlySpan name, bool ignoreCase = true) { }

	public static bool MatchesWin32Expression(ReadOnlySpan expression, ReadOnlySpan name, bool ignoreCase = true) { }

	private static bool MatchPattern(ReadOnlySpan expression, ReadOnlySpan name, bool ignoreCase, bool useExtendedWildcards) { }

	public static string TranslateWin32Expression(string expression) { }

}

