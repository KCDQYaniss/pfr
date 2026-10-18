namespace ZLogger.Internal;

[Nullable(0)]
[NullableContext(1)]
public static class CodeGeneratorUtil
{
	[Nullable(2)]
	[ThreadStatic]
	private static Utf8JsonWriter utf8JsonWriter; //Field offset: 0x80000000

	public static void AppendAsJson(ref Utf8StringWriter stringWriter, T value) { }

	public static void AppendAsJson(ref Utf8StringWriter stringWriter, object value, Type inputType) { }

	private static Utf8JsonWriter GetThreadStaticUtf8JsonWriter(IBufferWriter bufferWriter) { }

	public static void ThrowArgumentOutOfRangeException() { }

	public static void WriteJsonEnum(Utf8JsonWriter writer, JsonEncodedText key, T value) { }

}

