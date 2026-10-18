namespace ZLogger;

[Extension]
[Nullable(0)]
[NullableContext(2)]
public static class ZLoggerExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2, 1})]
		public static Func <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		[NullableContext(1)]
		internal string <ZLog>b__3_0(VersionedLogState state, Exception ex) { }

	}


	[Extension]
	public static void ZLog(ILogger logger, LogLevel logLevel, ref ZLoggerInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLog(ILogger logger, LogLevel logLevel, EventId eventId, ref ZLoggerInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLog(ILogger logger, LogLevel logLevel, Exception exception, ref ZLoggerInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLog(ILogger logger, LogLevel logLevel, EventId eventId, Exception exception, ref ZLoggerInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogCritical(ILogger logger, EventId eventId, ref ZLoggerCriticalInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogCritical(ILogger logger, ref ZLoggerCriticalInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogCritical(ILogger logger, Exception exception, ref ZLoggerCriticalInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogCritical(ILogger logger, EventId eventId, Exception exception, ref ZLoggerCriticalInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogDebug(ILogger logger, ref ZLoggerDebugInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogDebug(ILogger logger, EventId eventId, ref ZLoggerDebugInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogDebug(ILogger logger, Exception exception, ref ZLoggerDebugInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogDebug(ILogger logger, EventId eventId, Exception exception, ref ZLoggerDebugInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogError(ILogger logger, EventId eventId, Exception exception, ref ZLoggerErrorInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogError(ILogger logger, Exception exception, ref ZLoggerErrorInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogError(ILogger logger, EventId eventId, ref ZLoggerErrorInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogError(ILogger logger, ref ZLoggerErrorInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogInformation(ILogger logger, EventId eventId, ref ZLoggerInformationInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogInformation(ILogger logger, EventId eventId, Exception exception, ref ZLoggerInformationInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogInformation(ILogger logger, Exception exception, ref ZLoggerInformationInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogInformation(ILogger logger, ref ZLoggerInformationInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogTrace(ILogger logger, EventId eventId, Exception exception, ref ZLoggerTraceInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogTrace(ILogger logger, Exception exception, ref ZLoggerTraceInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogTrace(ILogger logger, EventId eventId, ref ZLoggerTraceInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogTrace(ILogger logger, ref ZLoggerTraceInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogWarning(ILogger logger, Exception exception, ref ZLoggerWarningInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogWarning(ILogger logger, EventId eventId, Exception exception, ref ZLoggerWarningInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogWarning(ILogger logger, ref ZLoggerWarningInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

	[Extension]
	public static void ZLogWarning(ILogger logger, EventId eventId, ref ZLoggerWarningInterpolatedStringHandler message, object context = null, string memberName = null, string filePath = null, int lineNumber = 0) { }

}

