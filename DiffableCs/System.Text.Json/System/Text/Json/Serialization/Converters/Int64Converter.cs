namespace System.Text.Json.Serialization.Converters;

internal sealed class Int64Converter : JsonPrimitiveConverter
{

	public Int64Converter() { }

	public virtual void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, long value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, long value, JsonNumberHandling handling) { }

}

