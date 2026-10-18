namespace System.Text.Json.Serialization.Converters;

internal sealed class JsonValueConverter : JsonConverter
{

	public JsonValueConverter() { }

	public virtual void Write(Utf8JsonWriter writer, JsonValue value, JsonSerializerOptions options) { }

}

