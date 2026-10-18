namespace System.Text.Json.Serialization.Converters;

internal sealed class FSharpValueOptionConverter`2 : JsonConverter
{
	private readonly JsonConverter _elementConverter; //Field offset: 0x0
	private readonly StructGetter _optionValueGetter; //Field offset: 0x0
	private readonly Func _optionConstructor; //Field offset: 0x0

	internal virtual Type ElementType
	{
		internal get { } //Length: 168
	}

	public virtual bool HandleNull
	{
		 get { } //Length: 3
	}

	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
	public FSharpValueOptionConverter`2(JsonConverter elementConverter) { }

	internal virtual Type get_ElementType() { }

	public virtual bool get_HandleNull() { }

	internal virtual bool OnTryWrite(Utf8JsonWriter writer, TValueOption value, JsonSerializerOptions options, ref WriteStack state) { }

	public virtual void Write(Utf8JsonWriter writer, TValueOption value, JsonSerializerOptions options) { }

}

