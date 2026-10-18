namespace EFT.InventoryLogic;

public class ThrowWeapTemplate : ItemTemplate
{
	public ThrowWeapType ThrowType; //Field offset: 0x148
	public float ExplDelay; //Field offset: 0x14C
	public float MinExplosionDistance; //Field offset: 0x150
	public float MaxExplosionDistance; //Field offset: 0x154
	public int FragmentsCount; //Field offset: 0x158
	public float MinFragmentDamage; //Field offset: 0x15C
	public float MaxFragmentDamage; //Field offset: 0x160
	public float Strength; //Field offset: 0x164
	public string FragmentType; //Field offset: 0x168
	public Vector3 Blindness; //Field offset: 0x170
	public Vector3 Contusion; //Field offset: 0x17C
	public int EmitTime; //Field offset: 0x188
	public bool CanBeHiddenDuringThrow; //Field offset: 0x18C
	public Vector3 ArmorDistanceDistanceDamage; //Field offset: 0x190
	public float MinTimeToContactExplode; //Field offset: 0x19C
	public string ExplosionEffectType; //Field offset: 0x1A0
	public bool CanPlantOnGround; //Field offset: 0x1A8
	public bool PlayFuzeSound; //Field offset: 0x1A9

	public ThrowWeapTemplate() { }

}

