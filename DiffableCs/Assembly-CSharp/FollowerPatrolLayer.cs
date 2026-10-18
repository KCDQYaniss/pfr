//Type is in global namespace

public class FollowerPatrolLayer : BaseLogicLayer
{
	private float _nextCheckReload; //Field offset: 0x90

	public FollowerPatrolLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAlternativePatrol() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndFollowerPatrolItem() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	protected virtual AICoreActionEnd EndWatchSecondWeapon() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HaveSomeToDo(out string reason) { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

