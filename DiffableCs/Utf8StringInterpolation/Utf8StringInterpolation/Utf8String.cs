namespace Utf8StringInterpolation;

[Nullable(0)]
[NullableContext(1)]
public static class Utf8String
{

	public static byte[] Concat(string[] values) { }

	public static void Concat(TBufferWriter bufferWriter, string[] values) { }

	public static byte[] Concat(IEnumerable values) { }

	public static void Concat(TBufferWriter bufferWriter, IEnumerable values) { }

	public static Utf8StringWriter CreateWriter(TBufferWriter bufferWriter, IFormatProvider formatProvider = null) { }

	[NullableContext(2)]
	public static Utf8StringBuffer CreateWriter(out Utf8StringWriter stringWriter, IFormatProvider formatProvider = null) { }

	public static byte[] Format(ref Utf8StringWriter format) { }

	public static void Format(TBufferWriter bufferWriter, ref Utf8StringWriter format) { }

	public static byte[] Join(string separator, string[] values) { }

	public static void Join(TBufferWriter bufferWriter, string separator, string[] values) { }

	public static byte[] Join(string separator, IEnumerable values) { }

	public static void Join(TBufferWriter bufferWriter, string separator, IEnumerable values) { }

	[NullableContext(0)]
	public static bool TryFormat(Span destination, out int bytesWritten, ref Utf8StringWriter format) { }

}

