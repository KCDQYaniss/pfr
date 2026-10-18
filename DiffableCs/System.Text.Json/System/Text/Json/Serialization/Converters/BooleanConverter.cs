namespace System.Text.Json.Serialization.Converters;

internal sealed class BooleanConverter : JsonPrimitiveConverter
{

	public BooleanConverter() { }

	public virtual void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, bool value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

}

