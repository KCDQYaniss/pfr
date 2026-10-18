namespace System.Text.Json.Serialization.Converters;

internal sealed class VersionConverter : JsonPrimitiveConverter
{

	public VersionConverter() { }

	public virtual void Write(Utf8JsonWriter writer, Version value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, Version value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

}

