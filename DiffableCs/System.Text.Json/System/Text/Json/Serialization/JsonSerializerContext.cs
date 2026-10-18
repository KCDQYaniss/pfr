namespace System.Text.Json.Serialization;

public abstract class JsonSerializerContext : IJsonTypeInfoResolver, IBuiltInJsonTypeInfoResolver
{
	private JsonSerializerOptions _options; //Field offset: 0x10

	[Nullable(2)]
	protected abstract JsonSerializerOptions GeneratedSerializerOptions
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	[NullableContext(2)]
	protected abstract JsonSerializerOptions get_GeneratedSerializerOptions() { }

	[NullableContext(1)]
	public abstract JsonTypeInfo GetTypeInfo(Type type) { }

	private override bool System.Text.Json.Serialization.Metadata.IBuiltInJsonTypeInfoResolver.IsCompatibleWithOptions(JsonSerializerOptions options) { }

	private override JsonTypeInfo System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver.GetTypeInfo(Type type, JsonSerializerOptions options) { }

}

