//Type is in global namespace

public class DebugMoveShuttleTacticalNode : GoToPointTacticalNode
{
	public bool NoSprint; //Field offset: 0xB0
	private float _updatePointTimer; //Field offset: 0xB4
	private float _distance; //Field offset: 0xB8
	private bool _moving; //Field offset: 0xBC
	private bool _sitWhenStop; //Field offset: 0xBD
	private bool _haveLookAt; //Field offset: 0xBE
	private bool _haveDataToExecute; //Field offset: 0xBF
	private Transform Target1; //Field offset: 0xC0
	private Transform Target2; //Field offset: 0xC8
	private Transform CurTarget; //Field offset: 0xD0
	private GameObject _lookAt; //Field offset: 0xD8
	private float _periodRefresh; //Field offset: 0xE0
	private float _periodRefresh2; //Field offset: 0xE4

	public DebugMoveShuttleTacticalNode(BotOwner bot) { }

	private void InPoint() { }

	private void RefreshSuttleMoveTarget() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

