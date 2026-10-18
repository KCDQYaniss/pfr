namespace System.IO;

internal static class PathInternal
{
	private static readonly bool s_isCaseSensitive; //Field offset: 0x0

	internal static bool IsCaseSensitive
	{
		internal get { } //Length: 83
	}

	private static PathInternal() { }

	internal static bool AreRootsEqual(string first, string second, StringComparison comparisonType) { }

	internal static bool EndsInDirectorySeparator(ReadOnlySpan path) { }

	internal static bool EndsWithPeriodOrSpace(string path) { }

	internal static string EnsureExtendedPrefix(string path) { }

	internal static string EnsureExtendedPrefixIfNeeded(string path) { }

	internal static int EqualStartingCharacterCount(string first, string second, bool ignoreCase) { }

	internal static bool get_IsCaseSensitive() { }

	internal static int GetCommonPathLength(string first, string second, bool ignoreCase) { }

	private static bool GetIsCaseSensitive() { }

	internal static int GetRootLength(ReadOnlySpan path) { }

	internal static bool IsDevice(ReadOnlySpan path) { }

	internal static bool IsDeviceUNC(ReadOnlySpan path) { }

	internal static bool IsDirectorySeparator(char c) { }

	internal static bool IsEffectivelyEmpty(ReadOnlySpan path) { }

	internal static bool IsExtended(ReadOnlySpan path) { }

	public static bool IsPartiallyQualified(string path) { }

	internal static bool IsRoot(ReadOnlySpan path) { }

	internal static bool IsValidDriveChar(char value) { }

	internal static bool StartsWithDirectorySeparator(ReadOnlySpan path) { }

	internal static ReadOnlySpan TrimEndingDirectorySeparator(ReadOnlySpan path) { }

	internal static string TrimEndingDirectorySeparator(string path) { }

}

