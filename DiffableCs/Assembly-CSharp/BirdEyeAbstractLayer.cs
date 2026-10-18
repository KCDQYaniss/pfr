//Type is in global namespace

public abstract class BirdEyeAbstractLayer : BaseLogicLayer
{
	protected const float DIST_SHOOT_FROM_PLACE = 30; //Field offset: 0x0
	protected CustomNavigationPoint _cacheCover; //Field offset: 0x90
	protected int MIN_ERFECT_ATTACK_DIST; //Field offset: 0x98
	protected int PERFECT_ATTACK_DIST; //Field offset: 0x9C
	private float _nextRefreshFindPoint; //Field offset: 0xA0
	protected float _blockRunUntil; //Field offset: 0xA4
	protected float _waitShootUntil; //Field offset: 0xA8
	protected ShootToPoint _pointICanShoot; //Field offset: 0xB0

	protected BirdEyeAbstractLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndLayNode() { }

	private void FindCachePoint(ShootToPoint posibleTarget) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	protected AICoreActionResult GetFinalDecision(bool replaceShoot, BotFindPlaceToShoot findPlaceToShoot, ShootToPoint shootToPoint) { }

	protected abstract ShootToPoint GetShootPoint() { }

	protected void PeriodRefreshFindPoint(ShootToPoint curShootPoint) { }

	protected AICoreActionResult ShootFromPlaceWithTime(string cause) { }

}

