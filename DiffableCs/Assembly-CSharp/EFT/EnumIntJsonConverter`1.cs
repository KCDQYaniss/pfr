namespace EFT;

public sealed class EnumIntJsonConverter`1 : JsonConverter
{

	public EnumIntJsonConverter`1() { }

	public virtual T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, T value, JsonSerializer serializer) { }

}

