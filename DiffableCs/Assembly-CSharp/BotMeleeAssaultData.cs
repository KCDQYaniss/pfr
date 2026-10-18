//Type is in global namespace

public class BotMeleeAssaultData : BotData
{
	private const float COMPUTE_PATH_LENGTH_PERIOD = 0.35; //Field offset: 0x0
	private const float KNIFE_ATTACK_PERIOD = 0.1; //Field offset: 0x0
	protected AICoreActionEnd BaseFalseEndLogic; //Field offset: 0x18
	private float _prevComputePathLengthTime; //Field offset: 0x28
	private float _pathToEnemyLength; //Field offset: 0x2C
	private float _lastMeleeAttackCheckTime; //Field offset: 0x30
	private bool _meleeAssaultInProgress; //Field offset: 0x34
	private float _cachedMeleeDistToEnemy; //Field offset: 0x38
	private bool _cachedMeleeAssaultDecision; //Field offset: 0x3C
	private float _lastMeleeAttackEndTime; //Field offset: 0x40
	private float _lastAssaultRollTime; //Field offset: 0x44
	private bool _lastAssaultRollResult; //Field offset: 0x48
	private bool _cachePeriodForceRnd; //Field offset: 0x49
	private AIPeriodAction _forceChecker; //Field offset: 0x50

	private BotGlobalsBossSettings BossSettings
	{
		private get { } //Length: 45
	}

	public BotMeleeAssaultData(BotOwner owner) { }

	public AICoreActionResult AttackOrHoldOrShoot() { }

	public static BotMeleeAssaultData Create(BotOwner bot) { }

	public BotLogicDecision DoMeleeAssault() { }

	public BotLogicDecision DoSimpleAssault() { }

	public AICoreActionEnd EndOneMeleeAttack() { }

	private bool EnemyCloseEnoughToForcedMeleeAssault() { }

	private bool EnemyCloseEnoughToMeleeAssault() { }

	public bool EnemySprintingNow() { }

	private BotGlobalsBossSettings get_BossSettings() { }

	private bool IsEnemyLookToAnotherDir(EnemyInfo enemy) { }

	private bool LastShootEnemyPeriod(Player enemyPlayer) { }

	private bool MeleeAttackPeriodExpired() { }

	public float PathToEnemyLengthByNavMesh() { }

	private void PeriodForceRnd() { }

	private void ResetStatus() { }

	public void SetLastStartAttack() { }

	public bool WantMeleeAssault(bool cachedDecision = true) { }

	private bool WantMeleeAssaultInner(bool cachedDecision = true) { }

}

