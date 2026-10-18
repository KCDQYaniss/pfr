//Type is in global namespace

public class AssaultBuildingLayer : BaseLogicLayer
{

	public AssaultBuildingLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

