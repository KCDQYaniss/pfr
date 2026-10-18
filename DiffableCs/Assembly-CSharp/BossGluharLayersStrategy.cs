//Type is in global namespace

public class BossGluharLayersStrategy : GluharAbstractLayersStrategy
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int ENEMY_LOGIC_SIMPLE = 7; //Field offset: 0x0
	private const int ENEMY_LOGIC_PROTECT = 8; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int KHOROVOD_CHRISTMAS_EVENT_LAYER = 13; //Field offset: 0x0

	public BossGluharLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual string ShortName() { }

}

