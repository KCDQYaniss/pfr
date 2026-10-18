//Type is in global namespace

public class DebugMoveShuttleNode : MoveNode
{
	public bool NoSprint; //Field offset: 0x28
	private float _updatePointTimer; //Field offset: 0x2C
	private float _distance; //Field offset: 0x30
	private bool _moving; //Field offset: 0x34
	private bool _sitWhenStop; //Field offset: 0x35
	private readonly bool _haveLookAt; //Field offset: 0x36
	private readonly bool _haveDataToExecute; //Field offset: 0x37
	private readonly Transform Target1; //Field offset: 0x38
	private readonly Transform Target2; //Field offset: 0x40
	private Transform CurTarget; //Field offset: 0x48
	private readonly GameObject _lookAt; //Field offset: 0x50
	private bool _doShoot; //Field offset: 0x58
	private readonly Aiming _aiming; //Field offset: 0x60
	private float _periodRefresh; //Field offset: 0x68
	private Vector3 _rndDir; //Field offset: 0x6C

	public DebugMoveShuttleNode(BotOwner bot) { }

	private void InPoint() { }

	private void RefreshGoToPoint() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

