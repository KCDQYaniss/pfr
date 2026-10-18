//Type is in global namespace

public class AttackMovingFlankToPoint : MoveNode
{
	protected readonly Aiming _aiming; //Field offset: 0x28

	public float LOOK_TO_ENEMY_IF_SEEN
	{
		 get { } //Length: 58
	}

	public AttackMovingFlankToPoint(BotOwner bot) { }

	private void AimingAndShoot(CoreActionResultParams data) { }

	public float get_LOOK_TO_ENEMY_IF_SEEN() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParamsFlankMove data) { }

}

