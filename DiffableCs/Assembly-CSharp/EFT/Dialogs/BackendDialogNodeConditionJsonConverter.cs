namespace EFT.Dialogs;

public sealed class BackendDialogNodeConditionJsonConverter : JsonConverter
{

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public BackendDialogNodeConditionJsonConverter() { }

	public virtual bool get_CanWrite() { }

	public virtual BackendDialogNodeConditionData ReadJson(JsonReader reader, Type objectType, BackendDialogNodeConditionData existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, BackendDialogNodeConditionData data, JsonSerializer serializer) { }

}

