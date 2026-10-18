//Type is in global namespace

public class ExUsecPeacefulRequestLayer : BaseLogicLayer
{

	public ExUsecPeacefulRequestLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndDoorOpenRequest() { }

	protected virtual AICoreActionEnd EndFollowMeRequest() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunAndThrowGrenadeFromPlace() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	protected virtual AICoreActionEnd EndSuppressGrenade() { }

	protected virtual AICoreActionEnd EndWarnPlayer() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HaveRequests() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

