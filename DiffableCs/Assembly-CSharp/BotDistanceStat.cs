//Type is in global namespace

public class BotDistanceStat
{
	public float distance; //Field offset: 0x10
	public int shoots; //Field offset: 0x14
	public int hits; //Field offset: 0x18
	public float damage; //Field offset: 0x1C
	public float armorDamage; //Field offset: 0x20
	public Dictionary bonesHits; //Field offset: 0x28
	public Dictionary partsHits; //Field offset: 0x30

	public BotDistanceStat() { }

	public void BoneHit(string bone, EBodyPart bodyType) { }

}

