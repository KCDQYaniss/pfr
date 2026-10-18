//Type is in global namespace

public class BlackDivisionFlank : BlackDivisionAbstract
{
	private bool _laskIsAttackMoving; //Field offset: 0x98
	private PeriodicCheck _checkIsAnyOneHit; //Field offset: 0xA0
	private Nullable _flankTarget; //Field offset: 0xA8

	public BlackDivisionFlank(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndAttackMovingFlank() { }

	protected AICoreActionEnd EndAttackMovingMy() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndMoveStealthy() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsAnyOneHit() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

