//Type is in global namespace

public class BlackDivisionSuppressAssault : BlackDivisionAbstract
{
	private PeriodicCheck _canGoWithSuppress; //Field offset: 0x98

	public BlackDivisionSuppressAssault(BotOwner bot, int priority) { }

	private bool CanStartSup() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToEnemyWithSuppress() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

