//Type is in global namespace

public abstract class GluharAbstractLayersStrategy : BaseBrain
{
	protected BossGluhar _gluhar; //Field offset: 0x58

	protected GluharAbstractLayersStrategy(BotOwner owner) { }

	protected override void SetBoss(BossGluhar gluhar) { }

	protected override void SubFindBoss(IBossToFollow bossToFollow) { }

}

