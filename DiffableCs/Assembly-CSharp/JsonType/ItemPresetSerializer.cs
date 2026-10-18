namespace JsonType;

public sealed class ItemPresetSerializer : ISerializer
{
	public string _id; //Field offset: 0x10
	public FlatItem[] _items; //Field offset: 0x18
	public string _name; //Field offset: 0x20
	public string _parent; //Field offset: 0x28
	public string _encyclopedia; //Field offset: 0x30
	public bool _changeWeaponName; //Field offset: 0x38
	public NodeType _type; //Field offset: 0x3C

	public ItemPresetSerializer() { }

	public override ItemPreset Deserialize() { }

	public override object Serialize(ItemPreset t) { }

}

