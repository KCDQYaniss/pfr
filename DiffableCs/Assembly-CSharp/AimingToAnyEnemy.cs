//Type is in global namespace

public class AimingToAnyEnemy : Aiming
{
	private const float SUPPRESS_PERIOD = 4; //Field offset: 0x0
	private AIPeriodAction _checkPlaceToAttack; //Field offset: 0x38
	private AIPeriodAction _periodRaycast; //Field offset: 0x40
	private Nullable _placeToShoot; //Field offset: 0x48
	private bool _isRaycastOk; //Field offset: 0x58

	public AimingToAnyEnemy(BotOwner bot) { }

	private void FindPlace() { }

	protected virtual Nullable GetTarget() { }

	private void RaycastCheck() { }

}

