namespace Utf8StringInterpolation;

[Extension]
[Nullable(0)]
[NullableContext(2)]
internal static class Shims
{

	[Extension]
	public static bool TryFormat(char value, Span utf8Destination, out int bytesWritten, string format, IFormatProvider formatProvider) { }

	[Extension]
	public static bool TryFormat(DateTime value, Span utf8Destination, out int bytesWritten, string format, IFormatProvider formatProvider) { }

	[Extension]
	public static bool TryFormat(DateTimeOffset value, Span utf8Destination, out int bytesWritten, string format, IFormatProvider formatProvider) { }

	[Extension]
	public static bool TryFormat(TimeSpan value, Span utf8Destination, out int bytesWritten, string format, IFormatProvider formatProvider) { }

}

