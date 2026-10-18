//Type is in global namespace

public class AimingToDeadBody : BaseNode
{
	private Vector3 _enemyPos; //Field offset: 0x18
	private bool showReady; //Field offset: 0x24
	private float _timeReady; //Field offset: 0x28
	private readonly Shoot _shootNode; //Field offset: 0x30

	public AimingToDeadBody(BotOwner bot) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

