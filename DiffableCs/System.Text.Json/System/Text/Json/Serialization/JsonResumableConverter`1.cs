namespace System.Text.Json.Serialization;

internal abstract class JsonResumableConverter`1 : JsonConverter
{

	public virtual bool HandleNull
	{
		 get { } //Length: 3
	}

	protected JsonResumableConverter`1() { }

	public virtual bool get_HandleNull() { }

	public virtual void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) { }

}

