namespace EFT.Dialogs;

public sealed class DialogActionJsonConverter : JsonConverter
{

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public DialogActionJsonConverter() { }

	public virtual bool get_CanWrite() { }

	public virtual DialogAction ReadJson(JsonReader reader, Type objectType, DialogAction existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, DialogAction data, JsonSerializer serializer) { }

}

