namespace Microsoft.Extensions.Logging;

[DebuggerDisplay("{DebuggerToString(),nq}")]
[DebuggerTypeProxy(typeof(LoggerDebugView))]
internal sealed class Logger : ILogger
{
	private sealed class LoggerDebugView
	{

	}

	private readonly string _categoryName; //Field offset: 0x10
	[CompilerGenerated]
	private LoggerInformation[] <Loggers>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private MessageLogger[] <MessageLoggers>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ScopeLogger[] <ScopeLoggers>k__BackingField; //Field offset: 0x28

	public LoggerInformation[] Loggers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MessageLogger[] MessageLoggers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ScopeLogger[] ScopeLoggers
	{
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Logger(string categoryName, LoggerInformation[] loggers) { }

	[CompilerGenerated]
	internal static bool <IsEnabled>g__LoggerIsEnabled|15_0(LogLevel logLevel, ILogger logger, ref List exceptions) { }

	[CompilerGenerated]
	internal static void <Log>g__LoggerLog|14_0(LogLevel logLevel, EventId eventId, ILogger logger, Exception exception, Func formatter, ref List exceptions, in TState state) { }

	[CompilerGenerated]
	public LoggerInformation[] get_Loggers() { }

	[CompilerGenerated]
	public MessageLogger[] get_MessageLoggers() { }

	public override bool IsEnabled(LogLevel logLevel) { }

	public override void Log(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func formatter) { }

	[CompilerGenerated]
	public void set_Loggers(LoggerInformation[] value) { }

	[CompilerGenerated]
	public void set_MessageLoggers(MessageLogger[] value) { }

	[CompilerGenerated]
	public void set_ScopeLoggers(ScopeLogger[] value) { }

	private static void ThrowLoggingError(List exceptions) { }

}

