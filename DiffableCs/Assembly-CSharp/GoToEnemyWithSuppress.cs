//Type is in global namespace

public class GoToEnemyWithSuppress : GoToEnemy
{
	private float _period; //Field offset: 0x40
	private bool _doShoot; //Field offset: 0x44

	public GoToEnemyWithSuppress(BotOwner bot) { }

	protected virtual void AimingAndShoot(CoreActionResultParams data) { }

	protected virtual Aiming GetAiming(BotOwner bot) { }

	private void LookIfNoShoot() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

