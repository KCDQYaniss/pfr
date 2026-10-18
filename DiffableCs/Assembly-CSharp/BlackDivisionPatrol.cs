//Type is in global namespace

public class BlackDivisionPatrol : BlackDivisionAbstract
{
	private bool _isInied; //Field offset: 0x98
	private float _nextCheckReload; //Field offset: 0x9C
	private AIPeriodAction _reload; //Field offset: 0xA0

	public BlackDivisionPatrol(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndFollowerPatrolItem() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void Reload() { }

	public virtual bool ShallUseNow() { }

}

