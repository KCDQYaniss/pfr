//Type is in global namespace

public class GifterLayer : BaseLogicLayer
{

	public GifterLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndDoGiftChristmasEvent() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

