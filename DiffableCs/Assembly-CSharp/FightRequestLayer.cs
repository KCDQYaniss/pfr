//Type is in global namespace

public class FightRequestLayer : BaseLogicLayer
{

	public FightRequestLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAlternativePatrol() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndDoorOpenRequest() { }

	protected virtual AICoreActionEnd EndFollowMeRequest() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunAndThrowGrenadeFromPlace() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndRunToStationary() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	protected virtual AICoreActionEnd EndSuppressGrenade() { }

	protected virtual AICoreActionEnd EndThrowGrenadeFromPlace() { }

	protected virtual AICoreActionEnd EndWarnPlayer() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HaveRequests() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

