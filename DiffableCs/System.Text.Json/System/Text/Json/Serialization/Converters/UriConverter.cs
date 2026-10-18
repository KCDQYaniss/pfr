namespace System.Text.Json.Serialization.Converters;

internal sealed class UriConverter : JsonPrimitiveConverter
{

	public UriConverter() { }

	public virtual void Write(Utf8JsonWriter writer, Uri value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, Uri value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

}

