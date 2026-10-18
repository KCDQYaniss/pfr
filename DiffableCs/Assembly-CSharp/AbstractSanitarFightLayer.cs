//Type is in global namespace

public abstract class AbstractSanitarFightLayer : BaseLogicLayer
{
	protected const float CORIDOR_NO_ENEMY = 8; //Field offset: 0x0
	private const float STAY_POINT_MAX_SDIST = 4; //Field offset: 0x0
	private const float STAY_IN_COVER_TO_USE_STIMULATORS = 10; //Field offset: 0x0
	private const float SHEARCH_COVER_NEAR_PERIOD = 3; //Field offset: 0x0
	private const float SEC_PERIOD_TO_HEAL_NEAR_BOSS = 22; //Field offset: 0x0
	private const float PERIOD_SHOOT_FROM_PLACE_LEAVE_COVER = 3; //Field offset: 0x0
	private const float PERIOD_SHOOT_FROM_PLACE_LAST_HEAL = 5; //Field offset: 0x0
	private const float PERIOD_CHECK_GOOD_POS_SEC = 0.5; //Field offset: 0x0
	private const int ONE_BOSS_CAN_SHOOT_FROM_PLACE = 20; //Field offset: 0x0
	private const float HOLD_BEFORE_ATTACK_PERIOD = 2; //Field offset: 0x0
	private const float HIT_UNDER_HEAL_SHOOT_FROM_PLACE = 5; //Field offset: 0x0
	private const float HEAL_PERIODS = 3; //Field offset: 0x0
	private const float FIRST_TIME_SHOOT_SEC = 2; //Field offset: 0x0
	private const float DIST_TO_ATTACK_IF_NO_COVERS = 15; //Field offset: 0x0
	private const float CHEST_RERCENT_HEALTH = 0.52; //Field offset: 0x0
	private const int CAN_SHOOT_PERIOD_MIN_SMALL = 4; //Field offset: 0x0
	private const int TOO_MANY_CLOSE_TIMES = 2; //Field offset: 0x0
	private const int CAN_SHOOT_PERIOD_MAX_SMALL = 7; //Field offset: 0x0
	private const int CAN_SHOOT_PERIOD_MIN_BIG = 8; //Field offset: 0x0
	protected const int MAX_ITERATIONS_FIGHT_BIG = 14; //Field offset: 0x0
	protected const int MAX_ITERATIONS_FIGHT_SMALL = 6; //Field offset: 0x0
	protected const int MAX_ITERATIONS_HEAL_BIG = 15; //Field offset: 0x0
	protected const float SDIST_COVER_FIGHT_BIG = 900; //Field offset: 0x0
	protected const float SDIST_COVER_FIGHT_SMALL = 256; //Field offset: 0x0
	protected const float SDIST_COVER_HEAL__START_BIG = 1600; //Field offset: 0x0
	protected const int MAX_ITERATIONS_HEAL_SMALL = 8; //Field offset: 0x0
	protected const float SDIST_COVER_HEAL_SMALL = 100; //Field offset: 0x0
	protected const float SHOOT_FROM_COVER_END_PERIOD_BIG = 8; //Field offset: 0x0
	protected const float SHOOT_FROM_COVER_END_PERIOD_SMALL = 3; //Field offset: 0x0
	protected const int SHOOT_FROM_PLACE_BIG = 8; //Field offset: 0x0
	protected const int SHOOT_FROM_PLACE_PERIOD = 3; //Field offset: 0x0
	private const int CAN_SHOOT_PERIOD_MAX_BIG = 30; //Field offset: 0x0
	protected const float SDIST_COVER_HEAL_BIG = 144; //Field offset: 0x0
	public bool DEBUG_ALWAYS_BAD_HEALTH; //Field offset: 0x90
	public bool DEBUG_ALWAYS_NOASK_HEAL; //Field offset: 0x91
	protected float sDistToCloseToBoss; //Field offset: 0x94
	protected CustomNavigationPoint _pointOfSearch; //Field offset: 0x98
	protected IBossSanitar _sanitarBoss; //Field offset: 0xA0
	protected bool _lastPointFight; //Field offset: 0xA8
	protected bool _isCoridorZone; //Field offset: 0xA9
	protected float _nextPosibleSearchCloseBossPoint; //Field offset: 0xAC
	private float _shootFromPlacePeriod; //Field offset: 0xB0
	private int _nextPeriodCheckGood; //Field offset: 0xB4
	private readonly float _lastHealUse; //Field offset: 0xB8
	private float _nextCheckParts; //Field offset: 0xBC
	private float _lastEndRunToCover; //Field offset: 0xC0
	private bool _shallUseStimulators; //Field offset: 0xC4
	private bool _shallUseFirstAid; //Field offset: 0xC5
	private bool _shallGoToHeal; //Field offset: 0xC6
	private bool _lastCheckCanShootFromCover; //Field offset: 0xC7
	private float _startShootFromPlace; //Field offset: 0xC8
	private float _nextCheckPointTime; //Field offset: 0xCC
	private readonly float _deltaWannaKill; //Field offset: 0xD0
	private float _nextRefresh; //Field offset: 0xD4
	private float _lastDesicionTime; //Field offset: 0xD8
	private float _lastGoToAskBossHeal; //Field offset: 0xDC
	private float _cantShootStart; //Field offset: 0xE0
	private float _period; //Field offset: 0xE4
	private bool _lastIsGoodForFightPeriod; //Field offset: 0xE8
	private float _periodCheckGoodFight; //Field offset: 0xEC
	private int _timesNotGood; //Field offset: 0xF0
	private float _nextPosibleRunToEnemyRecalc; //Field offset: 0xF4
	private int _findClosePointsTimes; //Field offset: 0xF8
	private readonly HashSet _coridorZones; //Field offset: 0x100
	private bool _underHeal; //Field offset: 0x108
	private float _hitUnderHeal; //Field offset: 0x10C

	protected bool _use2covers
	{
		 get { } //Length: 57
	}

	protected AbstractSanitarFightLayer(BotOwner bot, int priority) { }

	protected bool CanSearchNextNearBoss() { }

	private bool CanShootToTargetPeriod() { }

	public override HashSet CarePositions() { }

	private void CheckCurPoint(bool anyway = false) { }

	private bool CheckIsGoodForFight(CustomNavigationPoint checkPoint) { }

	private bool CheckIsGoodForHeal(CustomNavigationPoint pointOfSearch) { }

	public virtual void Dispose() { }

	private void DropTimes() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	private void ExtraRunToEnemyFindCover() { }

	private CustomNavigationPoint FightPoint() { }

	private void FindCloseToEnemyPoint() { }

	private void FindNewPoint() { }

	public abstract CustomNavigationPoint FindPointForFight(bool checkCurrent) { }

	public CustomNavigationPoint FindPointForHeal() { }

	public CustomNavigationPoint FindPointForStay() { }

	public CustomNavigationPoint FindPointNearBoss() { }

	public void ForceRecalcShootPos() { }

	protected bool get__use2covers() { }

	protected Vector3 GetBossPosition() { }

	public virtual AICoreActionResult GetDecision() { }

	private AICoreActionResult GoToPlaceForShoot(bool wannaKill) { }

	private bool HaveCoveToHide() { }

	private bool IsAmNearBoss() { }

	private bool IsCoridorPointBad() { }

	private bool IsDamaged() { }

	protected bool IsEnemyIsFarForCoridors() { }

	protected bool IsOnlyFightCovers() { }

	protected virtual void OnActivate() { }

	private void OnEndApplyFirtsAid(BotOwner obj) { }

	private void OnGetHit(DamageInfo arg1, EBodyPart arg2, float arg3) { }

	private void OnStartApplyFirtsAid(BotOwner obj) { }

	public void SetBossData(IBossSanitar bossData) { }

	private bool TryGoToBoss(out Vector3 posToGo) { }

	private bool WannaHeal(out bool healByAnother, out bool isAmNearBoss) { }

	private bool WannaKill(float period) { }

	private bool WantUseStimulatros() { }

}

