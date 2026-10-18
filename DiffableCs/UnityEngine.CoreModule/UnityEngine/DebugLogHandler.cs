namespace UnityEngine;

[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
internal sealed class DebugLogHandler : ILogHandler
{

	public DebugLogHandler() { }

	[ThreadAndSerializationSafe]
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafe]
	internal static void Internal_LogException(Exception ex, Object obj) { }

	public override void LogException(Exception exception, Object context) { }

	public override void LogFormat(LogType logType, Object context, string format, object[] args) { }

	public void LogFormat(LogType logType, LogOption logOptions, Object context, string format, object[] args) { }

}

