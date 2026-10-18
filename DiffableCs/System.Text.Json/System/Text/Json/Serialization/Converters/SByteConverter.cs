namespace System.Text.Json.Serialization.Converters;

internal sealed class SByteConverter : JsonPrimitiveConverter
{

	public SByteConverter() { }

	public virtual void Write(Utf8JsonWriter writer, sbyte value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, sbyte value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, sbyte value, JsonNumberHandling handling) { }

}

