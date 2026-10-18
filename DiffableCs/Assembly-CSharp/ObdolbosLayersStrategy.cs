//Type is in global namespace

public class ObdolbosLayersStrategy : BaseBrain
{
	private const int PATROL_LOGIC = 3; //Field offset: 0x0
	private const int TARGET_LOGIC = 4; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int ASSAULT_ENEMY = 14; //Field offset: 0x0

	public ObdolbosLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual string ShortName() { }

}

