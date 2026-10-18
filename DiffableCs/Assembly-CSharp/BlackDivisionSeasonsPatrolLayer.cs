//Type is in global namespace

public class BlackDivisionSeasonsPatrolLayer : BaseLogicLayer
{
	private float _nextCheckReload; //Field offset: 0x90

	public BlackDivisionSeasonsPatrolLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndFollowerPatrolItem() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

