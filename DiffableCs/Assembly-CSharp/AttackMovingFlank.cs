//Type is in global namespace

public class AttackMovingFlank : FlankMove
{
	protected readonly Aiming _aiming; //Field offset: 0x50

	public AttackMovingFlank(BotOwner bot) { }

	protected override void AimingAndShoot(CoreActionResultParams data) { }

	public virtual void UpdateNodeByBrain(CoreActionResultParamsFlankMove data) { }

}

