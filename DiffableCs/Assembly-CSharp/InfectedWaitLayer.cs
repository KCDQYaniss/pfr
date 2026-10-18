//Type is in global namespace

internal class InfectedWaitLayer : BaseLogicLayer
{
	private bool _lastGo; //Field offset: 0x90
	private float _talk; //Field offset: 0x94
	private float DIST_TO_ENEMY; //Field offset: 0x98

	public InfectedWaitLayer(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndSearch() { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

