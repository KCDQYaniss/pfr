namespace EFT.Customization;

public sealed class CustomizationItemSerializer : PolymorphicSerializer
{
	public MongoID _id; //Field offset: 0x20
	public string _name; //Field offset: 0x38
	public NodeType _type; //Field offset: 0x40

	public CustomizationItemSerializer() { }

	public virtual BaseCustomizationItem Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer) { }

	protected virtual Type KeyToType(string serializedType) { }

	protected virtual string TypeToKey(Type serializedType) { }

}

