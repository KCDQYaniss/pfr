namespace EFT;

public class WeaponSkill : Skill
{
	public Type WeaponBaseType; //Field offset: 0x78

	public WeaponSkill(SkillManager skillManager, ESkillId id, Type weaponType, float[] factors) { }

	public bool IsAssignableFrom(Type t) { }

}

