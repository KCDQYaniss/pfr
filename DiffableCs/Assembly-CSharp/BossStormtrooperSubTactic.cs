//Type is in global namespace

public class BossStormtrooperSubTactic : BotSubTactic
{

	public BossStormtrooperSubTactic(BotOwner owner) { }

	public virtual CoverSearchType SearchRunToCover(CoverShootType shootType) { }

	public virtual CoverSearchType SearchTypeAttackMoving(CoverShootType shootType) { }

	public virtual float SetTactic(BotCurrentTactic tactic, bool shallAutoReturnToAttack = false, float delta = -1) { }

}

