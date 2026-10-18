namespace EFT;

public sealed class EnumIntFlagsConverter`1 : JsonConverter
{

	public EnumIntFlagsConverter`1() { }

	public virtual T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, T value, JsonSerializer serializer) { }

}

