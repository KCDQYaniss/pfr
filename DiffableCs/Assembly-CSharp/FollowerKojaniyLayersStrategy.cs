//Type is in global namespace

public class FollowerKojaniyLayersStrategy : StrategyLayersWithCorePositions
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int ENEMY_LOGIC_FREE = 8; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private readonly FollowerKojaniyLayer enemyLogic; //Field offset: 0x58
	private readonly KojaniyTargetLogicLayer target; //Field offset: 0x60
	private readonly PatrolStayAtPositionLayer _patrolLogic; //Field offset: 0x68

	public bool IAmReady
	{
		 get { } //Length: 30
	}

	public FollowerKojaniyLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public bool get_IAmReady() { }

	public void SetBossKojaniy(IBossKojaniy bossKojaniy) { }

	public virtual void SetCorePosition(Vector3 pos) { }

	public virtual string ShortName() { }

}

