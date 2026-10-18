//Type is in global namespace

public class StandardAssaultLayersStrategy : BaseBrain
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC_FULL = 19; //Field offset: 0x0
	private const int ENEMY_PUSH_LOGIC = 18; //Field offset: 0x0
	private const int FOLLOW_HELP = 17; //Field offset: 0x0
	private const int PURSUIT_BASE = 16; //Field offset: 0x0
	private const int TARGET_BUILDING = 15; //Field offset: 0x0
	private const int ENEMY_BUILDING = 14; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int FIGHT_REQUEST = 11; //Field offset: 0x0
	private const int PATROL_ACTIONS = 10; //Field offset: 0x0
	private const int FORCED_HELP = 9; //Field offset: 0x0
	private const int LEAVE_LAYER = 8; //Field offset: 0x0
	private const int STAND_BY = 7; //Field offset: 0x0
	private const int GRENADE_DANGER = 6; //Field offset: 0x0
	private const int PATROL_REQUEST = 5; //Field offset: 0x0
	private const int PANIC_LOGIC = 4; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const float CHANCE_TO_RUSH_ON_DEATH = 20; //Field offset: 0x0
	private const int ENEMY_FAR_LOGIC = 21; //Field offset: 0x0

	public StandardAssaultLayersStrategy(BotOwner owner) { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	private void OnMemberRemove(BotOwner obj) { }

	public virtual string ShortName() { }

}

