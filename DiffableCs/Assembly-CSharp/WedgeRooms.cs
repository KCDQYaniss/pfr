//Type is in global namespace

public class WedgeRooms : BaseWedgeLayer
{
	private const float STIM_COOLDOWN_SEC = 30; //Field offset: 0x0
	private const float STIM_NEED_NO_PERSONAL_SIGHT_SEC = 15; //Field offset: 0x0
	public const float STEP_AWAY_DIST = 5; //Field offset: 0x0
	private readonly BossWedgeDistTracker _distTracker; //Field offset: 0xB0
	private CustomNavigationPoint _coverInMiddle; //Field offset: 0xB8
	private float _nextRefreshCover; //Field offset: 0xC0
	private float _lastChangeCover; //Field offset: 0xC4
	private bool _endAttacklMoving; //Field offset: 0xC8
	private int _curPlaceId; //Field offset: 0xCC

	public WedgeRooms(BotOwner bot, int priority, BossWedgeDistTracker distTracker) { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndAttackMovingFlankToPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private bool GetHitRecently() { }

	private bool GoodPickCover(GroupPoint arg) { }

	public virtual string Name() { }

	private bool SawEnemyLongTime() { }

	private bool ShallTryStimulatorsInRooms(EnemyInfo enemy) { }

	public virtual bool ShallUseNow() { }

	protected CoverSearchData ShootDataCover() { }

	private bool ShouldDoSuppress() { }

	private void TryRefreshCover() { }

	private bool WannaHelp() { }

}

