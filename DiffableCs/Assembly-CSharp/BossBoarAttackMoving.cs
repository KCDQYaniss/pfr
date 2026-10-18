//Type is in global namespace

public class BossBoarAttackMoving : AttackMovingWithSuppress
{
	private float _period; //Field offset: 0x70
	private bool _doShoot; //Field offset: 0x74

	public BossBoarAttackMoving(BotOwner bot) { }

	protected virtual void AimingAndShoot(CoreActionResultParams data) { }

	protected virtual bool UseSenseEnemyPositionOnCoverSearch() { }

}

