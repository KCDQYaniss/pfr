namespace EFT.Dialogs;

public sealed class DialogConditionConverter : JsonConverter
{

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public DialogConditionConverter() { }

	public virtual bool get_CanWrite() { }

	public virtual DialogCondition ReadJson(JsonReader reader, Type objectType, DialogCondition existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, DialogCondition value, JsonSerializer serializer) { }

}

