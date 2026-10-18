namespace EFT;

public sealed class EnumConverter`1 : JsonConverter
{
	private static readonly Type _type; //Field offset: 0x0
	private readonly Dictionary _table; //Field offset: 0x0
	private readonly Dictionary _backwardsTable; //Field offset: 0x0
	private readonly bool _caseSensitive; //Field offset: 0x0

	private static EnumConverter`1() { }

	public EnumConverter`1() { }

	public EnumConverter`1(bool caseSensitive = true) { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

