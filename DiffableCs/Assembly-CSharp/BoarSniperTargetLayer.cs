//Type is in global namespace

public class BoarSniperTargetLayer : BaseLogicLayer
{

	public BoarSniperTargetLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

