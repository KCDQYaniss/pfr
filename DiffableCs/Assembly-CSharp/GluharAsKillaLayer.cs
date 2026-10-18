//Type is in global namespace

public class GluharAsKillaLayer : BossKillaLayer
{
	private BossGluhar _gluhar; //Field offset: 0xD0

	public GluharAsKillaLayer(BotOwner owner, int priority) { }

	public virtual string Name() { }

	public void SetBoss(BossGluhar gluhar) { }

	public virtual bool ShallUseNow() { }

}

