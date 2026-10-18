//Type is in global namespace

internal class ObdolbosEventFightLayer : BaseLogicLayer
{
	private readonly float _nextRnd; //Field offset: 0x90
	private float _lastSetOperatoin; //Field offset: 0x94
	private BotTiltType _lastTilt; //Field offset: 0x98
	private float _nextTilt; //Field offset: 0x9C

	public ObdolbosEventFightLayer(BotOwner bot, int priority) { }

	private AICoreActionResult DecisionWithTime(BotLogicDecision d, string reason) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

	private bool ShouldEndShoot() { }

	private void TiltManualUpdate() { }

}

