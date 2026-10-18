namespace System.Text.Json.Serialization.Converters;

[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
internal sealed class FSharpTypeConverterFactory : JsonConverterFactory
{
	private ObjectConverterFactory _recordConverterFactory; //Field offset: 0x28

	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public FSharpTypeConverterFactory() { }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The ctor is marked RequiresUnreferencedCode.")]
	public virtual bool CanConvert(Type typeToConvert) { }

	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2055:MakeGenericType", Justification = "The ctor is marked RequiresUnreferencedCode.")]
	[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The ctor is marked RequiresUnreferencedCode.")]
	public virtual JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) { }

}

