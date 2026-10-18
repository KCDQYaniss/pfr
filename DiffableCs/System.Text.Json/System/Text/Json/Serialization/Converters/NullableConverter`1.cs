namespace System.Text.Json.Serialization.Converters;

internal sealed class NullableConverter`1 : JsonConverter
{
	private readonly JsonConverter _elementConverter; //Field offset: 0x0

	internal virtual bool CanPopulate
	{
		internal get { } //Length: 42
	}

	internal virtual bool ConstructorIsParameterized
	{
		internal get { } //Length: 42
	}

	internal virtual Type ElementType
	{
		internal get { } //Length: 168
	}

	public virtual bool HandleNull
	{
		 get { } //Length: 3
	}

	public NullableConverter`1(JsonConverter elementConverter) { }

	internal virtual bool get_CanPopulate() { }

	internal virtual bool get_ConstructorIsParameterized() { }

	internal virtual Type get_ElementType() { }

	public virtual bool get_HandleNull() { }

	internal virtual bool OnTryWrite(Utf8JsonWriter writer, Nullable value, JsonSerializerOptions options, ref WriteStack state) { }

	public virtual void Write(Utf8JsonWriter writer, Nullable value, JsonSerializerOptions options) { }

	internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, Nullable value, JsonNumberHandling handling) { }

}

