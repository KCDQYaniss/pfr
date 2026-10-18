//Type is in global namespace

public class DebugShootNode : BaseNode
{
	protected const float UPDATE_TIME = 1; //Field offset: 0x0
	protected Vector3 targetAimingPoint; //Field offset: 0x18
	protected Vector3 placeForShoot; //Field offset: 0x24
	private bool isObjectsFind; //Field offset: 0x30
	private float _updatePointTimer; //Field offset: 0x34
	private readonly AimingDebugShoot _aimingDebug; //Field offset: 0x38

	public DebugShootNode(BotOwner bot) { }

	private void FindTrg() { }

	private void InPoint() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

