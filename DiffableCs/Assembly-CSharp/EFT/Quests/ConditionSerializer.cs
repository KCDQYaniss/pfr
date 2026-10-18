namespace EFT.Quests;

public sealed class ConditionSerializer : PolymorphicSerializer
{
	private readonly List _types; //Field offset: 0x20
	[JsonExtensionData]
	private Dictionary _newProps; //Field offset: 0x28

	public ConditionSerializer() { }

	public virtual Condition Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer) { }

	protected virtual Type KeyToType(string serializedType) { }

	public virtual void Serialize(JsonWriter writer, object value, JsonSerializer serializer) { }

	protected virtual string TypeToKey(Type serializedType) { }

}

