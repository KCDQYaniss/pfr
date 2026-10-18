//Type is in global namespace

public class BossKojaniyLayersStrategy : StrategyLayersWithCorePositions
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private readonly BossKojaniyLayer _enemyLayer; //Field offset: 0x58
	private readonly KojaniyTargetLogicLayer _targetLayer; //Field offset: 0x60
	private readonly PatrolStayAtPositionLayer _patrolLogic; //Field offset: 0x68

	public BossKojaniyLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual void SetCorePosition(Vector3 pos) { }

	public virtual string ShortName() { }

}

