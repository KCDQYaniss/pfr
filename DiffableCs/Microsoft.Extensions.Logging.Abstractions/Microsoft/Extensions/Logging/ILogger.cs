namespace Microsoft.Extensions.Logging;

[NullableContext(1)]
public interface ILogger
{

	public bool IsEnabled(LogLevel logLevel) { }

	[NullableContext(2)]
	public void Log(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func formatter) { }

}

