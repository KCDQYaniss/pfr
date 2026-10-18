//Type is in global namespace

internal class BlackDivisionDeadBody : BlackDivisionAbstract
{

	public BlackDivisionDeadBody(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndFollowerPatrolItem() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

