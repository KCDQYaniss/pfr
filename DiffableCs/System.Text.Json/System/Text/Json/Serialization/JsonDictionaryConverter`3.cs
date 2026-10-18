namespace System.Text.Json.Serialization;

internal abstract class JsonDictionaryConverter`3 : JsonDictionaryConverter
{
	protected JsonConverter _keyConverter; //Field offset: 0x0
	protected JsonConverter _valueConverter; //Field offset: 0x0

	internal virtual Type ElementType
	{
		internal get { } //Length: 168
	}

	internal virtual Type KeyType
	{
		internal get { } //Length: 169
	}

	protected JsonDictionaryConverter`3() { }

	internal virtual Type get_ElementType() { }

	internal virtual Type get_KeyType() { }

	protected static JsonConverter GetConverter(JsonTypeInfo typeInfo) { }

	internal virtual bool OnTryWrite(Utf8JsonWriter writer, TDictionary dictionary, JsonSerializerOptions options, ref WriteStack state) { }

}

