namespace System.Text.Json.Serialization.Converters;

internal sealed class DateTimeConverter : JsonPrimitiveConverter
{

	public DateTimeConverter() { }

	public virtual void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

}

