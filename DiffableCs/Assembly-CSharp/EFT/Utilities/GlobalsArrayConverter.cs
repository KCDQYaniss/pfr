namespace EFT.Utilities;

public sealed class GlobalsArrayConverter : JsonConverter
{

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public GlobalsArrayConverter() { }

	public virtual bool get_CanWrite() { }

	public virtual IGlobalsArray ReadJson(JsonReader reader, Type objectType, IGlobalsArray existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, IGlobalsArray value, JsonSerializer serializer) { }

}

