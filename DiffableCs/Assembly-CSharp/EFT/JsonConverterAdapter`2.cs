namespace EFT;

public sealed class JsonConverterAdapter`2 : JsonConverter
{

	public JsonConverterAdapter`2() { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

