namespace System.Text.Json.Serialization.Converters;

internal sealed class JsonNodeConverterFactory : JsonConverterFactory
{

	public JsonNodeConverterFactory() { }

	public virtual bool CanConvert(Type typeToConvert) { }

	public virtual JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) { }

}

