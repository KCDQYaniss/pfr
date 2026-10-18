//Type is in global namespace

public abstract class AbstractLogger : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public static Action <>9__30_5; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		[NullableContext(1)]
		internal void <CreateLoggerFactory>b__30_5(IBufferWriter writer, Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public AbstractLogger <>4__this; //Field offset: 0x10
		public TimeSpan localTimeOffset; //Field offset: 0x18
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Func <>9__2; //Field offset: 0x20
		public MessageTemplateFormatter <>9__4; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Action <>9__3; //Field offset: 0x30
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Action <>9__1; //Field offset: 0x38

		public <>c__DisplayClass30_0() { }

		[NullableContext(1)]
		internal void <CreateLoggerFactory>b__0(ILoggingBuilder logging) { }

		[NullableContext(1)]
		internal void <CreateLoggerFactory>b__1(ZLoggerRollingFileOptions options) { }

		[NullableContext(1)]
		internal string <CreateLoggerFactory>b__2(DateTimeOffset _, int sequenceNumber) { }

		[NullableContext(1)]
		internal void <CreateLoggerFactory>b__3(PlainTextZLoggerFormatter formatter) { }

		internal void <CreateLoggerFactory>b__4(in MessageTemplate template, in LogInfo info) { }

	}

	internal enum EState
	{
		None = 0,
		Configured = 1,
		Created = 2,
	}

	private const string UNITY_LOGGER_FILTER = "
EFT.UnityLogger"; //Field offset: 0x0
	private const string NO_FREE_EVENTS_FILTER = "no free events for"; //Field offset: 0x0
	private const string BEHAVIOUR_SCRIPT_FILTER = "The referenced script on this Behaviour"; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsLogsEnabled>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private EState <State>k__BackingField; //Field offset: 0x10
	protected readonly string _name; //Field offset: 0x18
	private readonly bool _logApplicationMessages; //Field offset: 0x20
	private readonly LogLevel _minLogLevel; //Field offset: 0x24
	private readonly LogConfiguration _config; //Field offset: 0x28
	private ILogHandler _unityLogger; //Field offset: 0x30
	private ILoggerFactory _loggerFactory; //Field offset: 0x38
	protected ILogger _zLogger; //Field offset: 0x40

	protected bool Configured
	{
		 get { } //Length: 8
	}

	public static bool IsLogsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		 set { } //Length: 88
	}

	protected private EState State
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static AbstractLogger() { }

	protected AbstractLogger(string loggerName, LogConfiguration config = null, Nullable minLogLevel = null) { }

	protected AbstractLogger(string loggerName, bool logApplicationMessages, LogConfiguration config = null, Nullable minLogLevel = null) { }

	private void CreateLoggerFactory() { }

	public override void Dispose() { }

	protected bool get_Configured() { }

	[CompilerGenerated]
	public static bool get_IsLogsEnabled() { }

	[CompilerGenerated]
	protected EState get_State() { }

	public bool IsEnabled(LogLevel level) { }

	protected void Log(string loggerFormat, string unityFormat, LogLevel logLevel, object[] args) { }

	public void Log(LogEventInfo logEvent) { }

	public override void Log(LogLevel logLevel, string format, object[] args) { }

	private void LogApplicationMessageThreaded(string message, string stackTrace, LogType logType) { }

	public void LogDebug(string format, object[] args) { }

	public void LogError(string format, object[] args) { }

	public string LogErrorFields(object[] args) { }

	public void LogException(Exception e) { }

	protected override void LogFormat(LogType logType, string format, object[] args) { }

	public void LogInfo(string format, object[] args) { }

	public string LogInfoFields(object[] args) { }

	public string LogInfoFieldsWithColor(string color, object[] args) { }

	public void LogInfoWithColor(string color, string format, object[] args) { }

	public void LogTrace(string format, object[] args) { }

	public string LogTraceFields(object[] args) { }

	public void LogWarn(string format, object[] args) { }

	public string LogWarnFields(object[] args) { }

	private static string PrettyLogLevel(LogLevel logLevel) { }

	[CompilerGenerated]
	public static void set_IsLogsEnabled(bool value) { }

	[CompilerGenerated]
	private void set_State(EState value) { }

	private void ZLog(LogLevel logLevel, string format, object[] args) { }

	protected override void ZLogInternal(LogLevel logLevel, string message) { }

}

