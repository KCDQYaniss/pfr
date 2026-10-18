namespace System.Text.Json.Serialization;

[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
internal sealed class IAsyncEnumerableConverterFactory : JsonConverterFactory
{

	public IAsyncEnumerableConverterFactory() { }

	public virtual bool CanConvert(Type typeToConvert) { }

	public virtual JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) { }

	private static Type GetAsyncEnumerableInterface(Type type) { }

}

