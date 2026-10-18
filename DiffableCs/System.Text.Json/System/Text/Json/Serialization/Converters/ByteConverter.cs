namespace System.Text.Json.Serialization.Converters;

internal sealed class ByteConverter : JsonPrimitiveConverter
{

	public ByteConverter() { }

	public virtual void Write(Utf8JsonWriter writer, byte value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, byte value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, byte value, JsonNumberHandling handling) { }

}

