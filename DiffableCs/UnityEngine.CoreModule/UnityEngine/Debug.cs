namespace UnityEngine;

[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
public class Debug
{
	internal static readonly ILogger s_DefaultLogger; //Field offset: 0x0
	internal static ILogger s_Logger; //Field offset: 0x8

	public static bool isDebugBuild
	{
		 get { } //Length: 69
	}

	public static ILogger unityLogger
	{
		 get { } //Length: 84
	}

	private static Debug() { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void Assert(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void Assert(bool condition) { }

	[FreeFunction("PauseEditor")]
	public static void Break() { }

	[RequiredByNativeCode]
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	[ExcludeFromDocs]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ExcludeFromDocs]
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunction("DebugDrawLine", IsThreadSafe = True)]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }

	[ExcludeFromDocs]
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }

	[ExcludeFromDocs]
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	[ExcludeFromDocs]
	public static void DrawRay(Vector3 start, Vector3 dir) { }

	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	[ThreadSafe]
	public static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder) { }

	public static bool get_isDebugBuild() { }

	public static ILogger get_unityLogger() { }

	[RequiredByNativeCode]
	internal static bool IsLoggingEnabled() { }

	public static void Log(object message) { }

	public static void Log(object message, Object context) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertion(object message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertionFormat(string format, object[] args) { }

	public static void LogError(object message, Object context) { }

	public static void LogError(object message) { }

	public static void LogErrorFormat(string format, object[] args) { }

	public static void LogErrorFormat(Object context, string format, object[] args) { }

	public static void LogException(Exception exception) { }

	public static void LogException(Exception exception, Object context) { }

	public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, object[] args) { }

	public static void LogFormat(Object context, string format, object[] args) { }

	public static void LogFormat(string format, object[] args) { }

	public static void LogWarning(object message, Object context) { }

	public static void LogWarning(object message) { }

	public static void LogWarningFormat(string format, object[] args) { }

	public static void LogWarningFormat(Object context, string format, object[] args) { }

}

