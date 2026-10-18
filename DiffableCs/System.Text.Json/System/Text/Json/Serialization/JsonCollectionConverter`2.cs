namespace System.Text.Json.Serialization;

internal abstract class JsonCollectionConverter`2 : JsonResumableConverter
{

	internal virtual Type ElementType
	{
		internal get { } //Length: 168
	}

	internal virtual bool SupportsCreateObjectDelegate
	{
		internal get { } //Length: 3
	}

	protected JsonCollectionConverter`2() { }

	internal virtual Type get_ElementType() { }

	internal virtual bool get_SupportsCreateObjectDelegate() { }

	virtual ConverterStrategy GetDefaultConverterStrategy() { }

	protected static JsonConverter GetElementConverter(ref WriteStack state) { }

	internal virtual bool OnTryWrite(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }

	protected abstract bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }

}

