namespace System.Text.Json.Serialization.Converters;

internal abstract class JsonPrimitiveConverter`1 : JsonConverter
{

	protected JsonPrimitiveConverter`1() { }

	public virtual void WriteAsPropertyName(Utf8JsonWriter writer, T value, JsonSerializerOptions options) { }

}

