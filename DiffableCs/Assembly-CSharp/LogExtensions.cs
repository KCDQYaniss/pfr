//Type is in global namespace

[Extension]
public static class LogExtensions
{
	[CompilerGenerated]
	private sealed class <>c__10`1
	{
		public static readonly <>c__10 <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x0

		private static <>c__10`1() { }

		public <>c__10`1() { }

		internal string <GetAllParams>b__10_0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__7`1
	{
		public static readonly <>c__7 <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x0

		private static <>c__7`1() { }

		public <>c__7`1() { }

		internal string <EnumerableToString>b__7_0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0`1
	{
		public Func log; //Field offset: 0x0

		public <>c__DisplayClass8_0`1() { }

		internal string <EnumerableToString>b__0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0`1
	{
		public string elementFormat; //Field offset: 0x0

		public <>c__DisplayClass9_0`1() { }

		internal object <EnumerableToString>b__0(T arg) { }

	}


	[Extension]
	public static string EnumerableToString(IEnumerable list, string separator) { }

	[Extension]
	public static string EnumerableToString(IEnumerable list, string separator, Func log) { }

	[Extension]
	public static string EnumerableToString(IEnumerable list, string separator, string elementFormat) { }

	[Extension]
	public static string GetAllParams(IEnumerable enumerable, string separator = ", ") { }

	[Extension]
	public static T Log_DEBUG(T obj, Func log, LogType logType = 3) { }

	[Extension]
	public static T Log_DEBUG(T obj, string format, Func log, LogType logType = 3) { }

	[Extension]
	public static T Log_DEBUG(T obj, LogType logType = 3) { }

	[Extension]
	public static T Log_DEBUG(T obj, string format, LogType logType = 3) { }

	[Extension]
	public static IEnumerable LogList(IEnumerable list, LogType logType = 3) { }

	[Extension]
	public static IEnumerable LogList(IEnumerable list, string format, LogType logType = 3) { }

	[Extension]
	public static IEnumerable LogList(IEnumerable list, string format, Func log, LogType logType = 3) { }

}

