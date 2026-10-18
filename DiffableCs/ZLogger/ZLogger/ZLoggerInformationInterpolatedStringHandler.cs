namespace ZLogger;

[CompilerFeatureRequired("RefStructs")]
[InterpolatedStringHandler]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct ZLoggerInformationInterpolatedStringHandler
{
	public ZLoggerInterpolatedStringHandler InnerHandler; //Field offset: 0x0

	[NullableContext(1)]
	public ZLoggerInformationInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool enabled) { }

	[NullableContext(2)]
	public void AppendFormatted(T value, int alignment = 0, string format = null, string argumentName = null) { }

	public void AppendFormatted(Nullable value, int alignment = 0, string format = null, string argumentName = null) { }

	[NullableContext(2)]
	public void AppendFormatted(ValueTuple namedValue, int alignment = 0, string format = null, string _ = null) { }

	[NullableContext(1)]
	public void AppendLiteral(string s) { }

}

