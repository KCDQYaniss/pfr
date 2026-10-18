namespace FilesChecker;

[Extension]
internal static class Extensions
{

	[Extension]
	public static string AppendIfNotExist(string str, string appendix) { }

	public static string GetExecutablePath() { }

	private static uint GetModuleFileName(IntPtr hModule, StringBuilder lpFilename, int nSize) { }

	[Extension]
	public static TimeSpan StopWatch(Stopwatch stopwatch) { }

}

