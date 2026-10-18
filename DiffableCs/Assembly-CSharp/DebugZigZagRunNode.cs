//Type is in global namespace

public class DebugZigZagRunNode : MoveNode
{
	private float _nextPoint; //Field offset: 0x28
	private float _positionChecker; //Field offset: 0x2C
	private Vector3 _min; //Field offset: 0x30
	private Vector3 _max; //Field offset: 0x3C
	private Vector3 _lastPosition; //Field offset: 0x48
	private bool _minMaxInited; //Field offset: 0x54

	public DebugZigZagRunNode(BotOwner bot) { }

	private void InitMinMax() { }

	private void PositionCheckerUpdater() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

