//Type is in global namespace

public class AssaultTargetLayer : BaseLogicLayer
{
	private const float LOOK_TO_HEAL_PERIOD = 3; //Field offset: 0x0

	public AssaultTargetLayer(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndShootToSmoke() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void OnGoalTargetChange(PlaceForCheck prev, PlaceForCheck next) { }

	private void OnZeroGoalSetted() { }

	private bool PlaceCreatRecently() { }

	private bool ShallSearch() { }

	public virtual bool ShallUseNow() { }

}

