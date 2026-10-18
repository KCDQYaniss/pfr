namespace System.Text.Json.Serialization.Converters;

internal sealed class MemoryByteConverter : JsonConverter
{

	public virtual bool HandleNull
	{
		 get { } //Length: 3
	}

	public MemoryByteConverter() { }

	public virtual bool get_HandleNull() { }

	public virtual void Write(Utf8JsonWriter writer, Memory value, JsonSerializerOptions options) { }

}

