//Type is in global namespace

public class AttackMovingTactical : TaclicalMoveNode
{
	public float DangerTime; //Field offset: 0xB0
	protected readonly Aiming _aiming; //Field offset: 0xB8
	private float _updatePointTimer; //Field offset: 0xC0

	protected virtual float CHANCE_TO_COVER_SPRINT_ON_MAX_DIST_OR_HIGHER
	{
		 get { } //Length: 4
	}

	protected virtual float CHANCE_TO_COVER_SPRINT_ON_MIN_DIST_OR_LOWER
	{
		 get { } //Length: 4
	}

	protected override float CHANCE_TO_SPRINT_ON_MAX_DIST_OR_HIGHER
	{
		 get { } //Length: 4
	}

	protected override float CHANCE_TO_SPRINT_ON_MIN_DIST_OR_LOWER
	{
		 get { } //Length: 4
	}

	public AttackMovingTactical(BotOwner bot) { }

	protected override void AimingAndShoot(CoreActionResultParams data) { }

	protected virtual float get_CHANCE_TO_COVER_SPRINT_ON_MAX_DIST_OR_HIGHER() { }

	protected virtual float get_CHANCE_TO_COVER_SPRINT_ON_MIN_DIST_OR_LOWER() { }

	protected override float get_CHANCE_TO_SPRINT_ON_MAX_DIST_OR_HIGHER() { }

	protected override float get_CHANCE_TO_SPRINT_ON_MIN_DIST_OR_LOWER() { }

	protected override Aiming GetAiming(BotOwner bot) { }

	protected virtual void LookSimple() { }

	protected void RestartFindTime() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

}

