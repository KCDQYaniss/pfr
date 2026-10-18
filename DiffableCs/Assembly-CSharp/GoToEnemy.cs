//Type is in global namespace

public class GoToEnemy : MoveToEnemy
{
	protected readonly Aiming _aiming; //Field offset: 0x30
	protected bool _lookOnlyToMovingDirection; //Field offset: 0x38

	public GoToEnemy(BotOwner bot) { }

	protected override void AimingAndShoot(CoreActionResultParams data) { }

	protected override Aiming GetAiming(BotOwner bot) { }

	protected void InPoint() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

