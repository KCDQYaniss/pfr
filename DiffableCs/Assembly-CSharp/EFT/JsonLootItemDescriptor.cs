namespace EFT;

[GenerateBinarySerialization]
public class JsonLootItemDescriptor
{
	public string Id; //Field offset: 0x10
	public ClassVector3 Position; //Field offset: 0x18
	public ClassVector3 Rotation; //Field offset: 0x20
	public ItemDescriptor Item; //Field offset: 0x28
	[Nullable]
	public MongoID[] ValidProfiles; //Field offset: 0x30
	public bool IsContainer; //Field offset: 0x38
	public bool UseGravity; //Field offset: 0x39
	public bool RandomRotation; //Field offset: 0x3A
	public ClassVector3 Shift; //Field offset: 0x40
	public short PlatformId; //Field offset: 0x48

	public JsonLootItemDescriptor() { }

}

