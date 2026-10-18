//Type is in global namespace

internal class InfectedTargetLayer : BaseLogicLayer
{
	private const float LOOK_TO_HEAL_PERIOD = 3; //Field offset: 0x0
	private Vector3 _cachedTargetPoint; //Field offset: 0x90
	private float _goalTargetChangeTime; //Field offset: 0x9C
	private BotHalloweenEventPursuit _activePursuit; //Field offset: 0xA0

	public InfectedTargetLayer(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndSearch() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void OnGoalTargetChange(PlaceForCheck prev, PlaceForCheck next) { }

	private void OnZeroGoalSetted() { }

	private bool PlaceCreatRecently() { }

	public void SetActivePursuit(BotHalloweenEventPursuit activePursuit) { }

	private bool ShallSearch() { }

	public virtual bool ShallUseNow() { }

}

