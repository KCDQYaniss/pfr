//Type is in global namespace

public class AttackMovingWithSuppress : AttackMoving
{
	private float _period; //Field offset: 0x68
	private bool _doShoot; //Field offset: 0x6C

	public AttackMovingWithSuppress(BotOwner bot) { }

	protected virtual void AimingAndShoot(CoreActionResultParams data) { }

	protected virtual Aiming GetAiming(BotOwner bot) { }

}

