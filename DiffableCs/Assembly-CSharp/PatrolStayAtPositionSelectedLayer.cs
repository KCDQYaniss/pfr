//Type is in global namespace

public class PatrolStayAtPositionSelectedLayer : BaseLogicLayer
{
	protected Vector3 _corePosition; //Field offset: 0x90
	private PeriodicCheck _isTargetPointFar; //Field offset: 0xA0
	private AIPeriodAction _checkWay; //Field offset: 0xA8

	public PatrolStayAtPositionSelectedLayer(BotOwner bot, int priority) { }

	private bool CheckIsFar() { }

	protected virtual AICoreActionEnd EndAlternativePatrol() { }

	protected virtual AICoreActionEnd EndFollowerPatrolItem() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	public virtual AICoreActionResult GetDecision() { }

	private PatrolPoint GetPoint() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	public virtual void OnDrawGizmos() { }

	public virtual bool ShallUseNow() { }

	private void WayCheck() { }

}

