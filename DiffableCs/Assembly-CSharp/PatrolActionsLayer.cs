//Type is in global namespace

public class PatrolActionsLayer : BaseLogicLayer
{

	public PatrolActionsLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndDeadBody() { }

	protected virtual AICoreActionEnd EndDropItem() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndTakeItem() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

