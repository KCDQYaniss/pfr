//Type is in global namespace

public class BossWedgeLayersStrategy : BossWedgeBaseLayersStrategy
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET = 3; //Field offset: 0x0
	private const int FAR_DIST = 4; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int GRENADE_DANGER_2 = 11; //Field offset: 0x0
	private const int ROOMS = 19; //Field offset: 0x0
	private const int MID_DIST = 6; //Field offset: 0x0
	private const int CLOSE_DIST = 7; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int FIGHT_REQUEST = 18; //Field offset: 0x0
	private const int BOSS_WEDGE_AMBUSH = 17; //Field offset: 0x0
	private float _lastChange; //Field offset: 0x60

	public BossWedgeLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual string ShortName() { }

}

