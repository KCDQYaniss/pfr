//Type is in global namespace

public class ExfiltrationLayer : BaseLogicLayer
{
	private const float DIST_TO_CHECK_STUCK_SQR = 1; //Field offset: 0x0
	private Vector3 _cachedPosition; //Field offset: 0x90
	private float _stuckTime; //Field offset: 0x9C

	public ExfiltrationLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndGoToExfiltrationPointNode() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool GroupLeaderWannaLeave() { }

	private bool HaveActiveFights() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

