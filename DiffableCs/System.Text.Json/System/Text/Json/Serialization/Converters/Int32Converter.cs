namespace System.Text.Json.Serialization.Converters;

internal sealed class Int32Converter : JsonPrimitiveConverter
{

	public Int32Converter() { }

	public virtual void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, int value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, int value, JsonNumberHandling handling) { }

}

