namespace System.Text.Json.Serialization.Converters;

[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
internal sealed class NullableConverterFactory : JsonConverterFactory
{

	public NullableConverterFactory() { }

	public virtual bool CanConvert(Type typeToConvert) { }

	public virtual JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) { }

	public static JsonConverter CreateValueConverter(Type valueTypeToConvert, JsonConverter valueConverter) { }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "'NullableConverter<T> where T : struct' implies 'T : new()', so the trimmer is warning calling MakeGenericType here because valueTypeToConvert's constructors are not annotated. But NullableConverter doesn't call new T(), so this is safe.")]
	private static Type GetNullableConverterType(Type valueTypeToConvert) { }

}

