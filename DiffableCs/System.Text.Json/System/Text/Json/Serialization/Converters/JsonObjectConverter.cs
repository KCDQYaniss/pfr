namespace System.Text.Json.Serialization.Converters;

internal sealed class JsonObjectConverter : JsonConverter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public JsonSerializerOptions options; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal object <ConfigureJsonTypeInfo>b__0() { }

	}


	public JsonObjectConverter() { }

	internal virtual void ConfigureJsonTypeInfo(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options) { }

	public virtual void Write(Utf8JsonWriter writer, JsonObject value, JsonSerializerOptions options) { }

}

