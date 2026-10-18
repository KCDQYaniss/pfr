//Type is in global namespace

public class KojaniyTargetLogicLayer : BaseAbstractKojaniyLayer
{

	public KojaniyTargetLogicLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual bool ShallAttack() { }

	public virtual bool ShallUseNow() { }

}

