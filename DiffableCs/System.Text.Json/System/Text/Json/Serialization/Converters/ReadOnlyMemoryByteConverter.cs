namespace System.Text.Json.Serialization.Converters;

internal sealed class ReadOnlyMemoryByteConverter : JsonConverter
{

	public virtual bool HandleNull
	{
		 get { } //Length: 3
	}

	public ReadOnlyMemoryByteConverter() { }

	public virtual bool get_HandleNull() { }

	public virtual void Write(Utf8JsonWriter writer, ReadOnlyMemory value, JsonSerializerOptions options) { }

}

