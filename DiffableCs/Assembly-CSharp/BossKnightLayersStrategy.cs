//Type is in global namespace

public class BossKnightLayersStrategy : ExUsecAbstractStrategy
{
	private const int KNIGHT_LAYER = 1; //Field offset: 0x0
	private const int ENEMY_LOGIC = 2; //Field offset: 0x0
	private const int PATROL_LOGIC = 3; //Field offset: 0x0
	private const int TARGET_LOGIC = 4; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int PATROL_REQUEST = 6; //Field offset: 0x0
	private const int PATROL_ACTIONS = 7; //Field offset: 0x0
	private const int ENEMY_BUILDING = 8; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int ASSAULT_ENEMY_BUILDING = 14; //Field offset: 0x0
	private readonly BossKnightFightLayer _fightLayer; //Field offset: 0x60

	public BossKnightLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public void ForceRecalcShootPos() { }

	public virtual string ShortName() { }

}

