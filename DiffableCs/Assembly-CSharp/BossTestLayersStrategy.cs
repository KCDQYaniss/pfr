//Type is in global namespace

public class BossTestLayersStrategy : BaseBrain
{
	private const int TEST_LOGIC = 1; //Field offset: 0x0
	private const int GRENADE_DANGER = 2; //Field offset: 0x0
	private const int TEST_SECOND_LOGIC = 3; //Field offset: 0x0

	public BossTestLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual string ShortName() { }

}

