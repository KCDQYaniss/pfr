//Type is in global namespace

public class CursedAssaultLayersStrategy : BaseBrain
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int PANIC_LOGIC = 4; //Field offset: 0x0
	private const int PATROL_REQUEST = 5; //Field offset: 0x0
	private const int GRENADE_DANGER = 6; //Field offset: 0x0
	private const int STAND_BY = 7; //Field offset: 0x0
	private const int LEAVE_LAYER = 8; //Field offset: 0x0
	private const int FORCED_HELP = 9; //Field offset: 0x0
	private const int PATROL_ACTIONS = 10; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int PURSUIT_LAYER = 13; //Field offset: 0x0

	public CursedAssaultLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual string ShortName() { }

}

