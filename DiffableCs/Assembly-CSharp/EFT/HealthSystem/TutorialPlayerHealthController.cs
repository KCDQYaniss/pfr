namespace EFT.HealthSystem;

public class TutorialPlayerHealthController : PlayerHealthController
{
	private const float TUTORIAL_MIN_PART_HEALTH = 20; //Field offset: 0x0
	private const float TUTORIAL_MIN_TOTAL_HEALTH = 85; //Field offset: 0x0

	public TutorialPlayerHealthController(HealthInfo healthInfo, Player player, InventoryController inventoryController, SkillManager skillManager, bool aiHealth) { }

	public virtual void ChangeHealth(EBodyPart bodyPart, float value, DamageInfo damageInfo) { }

	protected virtual bool IsBodyPartCanBeDamaged(EBodyPart bodyPart, BodyPartState partState) { }

	public virtual void Kill(EDamageType damageType) { }

	private void ValidateTutorialHealthChange(EBodyPart bodyPart, ref float value, DamageInfo damageInfo, out bool ignore) { }

}

