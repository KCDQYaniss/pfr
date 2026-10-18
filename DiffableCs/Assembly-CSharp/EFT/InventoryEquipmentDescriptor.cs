namespace EFT;

[GenerateBinarySerialization]
public sealed class InventoryEquipmentDescriptor
{
	[JsonProperty("Id")]
	private MongoID _id; //Field offset: 0x10
	[JsonProperty("Items")]
	private FlatItem[] _items; //Field offset: 0x28
	[JsonIgnore]
	public ItemDescriptor Items; //Field offset: 0x30

	public InventoryEquipmentDescriptor() { }

	public InventoryEquipmentDescriptor(InventoryEquipment equipment) { }

	[OnDeserialized]
	private void OnJSONDeserialized(StreamingContext context) { }

	[OnSerializing]
	private void OnJSONSerialize(StreamingContext context) { }

	public InventoryEquipment ToEquipment() { }

}

