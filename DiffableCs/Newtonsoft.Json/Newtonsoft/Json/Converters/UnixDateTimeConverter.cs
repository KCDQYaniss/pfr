namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class UnixDateTimeConverter : DateTimeConverterBase
{
	internal static readonly DateTime UnixEpoch; //Field offset: 0x0

	private static UnixDateTimeConverter() { }

	public UnixDateTimeConverter() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

