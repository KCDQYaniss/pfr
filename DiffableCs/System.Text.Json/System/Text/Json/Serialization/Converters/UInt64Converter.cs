namespace System.Text.Json.Serialization.Converters;

internal sealed class UInt64Converter : JsonPrimitiveConverter
{

	public UInt64Converter() { }

	public virtual void Write(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, ulong value, JsonNumberHandling handling) { }

}

