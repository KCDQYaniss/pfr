//Type is in global namespace

public class ShootFromCover : ShootFromPlace
{
	public const float WAIT_FOR_TILT = 0.6; //Field offset: 0x0
	public const float BOT_CLOSE = 0.14; //Field offset: 0x0
	public const float LAY_CHECK_DELTA = 6; //Field offset: 0x0
	private const float DIST_TO_STOP_RELOAD = 32; //Field offset: 0x0
	private const float MIN_TIME_TO_BE_AT_SHOOT = 0.5; //Field offset: 0x0
	private const float PERIOD_PERSON_SEEN_TIME_TOLEAVE_COVER = 3; //Field offset: 0x0
	public ShootFromCoverType ShootType; //Field offset: 0x40
	private float _nextPossibleCheckLay; //Field offset: 0x44
	private bool isMoving; //Field offset: 0x48

	protected CustomNavigationPoint CovPoint
	{
		 get { } //Length: 45
	}

	public ShootFromCover(BotOwner bot) { }

	private bool CanShoot() { }

	private void CheckCanUseCover() { }

	protected override bool CoveringUpdate() { }

	protected CustomNavigationPoint get_CovPoint() { }

	protected override bool ShootStatus() { }

	private void Stop() { }

	private bool TryCheckLay() { }

	private bool UpdateInCover() { }

	protected bool UpdateMove(bool updateVisibility) { }

	protected void UpdateMoveToCover() { }

	protected override void UpdateMoveToShoot() { }

	public virtual void UpdateNodeByBrain(ShootHoldResultParams data) { }

	public void UpdateUseCover(CoreActionResultParams data) { }

}

