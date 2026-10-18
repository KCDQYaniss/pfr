//Type is in global namespace

public abstract class LogConfiguration : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__24_0; //Field offset: 0x8
		public static Func <>9__24_1; //Field offset: 0x10
		public static Func <>9__24_2; //Field offset: 0x18
		public static Func <>9__29_0; //Field offset: 0x20
		public static Func <>9__29_1; //Field offset: 0x28
		public static Func <>9__29_2; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__24_0(LoggingRule r) { }

		internal string <.ctor>b__24_1(IGrouping g) { }

		internal LogLevel <.ctor>b__24_2(IGrouping g) { }

		internal bool <ValidateAndFilterRules>b__29_0(LoggingRule rule) { }

		internal string <ValidateAndFilterRules>b__29_1(LoggingRule r) { }

		internal LoggingRule <ValidateAndFilterRules>b__29_2(IGrouping g) { }

	}

	public static readonly string info; //Field offset: 0x0
	public static readonly string baseDir; //Field offset: 0x8
	public static readonly string configPath; //Field offset: 0x10
	public static readonly int maxFileSizeKB; //Field offset: 0x18
	private static readonly object _fileLock; //Field offset: 0x20
	private static DateTime _lastFileWriteTime; //Field offset: 0x28
	private static List _cachedRules; //Field offset: 0x30
	private static readonly Dictionary _cachedLoggingRules; //Field offset: 0x38
	[CompilerGenerated]
	private string <logsDir>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <loggerId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <gameVersion>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private IReadOnlyDictionary <loggingRules>k__BackingField; //Field offset: 0x28
	private readonly ConcurrentBag _disposables; //Field offset: 0x30

	public string gameVersion
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string loggerId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private IReadOnlyDictionary loggingRules
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public string logsDir
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private static LogConfiguration() { }

	protected LogConfiguration(bool ignoreErrors = false) { }

	public void AddDisposable(IDisposable disposable) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public string get_gameVersion() { }

	[CompilerGenerated]
	public string get_loggerId() { }

	[CompilerGenerated]
	public IReadOnlyDictionary get_loggingRules() { }

	[CompilerGenerated]
	public string get_logsDir() { }

	public override void GlobalLog(string sourceLogger, LogLevel logLevel, string message) { }

	public static List LoadRulesFromFile() { }

	private static List LoadRulesWithCache() { }

	[CompilerGenerated]
	protected void set_gameVersion(string value) { }

	[CompilerGenerated]
	protected void set_loggerId(string value) { }

	[CompilerGenerated]
	private void set_loggingRules(IReadOnlyDictionary value) { }

	[CompilerGenerated]
	protected void set_logsDir(string value) { }

	private static List ValidateAndFilterRules(IReadOnlyCollection rules) { }

	public static void WriteRules(IReadOnlyCollection newRules) { }

}

