namespace EFT;

public sealed class PolymorphicConverter`3 : JsonConverter
{
	[ThreadStatic]
	private static List _ignoredList; //Field offset: 0xFFFFFFFF

	[JsonIgnore]
	public virtual bool CanRead
	{
		 get { } //Length: 31
	}

	[JsonIgnore]
	public virtual bool CanWrite
	{
		 get { } //Length: 31
	}

	public PolymorphicConverter`3() { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	private void IgnoreNextSerialization() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	private bool ShouldBeIgnored() { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

