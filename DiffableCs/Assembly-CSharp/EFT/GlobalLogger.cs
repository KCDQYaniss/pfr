namespace EFT;

public sealed class GlobalLogger : AbstractLogger
{

	public GlobalLogger(string name, LogConfiguration config, LogLevel minLogLevel, bool logApplicationMessages) { }

	public GlobalLogger(string name, LogConfiguration config, LogLevel minLogLevel) { }

	public void Log(string sourceLogger, LogLevel logLevel, string message) { }

	protected virtual void ZLogInternal(LogLevel logLevel, string message) { }

}

