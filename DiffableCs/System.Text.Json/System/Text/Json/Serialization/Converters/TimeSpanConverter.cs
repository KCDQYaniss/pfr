namespace System.Text.Json.Serialization.Converters;

internal sealed class TimeSpanConverter : JsonPrimitiveConverter
{

	public TimeSpanConverter() { }

	public virtual void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

}

