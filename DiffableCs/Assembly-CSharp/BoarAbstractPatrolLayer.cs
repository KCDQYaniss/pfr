//Type is in global namespace

public abstract class BoarAbstractPatrolLayer : BoarAbstractLayer
{
	protected bool CAN_USE_STATIONARY_AT_PARTOL; //Field offset: 0xB0
	protected readonly float MAX_DIST_TO_SIT_AT_STATIONARY; //Field offset: 0xB4
	protected readonly float MAX_POINT_PRECACHE; //Field offset: 0xB8
	protected readonly float DIST_OFFSET; //Field offset: 0xBC
	protected readonly float MIN_DIST_RND_BOSS; //Field offset: 0xC0
	protected readonly float MAX_DIST_RND_BOSS; //Field offset: 0xC4
	protected Vector3 _offset; //Field offset: 0xC8
	protected StationaryWeaponLink _stationaryClose; //Field offset: 0xD8
	protected bool _canStayAtStationary; //Field offset: 0xE0
	private bool _calculatedOffset; //Field offset: 0xE1
	private float _recheckStationary; //Field offset: 0xE4
	protected float _endPosiibleCanTake; //Field offset: 0xE8

	protected BoarAbstractPatrolLayer(BotOwner bot, int priority, bool canUseStationary) { }

	protected void CalculateOffset(float minDistToBoss, float maxDistToBoss) { }

	protected bool CanUsestationary(StationaryWeaponLink link) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndShootFromStationary() { }

	protected virtual AICoreActionEnd EndSuppressStationary() { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual void ManualUpdate() { }

	protected virtual void OnActivate() { }

	private void OnActivateStationary() { }

	public virtual bool ShallUseNow() { }

}

