namespace System.Text.Json.Serialization.Metadata;

[NullableContext(1)]
public interface IJsonTypeInfoResolver
{

	public JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options) { }

}

