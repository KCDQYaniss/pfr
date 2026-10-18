namespace System.Text.Json.Serialization.Converters;

internal abstract class ObjectConverter : JsonConverter
{

	public ObjectConverter() { }

	virtual ConverterStrategy GetDefaultConverterStrategy() { }

	public virtual void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options) { }

	public virtual void WriteAsPropertyName(Utf8JsonWriter writer, object value, JsonSerializerOptions options) { }

	internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, object value, JsonSerializerOptions options, bool isWritingExtensionDataProperty) { }

}

