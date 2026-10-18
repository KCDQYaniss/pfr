//Type is in global namespace

public class DebugRunToPointNode : MoveNode
{
	public float UpdatePointTimerDelta; //Field offset: 0x28
	public bool WithRestart; //Field offset: 0x2C
	public Transform TargetPosition; //Field offset: 0x30
	private float _distance; //Field offset: 0x38
	private float _updatePointTimer; //Field offset: 0x3C

	public DebugRunToPointNode(BotOwner bot) { }

	private void InPoint() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

