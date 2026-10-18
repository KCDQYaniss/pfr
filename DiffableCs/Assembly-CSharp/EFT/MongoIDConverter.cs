namespace EFT;

public sealed class MongoIDConverter : JsonConverter
{

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public MongoIDConverter() { }

	public virtual bool get_CanRead() { }

	public virtual MongoID ReadJson(JsonReader reader, Type objectType, MongoID existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, MongoID mongoId, JsonSerializer serializer) { }

}

