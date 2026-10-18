namespace ZLogger;

[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class ZLoggerBuilderExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public static Action <>9__0_0; //Field offset: 0x8
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public static Action <>9__3_0; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public static Action <>9__3_1; //Field offset: 0x18
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public static Action <>9__4_0; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2, 1})]
		public static Func <>9__7_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <AddZLoggerConsole>b__0_0(ZLoggerConsoleOptions _, IServiceProvider _) { }

		internal void <AddZLoggerInMemory>b__3_0(ZLoggerOptions _, IServiceProvider _) { }

		internal void <AddZLoggerInMemory>b__3_1(InMemoryObservableLogProcessor _) { }

		internal void <AddZLoggerInMemory>b__4_0(ZLoggerOptions _, IServiceProvider _) { }

		internal InMemoryObservableLogProcessor <AddZLoggerInMemory>b__7_0(IServiceProvider _, object _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Action configure; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal void <AddZLoggerConsole>b__0(ZLoggerConsoleOptions options, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1, 1})]
		public Func logProcessorFactory; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal ZLoggerLogProcessorLoggerProvider <AddZLoggerLogProcessor>b__0(IServiceProvider serviceProvider) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		[Nullable(0)]
		public Stream stream; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal Stream <AddZLoggerStream>b__0(ZLoggerOptions _, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Action configure; //Field offset: 0x10
		[Nullable(0)]
		public Stream stream; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal Stream <AddZLoggerStream>b__0(ZLoggerOptions o, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public Action configure; //Field offset: 0x10
		[Nullable(0)]
		public Stream stream; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal Stream <AddZLoggerStream>b__0(ZLoggerOptions o, IServiceProvider p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1, 1})]
		public Func streamFactory; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal ZLoggerStreamLoggerProvider <AddZLoggerStream>b__0(IServiceProvider serviceProvider) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		[Nullable(0)]
		public string filePath; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal string <AddZLoggerFile>b__0(ZLoggerFileOptions _, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public bool fileShared; //Field offset: 0x10
		[Nullable(0)]
		public string filePath; //Field offset: 0x18

		public <>c__DisplayClass16_0() { }

		internal string <AddZLoggerFile>b__0(ZLoggerFileOptions o, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Action configure; //Field offset: 0x10
		[Nullable(0)]
		public string filePath; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal string <AddZLoggerFile>b__0(ZLoggerFileOptions o, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public Action configure; //Field offset: 0x10
		[Nullable(0)]
		public string filePath; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal string <AddZLoggerFile>b__0(ZLoggerFileOptions o, IServiceProvider p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1, 1})]
		public Func filePathFactory; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal ZLoggerFileLoggerProvider <AddZLoggerFile>b__0(IServiceProvider serviceProvider) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public Action configure; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal ZLoggerConsoleLoggerProvider <AddZLoggerConsole>b__0(IServiceProvider serviceProvider) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Func filePathSelector; //Field offset: 0x10
		public RollingInterval rollInterval; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal void <AddZLoggerRollingFile>b__0(ZLoggerRollingFileOptions o, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Func filePathSelector; //Field offset: 0x10
		public int rollSizeKB; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <AddZLoggerRollingFile>b__0(ZLoggerRollingFileOptions o, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Func filePathSelector; //Field offset: 0x10
		public RollingInterval rollInterval; //Field offset: 0x18
		public int rollSizeKB; //Field offset: 0x1C

		public <>c__DisplayClass22_0() { }

		internal void <AddZLoggerRollingFile>b__0(ZLoggerRollingFileOptions o, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Action configure; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal void <AddZLoggerRollingFile>b__0(ZLoggerRollingFileOptions o, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public Action configure; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal ZLoggerRollingFileLoggerProvider <AddZLoggerRollingFile>b__0(IServiceProvider serviceProvider) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Action configure; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal void <AddZLoggerInMemory>b__0(ZLoggerOptions o, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public Action configure; //Field offset: 0x10
		[Nullable(0)]
		public object processorKey; //Field offset: 0x18
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Action configureProcessor; //Field offset: 0x20

		public <>c__DisplayClass7_0() { }

		internal ZLoggerInMemoryLoggerProvider <AddZLoggerInMemory>b__1(IServiceProvider serviceProvider) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		[Nullable(0)]
		public IAsyncLogProcessor logProcessor; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal IAsyncLogProcessor <AddZLoggerLogProcessor>b__0(ZLoggerOptions _, IServiceProvider _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1})]
		public Func logProcessorFactory; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal IAsyncLogProcessor <AddZLoggerLogProcessor>b__0(ZLoggerOptions o, IServiceProvider _) { }

	}


	[Extension]
	public static ILoggingBuilder AddZLoggerConsole(ILoggingBuilder builder) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerConsole(ILoggingBuilder builder, Action configure) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerConsole(ILoggingBuilder builder, Action configure) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerFile(ILoggingBuilder builder, string filePath, bool fileShared) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerFile(ILoggingBuilder builder, string filePath) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerFile(ILoggingBuilder builder, Func filePathFactory) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerFile(ILoggingBuilder builder, string filePath, Action configure) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerFile(ILoggingBuilder builder, string filePath, Action configure) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerInMemory(ILoggingBuilder builder, object processorKey, Action configure, Action configureProcessor) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerInMemory(ILoggingBuilder builder, Action configure, Action configureProcessor) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerInMemory(ILoggingBuilder builder, Action configureProcessor) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerInMemory(ILoggingBuilder builder) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerInMemory(ILoggingBuilder builder, object processorKey, Action configure, Action configureProcessor) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerLogProcessor(ILoggingBuilder builder, IAsyncLogProcessor logProcessor) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerLogProcessor(ILoggingBuilder builder, Func logProcessorFactory) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerLogProcessor(ILoggingBuilder builder, Func logProcessorFactory) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerRollingFile(ILoggingBuilder builder, Func filePathSelector, RollingInterval rollInterval, int rollSizeKB) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerRollingFile(ILoggingBuilder builder, Func filePathSelector, int rollSizeKB) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerRollingFile(ILoggingBuilder builder, Func filePathSelector, RollingInterval rollInterval) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerRollingFile(ILoggingBuilder builder, Action configure) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerRollingFile(ILoggingBuilder builder, Action configure) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerStream(ILoggingBuilder builder, Stream stream, Action configure) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerStream(ILoggingBuilder builder, Stream stream) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerStream(ILoggingBuilder builder, Func streamFactory) { }

	[Extension]
	public static ILoggingBuilder AddZLoggerStream(ILoggingBuilder builder, Stream stream, Action configure) { }

}

