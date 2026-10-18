namespace JsonType;

public class JsonLootItem
{
	public string Id; //Field offset: 0x10
	public Vector3 Position; //Field offset: 0x18
	public Vector3 Rotation; //Field offset: 0x24
	public Item Item; //Field offset: 0x30
	public MongoID[] ValidProfiles; //Field offset: 0x38
	public bool IsContainer; //Field offset: 0x40
	public bool useGravity; //Field offset: 0x41
	public bool randomRotation; //Field offset: 0x42
	public Vector3 Shift; //Field offset: 0x44
	public short PlatformId; //Field offset: 0x50

	public JsonLootItem() { }

}

