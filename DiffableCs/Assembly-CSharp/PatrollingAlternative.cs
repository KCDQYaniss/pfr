//Type is in global namespace

public class PatrollingAlternative : MoveNode
{
	public bool CanLookAround; //Field offset: 0x28
	private readonly StayNode Stay; //Field offset: 0x30
	private readonly GoToResrevPlace Move; //Field offset: 0x38
	private readonly AimingToReservWay ShootToTarget; //Field offset: 0x40
	private readonly PatrolTakeItemsNode Looting; //Field offset: 0x48
	private readonly PatrolDropItemsNode Drop; //Field offset: 0x50

	public PatrollingAlternative(BotOwner bot) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

