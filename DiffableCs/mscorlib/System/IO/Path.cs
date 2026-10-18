namespace System.IO;

[ComVisible(True)]
public static class Path
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"First", "FirstLength", "Second", "SecondLength", "HasSeparator"})]
		public static SpanAction <>9__59_0; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"First", "FirstLength", "Second", "SecondLength", "Third", "ThirdLength", "FirstHasSeparator", "ThirdHasSeparator", null})]
		public static SpanAction <>9__60_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <JoinInternal>b__59_0(Span destination, ValueTuple state) { }

		internal void <JoinInternal>b__60_0(Span destination, ValueTuple state) { }

	}

	[Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
	public static readonly char[] InvalidPathChars; //Field offset: 0x0
	public static readonly char AltDirectorySeparatorChar; //Field offset: 0x8
	public static readonly char DirectorySeparatorChar; //Field offset: 0xA
	public static readonly char PathSeparator; //Field offset: 0xC
	internal static readonly string DirectorySeparatorStr; //Field offset: 0x10
	public static readonly char VolumeSeparatorChar; //Field offset: 0x18
	internal static readonly char[] PathSeparatorChars; //Field offset: 0x20
	private static readonly bool dirEqualsVolume; //Field offset: 0x28
	internal static readonly char[] trimEndCharsWindows; //Field offset: 0x30
	internal static readonly char[] trimEndCharsUnix; //Field offset: 0x38

	internal static bool IsCaseSensitive
	{
		internal get { } //Length: 109
	}

	private static bool IsWindows
	{
		private get { } //Length: 54
	}

	internal static StringComparison StringComparison
	{
		internal get { } //Length: 169
	}

	private static Path() { }

	private static string CanonicalizePath(string path) { }

	public static string ChangeExtension(string path, string extension) { }

	internal static string CleanPath(string s) { }

	public static string Combine(string path1, string path2) { }

	public static string Combine(string path1, string path2, string path3, string path4) { }

	public static string Combine(string path1, string path2, string path3) { }

	public static string Combine(string[] paths) { }

	private static int findExtension(string path) { }

	internal static bool get_IsCaseSensitive() { }

	private static bool get_IsWindows() { }

	internal static StringComparison get_StringComparison() { }

	private static string get_temp_path() { }

	public static string GetDirectoryName(string path) { }

	public static ReadOnlySpan GetDirectoryName(ReadOnlySpan path) { }

	public static string GetExtension(string path) { }

	public static string GetFileName(string path) { }

	public static ReadOnlySpan GetFileName(ReadOnlySpan path) { }

	public static string GetFileNameWithoutExtension(string path) { }

	public static string GetFullPath(string path) { }

	internal static string GetFullPathInternal(string path) { }

	internal static string GetFullPathName(string path) { }

	private static int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull) { }

	public static char[] GetInvalidFileNameChars() { }

	public static char[] GetInvalidPathChars() { }

	public static string GetPathRoot(string path) { }

	private static string GetRelativePath(string relativeTo, string path, StringComparison comparisonType) { }

	public static string GetRelativePath(string relativeTo, string path) { }

	private static string GetServerAndShare(string path) { }

	public static string GetTempPath() { }

	internal static string InsecureGetFullPath(string path) { }

	internal static bool IsDirectorySeparator(char c) { }

	public static bool IsPathRooted(string path) { }

	public static bool IsPathRooted(ReadOnlySpan path) { }

	public static string Join(ReadOnlySpan path1, ReadOnlySpan path2) { }

	public static string Join(ReadOnlySpan path1, ReadOnlySpan path2, ReadOnlySpan path3) { }

	private static string JoinInternal(ReadOnlySpan first, ReadOnlySpan second) { }

	private static string JoinInternal(ReadOnlySpan first, ReadOnlySpan second, ReadOnlySpan third) { }

	private static bool SameRoot(string root, string path) { }

	internal static string WindowsDriveAdjustment(string path) { }

}

