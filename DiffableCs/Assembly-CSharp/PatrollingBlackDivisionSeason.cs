//Type is in global namespace

public class PatrollingBlackDivisionSeason : MoveNode
{
	private const float PANIC_SPRINT_DURATION = 10; //Field offset: 0x0
	private const int LAST_PATROL_POINTS_COUNT = 12; //Field offset: 0x0
	public bool CanLookAround; //Field offset: 0x28
	private readonly StayNode Stay; //Field offset: 0x30
	private readonly GoToResrevPlace Move; //Field offset: 0x38
	private readonly AimingToReservWay ShootToTarget; //Field offset: 0x40
	private readonly PatrolTakeItemsNode Looting; //Field offset: 0x48
	private readonly PatrolDropItemsNode Drop; //Field offset: 0x50
	private List PatrolWays; //Field offset: 0x58
	private BlackDivisionSeasonPatrolPoint _currentPatrolPoint; //Field offset: 0x60
	private BlackDivisionSeasonPatrolPoint _prevPatrolPoint; //Field offset: 0x68
	private List _lastPatrolPoints; //Field offset: 0x70
	private float _updatePathTime; //Field offset: 0x78
	private BlackDivisionSeasonPatrollingData _ownerPatrollingData; //Field offset: 0x80
	private float _lastNonPanicTime; //Field offset: 0x88
	private int idx; //Field offset: 0x8C

	public PatrollingBlackDivisionSeason(BotOwner bot) { }

	private void CheckSprint() { }

	public BlackDivisionSeasonPatrollingData GetFirstBotPatrollingInfo() { }

	private BlackDivisionSeasonPatrolPoint GetNearestBlackDivisionPatrolPoint(Vector3 point) { }

	private Vector3 GetNextPointPosition() { }

	private Vector3 GetPrevPointPosition() { }

	private void GoToNextPoint() { }

	private bool IsCome(Vector3 point) { }

	private void SetCurrentPatrolPoint(BlackDivisionSeasonPatrolPoint patrolPoint) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

