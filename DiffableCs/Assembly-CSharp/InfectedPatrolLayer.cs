//Type is in global namespace

public class InfectedPatrolLayer : BaseLogicLayer
{
	private CustomNavigationPoint _cachedTargetPoint; //Field offset: 0x90
	private float _talk; //Field offset: 0x98

	public InfectedPatrolLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

