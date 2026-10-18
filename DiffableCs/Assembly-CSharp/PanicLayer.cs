//Type is in global namespace

public class PanicLayer : BaseLogicLayer
{

	public PanicLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndRunAwayGrenade() { }

	protected virtual AICoreActionEnd EndRunGas() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

