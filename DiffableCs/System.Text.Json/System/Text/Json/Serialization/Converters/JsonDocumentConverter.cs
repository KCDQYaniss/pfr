namespace System.Text.Json.Serialization.Converters;

internal sealed class JsonDocumentConverter : JsonConverter
{

	public JsonDocumentConverter() { }

	public virtual void Write(Utf8JsonWriter writer, JsonDocument value, JsonSerializerOptions options) { }

}

