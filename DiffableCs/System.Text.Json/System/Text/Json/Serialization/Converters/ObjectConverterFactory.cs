namespace System.Text.Json.Serialization.Converters;

[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
internal sealed class ObjectConverterFactory : JsonConverterFactory
{
	private readonly bool _useDefaultConstructorInUnannotatedStructs; //Field offset: 0x28

	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	public ObjectConverterFactory(bool useDefaultConstructorInUnannotatedStructs = true) { }

	public virtual bool CanConvert(Type typeToConvert) { }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The ctor is marked RequiresUnreferencedCode.")]
	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2067:UnrecognizedReflectionPattern", Justification = "The ctor is marked RequiresUnreferencedCode.")]
	public virtual JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) { }

}

