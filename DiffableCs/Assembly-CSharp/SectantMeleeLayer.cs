//Type is in global namespace

public class SectantMeleeLayer : AbstractSectantLayerFight
{
	public const float SDIST_TREE_CLOSE = 900; //Field offset: 0x0
	private const float MAX_KNIFE_ATTACK_DURATION_IN = 15; //Field offset: 0x0
	private const float MAX_KNIFE_ATTACK_DURATION_OUT = 9; //Field offset: 0x0
	private const float TRULY_DIST_ATTACK_BACK = 15; //Field offset: 0x0
	private const float TRULY_DIST_ATTACK = 8; //Field offset: 0x0
	private const float MAX_KNIFE_ATTACK_DURATION = 9; //Field offset: 0x0
	private const float LOOK_TO_SECTANT_PERIOD = 2; //Field offset: 0x0
	private const float KNIFE_ATTACK_PERIOD = 10; //Field offset: 0x0
	private const float DIST_HIT_ANYWAY = 3; //Field offset: 0x0
	private const float COVER_MIN_MAX_DIST_ENEMY = 25; //Field offset: 0x0
	private const float TRULY_DIST_ATTACK_OUT = 8; //Field offset: 0x0
	private const float REVANGE_MELEE_DIST = 40; //Field offset: 0x0
	private const float COVER_MIN_DIST_ENEMY = 4; //Field offset: 0x0
	private const float CLOSE_COVER_AFTER_ATTACK_SEC = 10; //Field offset: 0x0
	public const float COVER_MIN_MAX_DIST_ENEMY_IN = 10; //Field offset: 0x0
	public const float COVER_MIN_MAX_DIST_ENEMY_OUT = 25; //Field offset: 0x0
	private const float CHANCE_RUN_ZIG_ZAG = 50; //Field offset: 0x0
	private const float CHANCE_RUN_IS_TOO_CLOSE_100 = 50; //Field offset: 0x0
	public const float SDIST_TREE_CLOSE_LONG = 2025; //Field offset: 0x0
	private const float BULLETFEAL_PERIOD_SEC = 10; //Field offset: 0x0
	private const float BULLET_DIST_ATTACK = 15; //Field offset: 0x0
	private const float TRULY_DIST_ATTACK_IN = 7; //Field offset: 0x0
	public const float UNDER_FIRE_DELTA = 30; //Field offset: 0x0
	private float _trulyDistAttack; //Field offset: 0x90
	private float _lastBulletNear; //Field offset: 0x94
	private BossSectantPriest _bossSectant; //Field offset: 0x98
	private float _nextTimeCheckCover; //Field offset: 0xA0
	private float _startMeleeAttack; //Field offset: 0xA4
	private Vector3 _corePoint; //Field offset: 0xA8
	private readonly SectantWarriorLayersStrategy _warrior; //Field offset: 0xB8
	private float _nextPathCheck; //Field offset: 0xC0
	private bool _lastPathCheck; //Field offset: 0xC4
	private float _nextCoverFarPeriodEnd; //Field offset: 0xC8
	private bool _endCauseMinorRndPeriod; //Field offset: 0xCC
	private float _endRavangeTime; //Field offset: 0xD0
	private bool _isIndoor; //Field offset: 0xD4
	private float _chanceRunZigZag; //Field offset: 0xD8
	private string _shortName; //Field offset: 0xE0
	private float _maxKnifeProcess; //Field offset: 0xE8
	private AIPeriodAction _changeAct; //Field offset: 0xF0

	private float IndoorDistNotToAttack
	{
		private get { } //Length: 58
	}

	public SectantMeleeLayer(BotOwner bot, int priority, SectantWarriorLayersStrategy warrior) { }

	private bool CanHitNow() { }

	public bool CanRunToEnemyWithShortPath() { }

	private bool CheckIsGoodForHide(CustomNavigationPoint pointOfSearch) { }

	private bool CoverIsBad() { }

	public virtual void Dispose() { }

	private void DoChnageToMelee() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	private float get_IndoorDistNotToAttack() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsAtDifferentObjects() { }

	public bool IsCoverGoodForRun(CustomNavigationPoint targetCustomNavigPoint) { }

	public virtual string Name() { }

	private void NextCoverFar() { }

	protected virtual void OnActivate() { }

	private void OnBulletNear(BotOwner bot, IPlayer source) { }

	private void OnEnemyHitted(BotOwner arg1, Player trg) { }

	public void SetBoss(BossSectantPriest sectantPriest) { }

	public void SetCorePosition(Vector3 corePoint) { }

	public void SetInside(bool isIndoorZone) { }

	public void SetRavangeMode() { }

	public virtual bool ShallUseNow() { }

	private BotLogicDecision TryAttackWithKnife(bool anyway = false) { }

}

