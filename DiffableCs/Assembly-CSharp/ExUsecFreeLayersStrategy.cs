//Type is in global namespace

public class ExUsecFreeLayersStrategy : ExUsecAbstractStrategy
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int APPLY_CORE_FROM_BOSS_MAX_ATTEMPTS = 3; //Field offset: 0x0
	private const int FALLBACK_CORE_OFFSET_ATTEMPTS = 5; //Field offset: 0x0
	private const float FALLBACK_CORE_OFFSET_MAX = 5; //Field offset: 0x0
	private const float FALLBACK_CORE_OFFSET_MIN = 1; //Field offset: 0x0
	private const float PERSONAL_CORE_OFFSET_MAX = 10; //Field offset: 0x0
	private const float PERSONAL_CORE_OFFSET_MIN = 5; //Field offset: 0x0
	private const int FORCE_ATTACK_LAYER = 17; //Field offset: 0x0
	private const int EXUSEC_REQUEST = 15; //Field offset: 0x0
	private const int WARNS_LAYER = 12; //Field offset: 0x0
	private const int STAY_AT_CORE = 18; //Field offset: 0x0
	private const int FIGHT_REQUEST = 9; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 11; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int PATROL_REQUEST = 4; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int PATROL_FOLLOWER_LOGIC = 7; //Field offset: 0x0
	private const int PATROL_UTILITY = 8; //Field offset: 0x0
	private const int ENEMY_LOGIC2 = 6; //Field offset: 0x0
	private readonly HashSet _insidePlayers; //Field offset: 0x60
	private readonly PatrolStayAtPositionLayerWithIndoor _patrolStayAtCore; //Field offset: 0x68
	private readonly BossFinder _bossFinder; //Field offset: 0x70
	private readonly Vector3 _personalCoreOffset; //Field offset: 0x78
	private bool _doOffKilla; //Field offset: 0x84
	private float _killaTimeOff; //Field offset: 0x88
	private bool _corePointApplied; //Field offset: 0x8C
	private int _applyCoreFromBossAttempts; //Field offset: 0x90

	public ExUsecFreeLayersStrategy(BotOwner owner) { }

	private void ActivateAttackZone() { }

	private static Vector3 CreatePersonalCoreOffset() { }

	private static Vector3 CreateRandomHorizontalOffset(float minDist, float maxDist) { }

	public virtual void Dispose() { }

	private void DisposeAttackZone() { }

	protected virtual BotEventsPriority EventsPriority() { }

	private static bool IsEnvironmentIndoor(EnvironmentManagerBase env, Vector3 pos) { }

	public virtual void ManualUpdate() { }

	private void OnBecomeBoss(BotOwner boss) { }

	private void OnBossFound() { }

	private void OnEnemyRemove(IPlayer obj) { }

	private void OnPlayerEnter(Player obj) { }

	private void OnPlayerExit(Player obj) { }

	private void OnSomeBodyBeingHit(DamageInfo damageInfo, Player victim) { }

	private void RemovePlayer(IPlayer person) { }

	private static Vector3 ResolvePersonalCorePosition(Vector3 corePoint, Vector3 personalOffset) { }

	public virtual string ShortName() { }

	private void TryApplyCoreFromBoss() { }

	private void TryOffAttackMode() { }

}

