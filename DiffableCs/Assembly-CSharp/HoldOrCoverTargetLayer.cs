//Type is in global namespace

public class HoldOrCoverTargetLayer : BaseLogicLayer
{
	protected readonly Func _shallUse; //Field offset: 0x90

	public HoldOrCoverTargetLayer(BotOwner bot, int priority, Func shallUse) { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndMoveStealthy() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

