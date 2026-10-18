//Type is in global namespace

public class WedgeFightRequest : FightRequestLayer
{
	protected BossFinder _boss; //Field offset: 0x90

	public WedgeFightRequest(BotOwner bot, int priority) { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

