namespace Dissonance;

public static class Logs
{
	private struct LogMessage
	{
		private readonly LogLevel _level; //Field offset: 0x0
		private readonly string _message; //Field offset: 0x8

		public LogMessage(string message, LogLevel level) { }

		public void Log() { }

	}

	[CompilerGenerated]
	private static bool <Disable>k__BackingField; //Field offset: 0x0
	private static readonly TransferBuffer LogsFromOtherThreads; //Field offset: 0x8
	private static Thread _main; //Field offset: 0x10

	public static bool Disable
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		 set { } //Length: 88
	}

	private static Logs() { }

	[NotNull]
	public static Log Create(LogCategory category, string name) { }

	[NotNull]
	public static Log Create(int category, string name) { }

	[CompilerGenerated]
	public static bool get_Disable() { }

	public static LogLevel GetLogLevel(LogCategory category) { }

	public static LogLevel GetLogLevel(int category) { }

	internal static void SendLogMessage(string message, LogLevel level) { }

	[CompilerGenerated]
	public static void set_Disable(bool value) { }

	public static void SetLogLevel(LogCategory category, LogLevel level) { }

	public static void SetLogLevel(int category, LogLevel level) { }

	internal static void WriteMultithreadedLogs() { }

}

