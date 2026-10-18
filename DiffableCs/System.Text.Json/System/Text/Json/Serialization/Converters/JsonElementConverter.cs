namespace System.Text.Json.Serialization.Converters;

internal sealed class JsonElementConverter : JsonConverter
{

	public JsonElementConverter() { }

	public virtual void Write(Utf8JsonWriter writer, JsonElement value, JsonSerializerOptions options) { }

}

