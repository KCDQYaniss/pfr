namespace Microsoft.Extensions.Logging;

[DebuggerDisplay("{DebuggerToString(),nq}")]
public class Logger`1 : ILogger, ILogger
{
	[DebuggerBrowsable(DebuggerBrowsableState::RootHidden (3))]
	private readonly ILogger _logger; //Field offset: 0x0

	[NullableContext(1)]
	public Logger`1(ILoggerFactory factory) { }

	private static string GetCategoryName() { }

	private override bool Microsoft.Extensions.Logging.ILogger.IsEnabled(LogLevel logLevel) { }

	private override void Microsoft.Extensions.Logging.ILogger.Log(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func formatter) { }

}

