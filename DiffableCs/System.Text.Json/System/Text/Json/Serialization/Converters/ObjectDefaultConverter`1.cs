namespace System.Text.Json.Serialization.Converters;

internal class ObjectDefaultConverter`1 : JsonObjectConverter
{

	internal virtual bool CanHaveMetadata
	{
		internal get { } //Length: 3
	}

	internal virtual bool SupportsCreateObjectDelegate
	{
		internal get { } //Length: 3
	}

	public ObjectDefaultConverter`1() { }

	internal virtual bool get_CanHaveMetadata() { }

	internal virtual bool get_SupportsCreateObjectDelegate() { }

	internal virtual bool OnTryWrite(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state) { }

}

