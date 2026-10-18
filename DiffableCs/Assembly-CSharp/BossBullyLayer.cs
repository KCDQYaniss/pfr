//Type is in global namespace

public class BossBullyLayer : BaseLogicLayer
{

	public BossBullyLayer(BotOwner bot, int priority) { }

	public override bool CanUse() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

