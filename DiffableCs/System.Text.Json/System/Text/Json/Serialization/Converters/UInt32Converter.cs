namespace System.Text.Json.Serialization.Converters;

internal sealed class UInt32Converter : JsonPrimitiveConverter
{

	public UInt32Converter() { }

	public virtual void Write(Utf8JsonWriter writer, uint value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, uint value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, uint value, JsonNumberHandling handling) { }

}

