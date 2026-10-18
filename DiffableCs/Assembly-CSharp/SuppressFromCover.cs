//Type is in global namespace

public class SuppressFromCover : ShootFromCover
{
	private const float MIN_SHOOT_DISTANCE_M_MIN = 5; //Field offset: 0x0
	private const float MIN_SHOOT_DISTANCE_M_MAX = 7; //Field offset: 0x0
	private const float BURST_DELAY_MIN = 0.15; //Field offset: 0x0
	private const float BURST_DELAY_MAX = 0.35; //Field offset: 0x0
	private const float BURST_TIME_MIN = 0.35; //Field offset: 0x0
	private const float BURST_TIME_MAX = 0.75; //Field offset: 0x0
	private const float HIDE_AFTER_BURST_MIN = 0.25; //Field offset: 0x0
	private const float HIDE_AFTER_BURST_MAX = 0.8; //Field offset: 0x0
	private const float LINECAST_RECHECK_PERIOD = 0.2; //Field offset: 0x0
	private const float LINECAST_FREE_PAUSE = 2.5; //Field offset: 0x0
	private const float LINECAST_START_OFFSET = 0.1; //Field offset: 0x0
	private const float NOT_SHOOT_PERIOD = 15; //Field offset: 0x0
	private const float SHOOT_PERIOD = 7; //Field offset: 0x0
	private readonly AimingToSuppressionPoint _supressAimig; //Field offset: 0x50
	private ShootCoverStatus _lastCoverStatus; //Field offset: 0x58
	private bool _cycleActive; //Field offset: 0x5C
	private float _burstStartTime; //Field offset: 0x60
	private float _burstEndTime; //Field offset: 0x64
	private float _peekEndTime; //Field offset: 0x68
	private float _minShootDistanceThisCycle; //Field offset: 0x6C
	private float _nextLineCastCheck; //Field offset: 0x70
	private bool _lastFreeCast; //Field offset: 0x74
	private Vector3 _lastShootResult; //Field offset: 0x78
	private float _nextChangeShoot; //Field offset: 0x84
	private bool _canShoot; //Field offset: 0x88

	public SuppressFromCover(BotOwner bot) { }

	private void ChangeShootPeriod() { }

	private void EnsureCycleInitialized() { }

	private bool IsLineFree(Vector3 toShoot, out Vector3 shootResult) { }

	private void OnCoverStatusChanged(ShootCoverStatus from, ShootCoverStatus to) { }

	private void ShootingPeriod(Vector3 correctedPoint) { }

	protected virtual bool ShootStatus() { }

	private bool TryGetSuppressionPoint(out Vector3 point) { }

	protected virtual void UpdateMoveToShoot() { }

}

