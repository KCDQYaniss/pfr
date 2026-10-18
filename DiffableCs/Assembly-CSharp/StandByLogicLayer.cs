//Type is in global namespace

public class StandByLogicLayer : BaseLogicLayerSimple
{

	public StandByLogicLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndStandBy() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

