namespace System.Text.Json.Serialization.Converters;

[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
internal sealed class UnsupportedTypeConverterFactory : JsonConverterFactory
{

	public UnsupportedTypeConverterFactory() { }

	public virtual bool CanConvert(Type type) { }

	public virtual JsonConverter CreateConverter(Type type, JsonSerializerOptions options) { }

	internal static JsonConverter CreateUnsupportedConverterForType(Type type, string errorMessage = null) { }

}

