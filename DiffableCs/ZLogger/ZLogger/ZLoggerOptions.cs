namespace ZLogger;

[Nullable(0)]
[NullableContext(1)]
public class ZLoggerOptions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public Action configure; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal IZLoggerFormatter <UsePlainTextFormatter>b__0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		public static Func <0>__DefaultFormatterFactory; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Action <InternalErrorLogger>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IncludeScopes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[Nullable(2)]
	private TimeProvider <TimeProvider>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private BackgroundBufferFullMode <FullMode>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <BackgroundBufferCapacity>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <IsFormatLogImmediatelyInStandardLog>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <CaptureThreadInfo>k__BackingField; //Field offset: 0x31
	private Func formatterFactory; //Field offset: 0x38

	public int BackgroundBufferCapacity
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool CaptureThreadInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public BackgroundBufferFullMode FullMode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IncludeScopes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Action InternalErrorLogger
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool IsFormatLogImmediatelyInStandardLog
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Nullable(2)]
	public TimeProvider TimeProvider
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 82
	}

	public ZLoggerOptions() { }

	public IZLoggerFormatter CreateFormatter() { }

	private static IZLoggerFormatter DefaultFormatterFactory() { }

	[CompilerGenerated]
	public int get_BackgroundBufferCapacity() { }

	[CompilerGenerated]
	public bool get_CaptureThreadInfo() { }

	[CompilerGenerated]
	public BackgroundBufferFullMode get_FullMode() { }

	[CompilerGenerated]
	public bool get_IncludeScopes() { }

	[CompilerGenerated]
	public Action get_InternalErrorLogger() { }

	[CompilerGenerated]
	public bool get_IsFormatLogImmediatelyInStandardLog() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public TimeProvider get_TimeProvider() { }

	[CompilerGenerated]
	public void set_BackgroundBufferCapacity(int value) { }

	[CompilerGenerated]
	public void set_CaptureThreadInfo(bool value) { }

	[CompilerGenerated]
	public void set_FullMode(BackgroundBufferFullMode value) { }

	[CompilerGenerated]
	public void set_IncludeScopes(bool value) { }

	[CompilerGenerated]
	public void set_InternalErrorLogger(Action value) { }

	[CompilerGenerated]
	public void set_IsFormatLogImmediatelyInStandardLog(bool value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_TimeProvider(TimeProvider value) { }

	public ZLoggerOptions UseFormatter(Func formatterFactory) { }

	public ZLoggerOptions UsePlainTextFormatter(Action configure = null) { }

}

