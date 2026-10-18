//Type is in global namespace

public static class CDebug
{
	private const string ORANGE_CHUNK = "orange"; //Field offset: 0x0
	private const string RED_CHUNK = "red"; //Field offset: 0x0
	private const string GREEN_CHUNK = "green"; //Field offset: 0x0
	private const string CHUNK_FORMAT = "[{0}]<color={1}><b>!!!!!!!!!!!!!</b></color> {2}"; //Field offset: 0x0

	[Conditional("UNITY_EDITOR")]
	public static void Log(object message) { }

	[Conditional("UNITY_EDITOR")]
	public static void LogError(object message) { }

	[Conditional("UNITY_EDITOR")]
	public static void LogFormat(string format, object[] args) { }

	[Conditional("UNITY_EDITOR")]
	public static void LogGreen(object message) { }

	[Conditional("UNITY_EDITOR")]
	public static void LogRed(object message) { }

	private static void LogWithFrameNumber(LogType logType, object message, string color) { }

}

