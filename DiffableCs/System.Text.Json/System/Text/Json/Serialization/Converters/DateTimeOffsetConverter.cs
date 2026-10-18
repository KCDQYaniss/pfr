namespace System.Text.Json.Serialization.Converters;

internal sealed class DateTimeOffsetConverter : JsonPrimitiveConverter
{

	public DateTimeOffsetConverter() { }

	public virtual void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

}

