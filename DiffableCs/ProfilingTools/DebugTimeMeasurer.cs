//Type is in global namespace

public static class DebugTimeMeasurer
{
	internal struct Token : IDisposable
	{
		private string _counterName; //Field offset: 0x0

		public Token(string counterName) { }

		public override void Dispose() { }

	}

	private static ValueChangeMeasurer _measurer; //Field offset: 0x0
	private static Stopwatch _stopwatch; //Field offset: 0x8
	private static Counter _currentCounter; //Field offset: 0x10
	private static Action _printDelegate; //Field offset: 0x18

	private static DebugTimeMeasurer() { }

	[Conditional("UNITY_EDITOR")]
	[Conditional("ENABLE_DEBUG_TIME_MEASURER")]
	public static void Clear() { }

	[Conditional("UNITY_EDITOR")]
	[Conditional("ENABLE_DEBUG_TIME_MEASURER")]
	public static void Finish(string name) { }

	public static string GetReport(string title, bool fullName = true) { }

	[Conditional("ENABLE_DEBUG_TIME_MEASURER")]
	[Conditional("UNITY_EDITOR")]
	public static void PrintReport(string title, bool fullName = true) { }

	[Conditional("ENABLE_DEBUG_TIME_MEASURER")]
	[Conditional("UNITY_EDITOR")]
	public static void SetPrintDelegate(Action printDelegate) { }

	[Conditional("UNITY_EDITOR")]
	[Conditional("ENABLE_DEBUG_TIME_MEASURER")]
	public static void Start(string name) { }

	public static Token StartWithToken(string name) { }

}

