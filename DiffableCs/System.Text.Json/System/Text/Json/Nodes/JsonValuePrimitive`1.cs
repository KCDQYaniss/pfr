namespace System.Text.Json.Nodes;

internal sealed class JsonValuePrimitive`1 : JsonValue
{
	private static readonly JsonSerializerOptions s_defaultOptions; //Field offset: 0x0
	private readonly JsonConverter _converter; //Field offset: 0x0

	private static JsonValuePrimitive`1() { }

	public JsonValuePrimitive`1(TValue value, JsonConverter converter, Nullable options = null) { }

	public virtual void WriteTo(Utf8JsonWriter writer, JsonSerializerOptions options = null) { }

}

