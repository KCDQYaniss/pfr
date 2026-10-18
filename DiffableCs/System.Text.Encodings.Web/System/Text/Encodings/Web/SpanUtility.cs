namespace System.Text.Encodings.Web;

internal static class SpanUtility
{

	private static bool AreValidIndexAndLength(int spanRealLength, int requestedOffset, int requestedLength) { }

	public static bool IsValidIndex(ReadOnlySpan span, int index) { }

	public static bool IsValidIndex(Span span, int index) { }

	public static bool TryWriteUInt64LittleEndian(Span span, int offset, ulong value) { }

}

