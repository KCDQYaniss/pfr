//Type is in global namespace

public class PeacefulRequestLayer : BaseLogicLayer
{

	public PeacefulRequestLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAlternativePatrol() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndDoorOpenRequest() { }

	protected virtual AICoreActionEnd EndFollowMeRequest() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndRunAndThrowGrenadeFromPlace() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndRunToStationary() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	protected virtual AICoreActionEnd EndSuppressGrenade() { }

	protected virtual AICoreActionEnd EndWarnPlayer() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HaveRequests() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

