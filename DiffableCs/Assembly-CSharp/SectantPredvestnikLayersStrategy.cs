//Type is in global namespace

public class SectantPredvestnikLayersStrategy : StrategyLayersWithCorePositions
{
	private const float CHEAT_VISION_DIST = 30; //Field offset: 0x0
	private const int FIGHT = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int RUN_HIDE = 4; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int LEAVE_LAYER = 7; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private float _nextCheckIsInside; //Field offset: 0x58
	private bool _isInside; //Field offset: 0x5C
	private readonly PatrolStayAtPositionLayer _patrolLogic; //Field offset: 0x60
	private readonly BossSanitarFightLayer fightLayer; //Field offset: 0x68
	private readonly LeaveMapLayer _leave; //Field offset: 0x70
	private float _nextCheckTime; //Field offset: 0x78

	public SectantPredvestnikLayersStrategy(BotOwner owner) { }

	private void CheckEnemiesWithCheatVision() { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual void ManualUpdate() { }

	private void OnFollowerStatusChange(IBotOwner arg1, FollowerStatusChange arg2) { }

	public virtual void SetCorePosition(Vector3 pos) { }

	public virtual string ShortName() { }

	private void TryChangeToSuicide() { }

}

