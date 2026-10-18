namespace System.Text.Json.Serialization.Converters;

internal sealed class SingleConverter : JsonPrimitiveConverter
{

	public SingleConverter() { }

	public virtual void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, float value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, float value, JsonNumberHandling handling) { }

}

