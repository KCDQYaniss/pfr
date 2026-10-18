namespace EFT;

[Extension]
internal static class UrlsExtension
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8
		public static Func <>9__2_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <PrepareUrls>b__2_0(string url) { }

		internal string <PrepareUrls>b__2_1(string url) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public string url; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal string <Concat>b__0(string u) { }

	}


	[Extension]
	internal static string[] Concat(IEnumerable urls, string url) { }

	[Extension]
	internal static string FixUrlEnding(string url) { }

	internal static string[] PrepareUrls(string backendUrl, string[] alternativeUrls) { }

	internal static string[] RandomizeUrls(string[] urls, int count = 3) { }

}

