namespace System.Text.Json.Serialization.Converters;

internal sealed class ByteArrayConverter : JsonConverter
{

	public ByteArrayConverter() { }

	public virtual void Write(Utf8JsonWriter writer, byte[] value, JsonSerializerOptions options) { }

}

