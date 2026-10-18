namespace JsonType;

public sealed class JsonCorpse : JsonLootItem
{
	public BodyCustomization Customization; //Field offset: 0x58
	public EPlayerSide Side; //Field offset: 0x60
	public TransformSync[] Bones; //Field offset: 0x68
	public string ProfileID; //Field offset: 0x70
	public bool IsZombieCorpse; //Field offset: 0x78

	public JsonCorpse() { }

}

