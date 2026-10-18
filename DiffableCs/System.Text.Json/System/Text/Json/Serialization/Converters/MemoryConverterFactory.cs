namespace System.Text.Json.Serialization.Converters;

[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
internal sealed class MemoryConverterFactory : JsonConverterFactory
{

	public MemoryConverterFactory() { }

	public virtual bool CanConvert(Type typeToConvert) { }

	public virtual JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) { }

}

