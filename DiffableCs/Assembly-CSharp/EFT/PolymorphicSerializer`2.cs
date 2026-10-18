namespace EFT;

public abstract class PolymorphicSerializer`2
{
	public TKeyType _parent; //Field offset: 0x0
	public JToken _props; //Field offset: 0x0

	protected PolymorphicSerializer`2() { }

	public override T Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer) { }

	protected abstract Type KeyToType(TKeyType type) { }

	public override void Serialize(JsonWriter writer, object value, JsonSerializer serializer) { }

	protected abstract TKeyType TypeToKey(Type type) { }

}

