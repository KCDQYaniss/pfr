namespace ZLogger;

[CompilerFeatureRequired("RefStructs")]
[InterpolatedStringHandler]
[IsByRefLike]
[Nullable(0)]
[NullableContext(1)]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct ZLoggerInterpolatedStringHandler
{
	[Nullable(2)]
	[ThreadStatic]
	private static List literalPool; //Field offset: 0x80000000
	[CompilerGenerated]
	private readonly bool <IsLoggerEnabled>k__BackingField; //Field offset: 0x0
	private readonly int literalLength; //Field offset: 0x4
	private readonly int parametersLength; //Field offset: 0x8
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	private readonly List literals; //Field offset: 0x10
	private readonly InterpolatedStringLogState state; //Field offset: 0x18
	private int parameterWritten; //Field offset: 0x20

	public bool IsLoggerEnabled
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public ZLoggerInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, LogLevel logLevel, out bool enabled) { }

	[NullableContext(2)]
	public void AppendFormatted(T value, int alignment = 0, string format = null, string argumentName = null) { }

	[NullableContext(0)]
	public void AppendFormatted(Nullable value, int alignment = 0, string format = null, string argumentName = null) { }

	public void AppendLiteral(string s) { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_IsLoggerEnabled() { }

	public InterpolatedStringLogState GetState() { }

	public static void PreAllocateEntry(int count) { }

}

