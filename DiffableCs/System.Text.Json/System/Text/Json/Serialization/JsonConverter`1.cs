namespace System.Text.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public abstract class JsonConverter`1 : JsonConverter
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x0
	private JsonConverter _fallbackConverterForPropertyNameSerialization; //Field offset: 0x0

	[Nullable(2)]
	internal virtual Type ElementType
	{
		internal get { } //Length: 3
	}

	public override bool HandleNull
	{
		 get { } //Length: 25
	}

	[Nullable(2)]
	internal virtual Type KeyType
	{
		internal get { } //Length: 3
	}

	public virtual Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected private JsonConverter`1() { }

	public virtual bool CanConvert(Type typeToConvert) { }

	internal virtual JsonTypeInfo CreateJsonTypeInfo(JsonSerializerOptions options) { }

	internal virtual Type get_ElementType() { }

	public override bool get_HandleNull() { }

	internal virtual Type get_KeyType() { }

	[CompilerGenerated]
	public virtual Type get_Type() { }

	virtual ConverterStrategy GetDefaultConverterStrategy() { }

	private JsonConverter GetFallbackConverterForPropertyNameSerialization(JsonSerializerOptions options) { }

	private static bool IsNull(T value) { }

	internal override bool OnTryWrite(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state) { }

	internal virtual bool OnTryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }

	internal bool TryWrite(Utf8JsonWriter writer, in T value, JsonSerializerOptions options, ref WriteStack state) { }

	internal virtual bool TryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state) { }

	internal bool TryWriteDataExtensionProperty(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state) { }

	internal void VerifyWrite(int originalDepth, Utf8JsonWriter writer) { }

	public abstract void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) { }

	internal virtual void WriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options) { }

	public override void WriteAsPropertyName(Utf8JsonWriter writer, T value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options) { }

	internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, T value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal virtual void WriteAsPropertyNameCoreAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

	internal bool WriteCore(Utf8JsonWriter writer, in T value, JsonSerializerOptions options, ref WriteStack state) { }

	internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, T value, JsonNumberHandling handling) { }

	internal virtual void WriteNumberWithCustomHandlingAsObject(Utf8JsonWriter writer, object value, JsonNumberHandling handling) { }

}

