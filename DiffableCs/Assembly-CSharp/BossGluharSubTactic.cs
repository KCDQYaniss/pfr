//Type is in global namespace

public class BossGluharSubTactic : BotSubTactic
{

	public BossGluharSubTactic(BotOwner owner) { }

	public virtual CoverSearchType SearchRunToCover(CoverShootType shootType) { }

	public virtual CoverSearchType SearchTypeGoToCover(CoverShootType shootType) { }

	public virtual float SetTactic(BotCurrentTactic tactic, bool shallAutoReturnToAttack = false, float delta = -1) { }

}

