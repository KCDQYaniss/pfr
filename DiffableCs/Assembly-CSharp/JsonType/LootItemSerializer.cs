namespace JsonType;

public sealed class LootItemSerializer : ISerializer, ISerializer
{
	public string Id; //Field offset: 0x10
	public ClassVector3 Position; //Field offset: 0x18
	public ClassVector3 Rotation; //Field offset: 0x20
	public FlatItem[] Items; //Field offset: 0x28
	public string Root; //Field offset: 0x30
	public bool IsContainer; //Field offset: 0x38
	public MongoID[] ValidProfiles; //Field offset: 0x40
	public bool useGravity; //Field offset: 0x48
	public bool randomRotation; //Field offset: 0x49
	public BodyCustomization Customization; //Field offset: 0x50
	public EPlayerSide Side; //Field offset: 0x58
	public ClassTransformSync[] Bones; //Field offset: 0x60
	public string CorpseProfileID; //Field offset: 0x68
	public bool IsZombieCorpse; //Field offset: 0x70
	public ClassVector3 Shift; //Field offset: 0x78

	public LootItemSerializer() { }

	private override JsonCorpse EFT.ISerializer<JsonType.JsonCorpse>.Deserialize() { }

	private override object EFT.ISerializer<JsonType.JsonCorpse>.Serialize(JsonCorpse t) { }

	private override JsonLootItem EFT.ISerializer<JsonType.JsonLootItem>.Deserialize() { }

	private override object EFT.ISerializer<JsonType.JsonLootItem>.Serialize(JsonLootItem t) { }

}

