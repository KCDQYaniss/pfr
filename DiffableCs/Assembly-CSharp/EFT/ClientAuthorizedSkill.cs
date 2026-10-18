namespace EFT;

public sealed class ClientAuthorizedSkill : Skill
{

	public ClientAuthorizedSkill(SkillManager skillManager, ESkillId id, ESkillClass skillClass, SkillAction[] actions, Buff[] buffs) { }

	protected virtual void OnTrigger(SkillAction skillAction, float val) { }

}

