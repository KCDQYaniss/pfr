namespace EFT.Quests;

public sealed class HitConditionCheck
{
	public string TargetSide; //Field offset: 0x10
	public float Distance; //Field offset: 0x18
	public string Weapon; //Field offset: 0x20
	public string WeaponCaliber; //Field offset: 0x28
	public string[] WeaponMods; //Field offset: 0x30
	public List TargetEquipment; //Field offset: 0x38
	public EBodyPart BodyPart; //Field offset: 0x40
	public int CurrentHour; //Field offset: 0x44
	public int Value; //Field offset: 0x48
	public string ScavRole; //Field offset: 0x50
	public HealthEffects EnemyHealthEffects; //Field offset: 0x58

	public HitConditionCheck() { }

}

