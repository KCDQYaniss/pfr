//Type is in global namespace

public class TagillaSearchLayer : BaseLogicLayer
{
	private const float LOOK_TO_HEAL_PERIOD = 3; //Field offset: 0x0

	public TagillaSearchLayer(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndShootToSmoke() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void OnGoalTargetChange(PlaceForCheck prev, PlaceForCheck next) { }

	private void OnZeroGoalSetted() { }

	public virtual bool ShallUseNow() { }

}

