//Type is in global namespace

public class KhorovodLayer : BaseLogicLayer
{

	public KhorovodLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndKhorovodChristmasEvent() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	public virtual bool ShallUseNow() { }

}

