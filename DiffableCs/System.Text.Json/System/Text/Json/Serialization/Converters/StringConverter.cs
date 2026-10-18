namespace System.Text.Json.Serialization.Converters;

internal sealed class StringConverter : JsonPrimitiveConverter
{

	public StringConverter() { }

	public virtual void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, string value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

}

