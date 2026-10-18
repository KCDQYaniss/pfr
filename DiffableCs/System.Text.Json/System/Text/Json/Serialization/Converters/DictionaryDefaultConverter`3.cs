namespace System.Text.Json.Serialization.Converters;

internal abstract class DictionaryDefaultConverter`3 : JsonDictionaryConverter
{

	internal virtual bool CanHaveMetadata
	{
		internal get { } //Length: 3
	}

	protected DictionaryDefaultConverter`3() { }

	internal virtual bool get_CanHaveMetadata() { }

	protected private virtual bool OnWriteResume(Utf8JsonWriter writer, TDictionary value, JsonSerializerOptions options, ref WriteStack state) { }

}

