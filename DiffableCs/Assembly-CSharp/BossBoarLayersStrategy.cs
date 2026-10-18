//Type is in global namespace

public class BossBoarLayersStrategy : BaseBrain
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int GRENADE_DANGER = 3; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 4; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0

	public BossBoarLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual string ShortName() { }

}

