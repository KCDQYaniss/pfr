//Type is in global namespace

public class BlackDivisionHide : BlackDivisionAbstract
{
	private PeriodicCheck _hitCheck; //Field offset: 0x98

	public BlackDivisionHide(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsAnyOneHit() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

