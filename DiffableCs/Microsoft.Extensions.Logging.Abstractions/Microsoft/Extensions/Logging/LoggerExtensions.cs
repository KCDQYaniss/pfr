namespace Microsoft.Extensions.Logging;

[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class LoggerExtensions
{
	private static readonly Func _messageFormatter; //Field offset: 0x0

	private static LoggerExtensions() { }

	[Extension]
	public static void Log(ILogger logger, LogLevel logLevel, string message, object[] args) { }

	[Extension]
	[NullableContext(2)]
	public static void Log(ILogger logger, LogLevel logLevel, EventId eventId, Exception exception, string message, object[] args) { }

	private static string MessageFormatter(FormattedLogValues state, Exception error) { }

}

