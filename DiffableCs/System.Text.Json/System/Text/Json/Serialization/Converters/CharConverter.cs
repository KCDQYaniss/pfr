namespace System.Text.Json.Serialization.Converters;

internal sealed class CharConverter : JsonPrimitiveConverter
{

	public CharConverter() { }

	public virtual void Write(Utf8JsonWriter writer, char value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, char value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

}

