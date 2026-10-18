namespace System.Text.Json.Serialization.Converters;

internal sealed class Int16Converter : JsonPrimitiveConverter
{

	public Int16Converter() { }

	public virtual void Write(Utf8JsonWriter writer, short value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, short value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, short value, JsonNumberHandling handling) { }

}

