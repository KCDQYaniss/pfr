namespace System.Text.Json.Serialization.Converters;

internal sealed class UInt16Converter : JsonPrimitiveConverter
{

	public UInt16Converter() { }

	public virtual void Write(Utf8JsonWriter writer, ushort value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, ushort value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, ushort value, JsonNumberHandling handling) { }

}

