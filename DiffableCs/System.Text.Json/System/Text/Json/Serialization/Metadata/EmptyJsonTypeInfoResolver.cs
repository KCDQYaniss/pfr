namespace System.Text.Json.Serialization.Metadata;

internal sealed class EmptyJsonTypeInfoResolver : IJsonTypeInfoResolver, IBuiltInJsonTypeInfoResolver
{

	public EmptyJsonTypeInfoResolver() { }

	public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options) { }

	public override bool IsCompatibleWithOptions(JsonSerializerOptions _) { }

}

