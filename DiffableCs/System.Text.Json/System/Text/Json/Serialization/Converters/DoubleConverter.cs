namespace System.Text.Json.Serialization.Converters;

internal sealed class DoubleConverter : JsonPrimitiveConverter
{

	public DoubleConverter() { }

	public virtual void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, double value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, double value, JsonNumberHandling handling) { }

}

