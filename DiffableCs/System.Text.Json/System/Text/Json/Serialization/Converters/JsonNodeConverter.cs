namespace System.Text.Json.Serialization.Converters;

internal sealed class JsonNodeConverter : JsonConverter
{
	private static JsonNodeConverter s_nodeConverter; //Field offset: 0x0
	private static JsonArrayConverter s_arrayConverter; //Field offset: 0x8
	private static JsonObjectConverter s_objectConverter; //Field offset: 0x10
	private static JsonValueConverter s_valueConverter; //Field offset: 0x18

	public static JsonArrayConverter ArrayConverter
	{
		 get { } //Length: 270
	}

	public static JsonNodeConverter Instance
	{
		 get { } //Length: 238
	}

	public static JsonObjectConverter ObjectConverter
	{
		 get { } //Length: 270
	}

	public static JsonValueConverter ValueConverter
	{
		 get { } //Length: 270
	}

	public JsonNodeConverter() { }

	public static JsonNode Create(JsonElement element, Nullable options) { }

	public static JsonArrayConverter get_ArrayConverter() { }

	public static JsonNodeConverter get_Instance() { }

	public static JsonObjectConverter get_ObjectConverter() { }

	public static JsonValueConverter get_ValueConverter() { }

	public virtual void Write(Utf8JsonWriter writer, JsonNode value, JsonSerializerOptions options) { }

}

