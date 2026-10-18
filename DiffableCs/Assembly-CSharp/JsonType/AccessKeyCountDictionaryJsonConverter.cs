namespace JsonType;

internal sealed class AccessKeyCountDictionaryJsonConverter : JsonConverter
{

	public AccessKeyCountDictionaryJsonConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	private static int ReadRequirementCount(JToken valueToken) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

