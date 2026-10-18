//Type is in global namespace

public class DebugRunToCloseCoverNode : MoveNode
{
	public bool WithRestart; //Field offset: 0x28
	public BotEventDebug TargetPosition; //Field offset: 0x30
	private CustomNavigationPoint _lastClosets; //Field offset: 0x38
	private float _nextRefreshCover; //Field offset: 0x40

	public DebugRunToCloseCoverNode(BotOwner bot) { }

	private void InPoint() { }

	private void PeriodRefreshClosestCover() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

