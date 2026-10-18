namespace System.Text.Json.Serialization.Converters;

internal sealed class EnumConverter`1 : JsonPrimitiveConverter
{
	private static readonly TypeCode s_enumTypeCode; //Field offset: 0x0
	private static readonly bool s_isSignedEnum; //Field offset: 0x0
	private readonly EnumConverterOptions _converterOptions; //Field offset: 0x0
	private readonly JsonNamingPolicy _namingPolicy; //Field offset: 0x0
	private readonly ConcurrentDictionary _nameCacheForWriting; //Field offset: 0x0
	private readonly ConcurrentDictionary _nameCacheForReading; //Field offset: 0x0

	private static EnumConverter`1() { }

	public EnumConverter`1(EnumConverterOptions converterOptions, JsonSerializerOptions serializerOptions) { }

	public EnumConverter`1(EnumConverterOptions converterOptions, JsonNamingPolicy namingPolicy, JsonSerializerOptions serializerOptions) { }

	public virtual bool CanConvert(Type type) { }

	private static ulong ConvertToUInt64(object value) { }

	private static string FormatJsonName(string value, JsonNamingPolicy namingPolicy) { }

	private static bool IsValidIdentifier(string value) { }

	private static string[] SplitFlagsEnum(string value) { }

	public virtual void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, T value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

}

