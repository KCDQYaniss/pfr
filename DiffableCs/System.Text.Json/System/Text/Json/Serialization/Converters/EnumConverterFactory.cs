namespace System.Text.Json.Serialization.Converters;

[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
internal sealed class EnumConverterFactory : JsonConverterFactory
{

	public EnumConverterFactory() { }

	public virtual bool CanConvert(Type type) { }

	internal static JsonConverter Create(Type enumType, EnumConverterOptions converterOptions, JsonNamingPolicy namingPolicy, JsonSerializerOptions options) { }

	public virtual JsonConverter CreateConverter(Type type, JsonSerializerOptions options) { }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "'EnumConverter<T> where T : struct' implies 'T : new()', so the trimmer is warning calling MakeGenericType here because enumType's constructors are not annotated. But EnumConverter doesn't call new T(), so this is safe.")]
	private static Type GetEnumConverterType(Type enumType) { }

}

