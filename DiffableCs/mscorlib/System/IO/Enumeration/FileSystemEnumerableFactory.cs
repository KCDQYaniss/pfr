namespace System.IO.Enumeration;

internal static class FileSystemEnumerableFactory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static FindTransform <>9__3_0; //Field offset: 0x8
		public static FindTransform <>9__4_0; //Field offset: 0x10
		public static FindTransform <>9__5_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal string <UserDirectories>b__4_0(ref FileSystemEntry entry) { }

		internal string <UserEntries>b__5_0(ref FileSystemEntry entry) { }

		internal string <UserFiles>b__3_0(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string expression; //Field offset: 0x10
		public EnumerationOptions options; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal bool <UserFiles>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string expression; //Field offset: 0x10
		public EnumerationOptions options; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal bool <UserDirectories>b__1(ref FileSystemEntry entry) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string expression; //Field offset: 0x10
		public EnumerationOptions options; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal bool <UserEntries>b__1(ref FileSystemEntry entry) { }

	}

	private static readonly char[] s_unixEscapeChars; //Field offset: 0x0

	private static FileSystemEnumerableFactory() { }

	private static bool MatchesPattern(string expression, ReadOnlySpan name, EnumerationOptions options) { }

	internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options) { }

	internal static IEnumerable UserDirectories(string directory, string expression, EnumerationOptions options) { }

	internal static IEnumerable UserEntries(string directory, string expression, EnumerationOptions options) { }

	internal static IEnumerable UserFiles(string directory, string expression, EnumerationOptions options) { }

}

