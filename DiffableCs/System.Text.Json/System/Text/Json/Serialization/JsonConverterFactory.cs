namespace System.Text.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public abstract class JsonConverterFactory : JsonConverter
{

	internal virtual Type ElementType
	{
		internal get { } //Length: 3
	}

	internal virtual Type KeyType
	{
		internal get { } //Length: 3
	}

	public virtual Type Type
	{
		 get { } //Length: 3
	}

	protected JsonConverterFactory() { }

	[NullableContext(1)]
	public abstract JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) { }

	internal virtual Type get_ElementType() { }

	internal virtual Type get_KeyType() { }

	public virtual Type get_Type() { }

	internal JsonConverter GetConverterInternal(Type typeToConvert, JsonSerializerOptions options) { }

	virtual ConverterStrategy GetDefaultConverterStrategy() { }

	internal virtual bool OnTryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }

	internal virtual bool TryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }

	internal virtual void WriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCoreAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteNumberWithCustomHandlingAsObject(Utf8JsonWriter writer, object value, JsonNumberHandling handling) { }

}

