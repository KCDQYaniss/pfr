namespace EFT;

public sealed class ExportLog : AbstractLogger
{
	private static Dictionary _stackTraceLogType; //Field offset: 0x0
	private static Dictionary _stackTraceLogTypeDefaults; //Field offset: 0x8
	private readonly string[] excludes; //Field offset: 0x48
	[CompilerGenerated]
	private bool <IsLogStopped>k__BackingField; //Field offset: 0x50

	private bool IsLogStopped
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static ExportLog() { }

	private ExportLog() { }

	public static void Continue() { }

	[CompilerGenerated]
	private bool get_IsLogStopped() { }

	protected virtual void LogFormat(LogType logType, string format, object[] args) { }

	public static void Release() { }

	[CompilerGenerated]
	private void set_IsLogStopped(bool value) { }

	public static void Setup() { }

	public static void Stop() { }

}

