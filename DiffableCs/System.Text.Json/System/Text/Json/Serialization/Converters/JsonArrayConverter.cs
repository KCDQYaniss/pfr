namespace System.Text.Json.Serialization.Converters;

internal sealed class JsonArrayConverter : JsonConverter
{

	public JsonArrayConverter() { }

	public virtual void Write(Utf8JsonWriter writer, JsonArray value, JsonSerializerOptions options) { }

}

