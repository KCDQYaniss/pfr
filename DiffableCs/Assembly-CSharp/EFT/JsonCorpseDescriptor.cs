namespace EFT;

public sealed class JsonCorpseDescriptor : JsonLootItemDescriptor
{
	public Dictionary Customization; //Field offset: 0x50
	public EPlayerSide Side; //Field offset: 0x58
	public ClassTransformSync[] Bones; //Field offset: 0x60
	public string PlayerProfileID; //Field offset: 0x68
	public bool IsZombieCorpse; //Field offset: 0x70

	public JsonCorpseDescriptor() { }

}

