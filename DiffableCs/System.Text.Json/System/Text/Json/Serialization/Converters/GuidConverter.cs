namespace System.Text.Json.Serialization.Converters;

internal sealed class GuidConverter : JsonPrimitiveConverter
{

	public GuidConverter() { }

	public virtual void Write(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

}

