namespace System.Text.Json.Serialization.Converters;

[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
internal sealed class IEnumerableConverterFactory : JsonConverterFactory
{
	private static readonly IDictionaryConverter s_converterForIDictionary; //Field offset: 0x0
	private static readonly IEnumerableConverter s_converterForIEnumerable; //Field offset: 0x8
	private static readonly IListConverter s_converterForIList; //Field offset: 0x10

	private static IEnumerableConverterFactory() { }

	[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
	public IEnumerableConverterFactory() { }

	public virtual bool CanConvert(Type typeToConvert) { }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The ctor is marked RequiresUnreferencedCode.")]
	public virtual JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) { }

}

