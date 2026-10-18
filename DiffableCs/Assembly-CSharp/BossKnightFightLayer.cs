//Type is in global namespace

public class BossKnightFightLayer : BaseLogicLayer
{
	private const float ATTACK_MOVING_TO_COVER_DIST_GAP = -49; //Field offset: 0x0
	private const int CAN_SHOOT_PERIOD_MAX_BIG = 30; //Field offset: 0x0
	private const int CAN_SHOOT_PERIOD_MAX_SMALL = 7; //Field offset: 0x0
	private const int CAN_SHOOT_PERIOD_MIN_BIG = 8; //Field offset: 0x0
	private const int CAN_SHOOT_PERIOD_MIN_SMALL = 4; //Field offset: 0x0
	private const float CHEST_RERCENT_HEALTH = 0.52; //Field offset: 0x0
	private const float DIST_TO_ATTACK_IF_NO_COVERS = 15; //Field offset: 0x0
	private const float FIRST_TIME_SHOOT_SEC = 2; //Field offset: 0x0
	protected const int SHOOT_FROM_PLACE_PERIOD = 3; //Field offset: 0x0
	private const float HEAL_PERIODS = 3; //Field offset: 0x0
	private const float HOLD_BEFORE_ATTACK_PERIOD = 2; //Field offset: 0x0
	private const int ONE_BOSS_CAN_SHOOT_FROM_PLACE = 20; //Field offset: 0x0
	private const float PERIOD_CHECK_GOOD_POS_SEC = 0.5; //Field offset: 0x0
	private const float PERIOD_SHOOT_FROM_PLACE_LAST_HEAL = 5; //Field offset: 0x0
	private const float PERIOD_SHOOT_FROM_PLACE_LEAVE_COVER = 3; //Field offset: 0x0
	private const float SEC_PERIOD_TO_HEAL_NEAR_BOSS = 22; //Field offset: 0x0
	private const float SHEARCH_COVER_NEAR_PERIOD = 3; //Field offset: 0x0
	private const float HIT_UNDER_HEAL_SHOOT_FROM_PLACE = 5; //Field offset: 0x0
	private const float STAY_IN_COVER_TO_USE_STIMULATORS = 10; //Field offset: 0x0
	protected const int SHOOT_FROM_PLACE_BIG = 8; //Field offset: 0x0
	protected const float SHOOT_FROM_COVER_END_PERIOD_BIG = 8; //Field offset: 0x0
	private const float NEVER_SEEN = -1000; //Field offset: 0x0
	private const float NOT_IN_FIGHT_LAYER = -1000; //Field offset: 0x0
	private const float SPOT_COVER_TIME = 32; //Field offset: 0x0
	private const float RUN_TO_GO_DIST = 10; //Field offset: 0x0
	private const float SQR_COVER_SAFE_DISTANCE = 2500; //Field offset: 0x0
	private const int TOO_MANY_CLOSE_TIMES = 2; //Field offset: 0x0
	protected const float CORIDOR_NO_ENEMY = 8; //Field offset: 0x0
	protected const float SHOOT_FROM_COVER_END_PERIOD_SMALL = 3; //Field offset: 0x0
	protected const int MAX_ITERATIONS_FIGHT_BIG = 20; //Field offset: 0x0
	protected const int MAX_ITERATIONS_HEAL_BIG = 15; //Field offset: 0x0
	protected const int MAX_ITERATIONS_HEAL_SMALL = 8; //Field offset: 0x0
	protected const float SDIST_COVER_FIGHT_BIG = 1600; //Field offset: 0x0
	protected const float SDIST_COVER_FIGHT_SMALL = 256; //Field offset: 0x0
	protected const float SDIST_COVER_HEAL__START_BIG = 1600; //Field offset: 0x0
	protected const float SDIST_COVER_HEAL_BIG = 144; //Field offset: 0x0
	protected const float SDIST_COVER_HEAL_SMALL = 100; //Field offset: 0x0
	protected const int MAX_ITERATIONS_FIGHT_SMALL = 6; //Field offset: 0x0
	private const float STAY_POINT_MAX_SDIST = 4; //Field offset: 0x0
	private bool _healAsked; //Field offset: 0x90
	private float _beginRunToCoverTime; //Field offset: 0x94
	private bool _forcedLay; //Field offset: 0x98
	private float _suppressStartTime; //Field offset: 0x9C
	private float _beginShootFromCoverSqrDist; //Field offset: 0xA0
	private float _lastLeaveCoverTime; //Field offset: 0xA4
	private float _lastThrowGrenadeTime; //Field offset: 0xA8
	private float _prevHoldTime; //Field offset: 0xAC
	public bool DEBUG_ALWAYS_BAD_HEALTH; //Field offset: 0xB0
	public bool DEBUG_ALWAYS_NOASK_HEAL; //Field offset: 0xB1
	protected float sDistToCloseToBoss; //Field offset: 0xB4
	protected CustomNavigationPoint _pointOfSearch; //Field offset: 0xB8
	protected BossKnight _knightBoss; //Field offset: 0xC0
	protected bool _lastPointFight; //Field offset: 0xC8
	protected bool _isCoridorZone; //Field offset: 0xC9
	protected float _nextPosibleSearchCloseBossPoint; //Field offset: 0xCC
	private float _shootFromPlacePeriod; //Field offset: 0xD0
	private int _nextPeriodCheckGood; //Field offset: 0xD4
	private readonly float _lastHealUse; //Field offset: 0xD8
	private float _nextCheckParts; //Field offset: 0xDC
	private bool _shallUseStimulators; //Field offset: 0xE0
	private bool _shallUseFirstAid; //Field offset: 0xE1
	private bool _shallGoToHeal; //Field offset: 0xE2
	private bool _lastCheckCanShootFromCover; //Field offset: 0xE3
	private float _startShootFromPlace; //Field offset: 0xE4
	private float _nextCheckPointTime; //Field offset: 0xE8
	private readonly float _deltaWannaKill; //Field offset: 0xEC
	private float _nextRefresh; //Field offset: 0xF0
	private float _enterFightLayerTime; //Field offset: 0xF4
	private float _lastDesicionTime; //Field offset: 0xF8
	private float _lastGoToAskBossHeal; //Field offset: 0xFC
	private float _cantShootStart; //Field offset: 0x100
	private float _period; //Field offset: 0x104
	private bool _lastIsGoodForFightPeriod; //Field offset: 0x108
	private float _periodCheckGoodFight; //Field offset: 0x10C
	private int _timesNotGood; //Field offset: 0x110
	private float _nextPosibleRunToEnemyRecalc; //Field offset: 0x114
	private int _findClosePointsTimes; //Field offset: 0x118
	private float _lastHaveEnemySeenTime; //Field offset: 0x11C
	private int _badCovers; //Field offset: 0x120
	private readonly HashSet _coridorZones; //Field offset: 0x128
	private bool _underHeal; //Field offset: 0x130
	private float _hitUnderHeal; //Field offset: 0x134
	private bool _inited; //Field offset: 0x138
	private float _lastCoverTime; //Field offset: 0x13C

	protected bool _use2covers
	{
		 get { } //Length: 57
	}

	public BossKnightFightLayer(BotOwner bot, int priority) { }

	protected bool CanSearchNextNearBoss() { }

	private bool CanShootToTargetPeriod() { }

	public override HashSet CarePositions() { }

	private void CheckCurPoint(bool anyway = false) { }

	private bool CheckIsGoodForFight(CustomNavigationPoint checkPoint) { }

	private bool CheckIsGoodForHeal(CustomNavigationPoint pointOfSearch) { }

	public virtual void Dispose() { }

	private void DropTimes() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndRunToEnemyZigZag() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	protected bool EnemyNear() { }

	private bool EnemyWaitingTimeExpired() { }

	private void ExtraRunToEnemyFindCover() { }

	private CustomNavigationPoint FightPoint() { }

	private void FindNewPoint() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public CustomNavigationPoint FindPointForAssault(bool checkCurrent) { }

	public CustomNavigationPoint FindPointForFight(bool checkCurrent) { }

	public CustomNavigationPoint FindPointForFight() { }

	public CustomNavigationPoint FindPointForHeal() { }

	public CustomNavigationPoint FindPointForStay() { }

	public CustomNavigationPoint FindPointNearBoss() { }

	public void ForceRecalcShootPos() { }

	protected bool get__use2covers() { }

	protected Vector3 GetBossPosition() { }

	public virtual AICoreActionResult GetDecision() { }

	private AICoreActionResult GoToPlaceForShoot() { }

	private bool GroupHaveEnemy(bool includeSelf = true) { }

	private bool HaveCoveToHide() { }

	private bool IsAfterGoToEnemy() { }

	private bool IsAmNearBoss() { }

	private bool IsCoridorPointBad() { }

	private bool IsDamaged() { }

	protected bool IsEnemyIsFarForCoridors() { }

	protected bool IsOnlyFightCovers() { }

	public virtual string Name() { }

	private bool NeedToHelpTeam() { }

	protected virtual void OnActivate() { }

	private void OnEndApplyFirtsAid(BotOwner obj) { }

	private void OnGetHit(DamageInfo arg1, EBodyPart arg2, float arg3) { }

	private void OnHealAsked(IPlayer obj) { }

	public void OnLayerChanged(AICoreLayer layer) { }

	private void OnStartApplyFirtsAid(BotOwner obj) { }

	private bool ReadyShootToSmoke() { }

	private AICoreActionResult RunToEnemy(string label) { }

	public void SetBossData(BossKnight bossData) { }

	public virtual bool ShallUseNow() { }

	private bool TryGoToBoss(out Vector3 posToGo) { }

	private bool WannaHeal(out bool healByAnother, out bool isAmNearBoss) { }

	private bool WannaKill(float period) { }

	private bool WantUseStimulatros() { }

}

