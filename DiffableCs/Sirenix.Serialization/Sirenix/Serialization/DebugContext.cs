namespace Sirenix.Serialization;

public sealed class DebugContext
{
	private readonly object LOCK; //Field offset: 0x10
	private ILogger logger; //Field offset: 0x18
	private LoggingPolicy loggingPolicy; //Field offset: 0x20
	private ErrorHandlingPolicy errorHandlingPolicy; //Field offset: 0x24

	public ErrorHandlingPolicy ErrorHandlingPolicy
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public ILogger Logger
	{
		 get { } //Length: 445
		 set { } //Length: 340
	}

	public LoggingPolicy LoggingPolicy
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public DebugContext() { }

	public ErrorHandlingPolicy get_ErrorHandlingPolicy() { }

	public ILogger get_Logger() { }

	public LoggingPolicy get_LoggingPolicy() { }

	public void LogError(string message) { }

	public void LogException(Exception exception) { }

	public void LogWarning(string message) { }

	public void ResetToDefault() { }

	public void set_ErrorHandlingPolicy(ErrorHandlingPolicy value) { }

	public void set_Logger(ILogger value) { }

	public void set_LoggingPolicy(LoggingPolicy value) { }

}

