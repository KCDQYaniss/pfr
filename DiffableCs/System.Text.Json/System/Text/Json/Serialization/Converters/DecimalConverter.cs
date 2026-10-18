namespace System.Text.Json.Serialization.Converters;

internal sealed class DecimalConverter : JsonPrimitiveConverter
{

	public DecimalConverter() { }

	public virtual void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, decimal value, JsonNumberHandling handling) { }

}

