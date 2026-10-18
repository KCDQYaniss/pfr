namespace System.Text.Json.Serialization;

internal abstract class JsonDictionaryConverter`1 : JsonResumableConverter
{

	internal virtual bool SupportsCreateObjectDelegate
	{
		internal get { } //Length: 3
	}

	protected JsonDictionaryConverter`1() { }

	internal virtual bool get_SupportsCreateObjectDelegate() { }

	virtual ConverterStrategy GetDefaultConverterStrategy() { }

	protected private abstract bool OnWriteResume(Utf8JsonWriter writer, TDictionary dictionary, JsonSerializerOptions options, ref WriteStack state) { }

}

