namespace System.Text.Json.Serialization.Converters;

internal sealed class CastingConverter`1 : JsonConverter
{
	private readonly JsonConverter _sourceConverter; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <HandleNull>k__BackingField; //Field offset: 0x0

	internal virtual Type ElementType
	{
		internal get { } //Length: 42
	}

	public virtual bool HandleNull
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal virtual Type KeyType
	{
		internal get { } //Length: 42
	}

	internal virtual JsonConverter SourceConverterForCastingConverter
	{
		internal get { } //Length: 5
	}

	internal virtual bool SupportsCreateObjectDelegate
	{
		internal get { } //Length: 42
	}

	internal CastingConverter`1(JsonConverter sourceConverter) { }

	internal virtual Type get_ElementType() { }

	[CompilerGenerated]
	public virtual bool get_HandleNull() { }

	internal virtual Type get_KeyType() { }

	internal virtual JsonConverter get_SourceConverterForCastingConverter() { }

	internal virtual bool get_SupportsCreateObjectDelegate() { }

	internal virtual bool OnTryWrite(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state) { }

	public virtual void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) { }

	public virtual void WriteAsPropertyName(Utf8JsonWriter writer, T value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, T value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, T value, JsonNumberHandling handling) { }

}

