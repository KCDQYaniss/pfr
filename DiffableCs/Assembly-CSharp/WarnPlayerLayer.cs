//Type is in global namespace

public class WarnPlayerLayer : BaseLogicLayer
{

	public WarnPlayerLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndWarnPlayer() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

