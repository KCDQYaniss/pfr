namespace EFT.NextObservedPlayer;

public class ObservedPlayerArmorInfo
{
	public MongoID itemID; //Field offset: 0x10
	public EArmorType armorType; //Field offset: 0x28
	public float maxDurability; //Field offset: 0x2C
	public float durability; //Field offset: 0x30
	public int templateDurability; //Field offset: 0x34
	public List armorColliders; //Field offset: 0x38
	public EArmorPlateCollider armorPlateColliderMask; //Field offset: 0x40
	public Vector3 ricochetValues; //Field offset: 0x44
	public int armorClass; //Field offset: 0x50
	public MaterialType material; //Field offset: 0x54
	public bool isComposite; //Field offset: 0x58
	public bool isToggledAndOff; //Field offset: 0x59

	public ObservedPlayerArmorInfo() { }

	public bool ShotMatches(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider) { }

}

