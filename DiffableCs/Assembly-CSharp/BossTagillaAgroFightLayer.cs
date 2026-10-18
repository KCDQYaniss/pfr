//Type is in global namespace

public class BossTagillaAgroFightLayer : BossTagillaAbstractLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public BossTagillaAgroFightLayer <>4__this; //Field offset: 0x10
		public float d; //Field offset: 0x18
		public CustomNavigationPoint p; //Field offset: 0x20
		public bool v; //Field offset: 0x28

		public <>c__DisplayClass67_0() { }

		internal void <HavePointCloseForSupress>b__0(CustomNavigationPoint point) { }

	}

	internal enum ETagillaBattleLogic
	{
		Ambush = 1,
		Default = 2,
		MeleeAssault = 3,
	}

	private const float CLOSE_ENEMIES_UPDATE_PERIOD = 3; //Field offset: 0x0
	private const float COMPUTE_PATH_LENGTH_PERIOD = 0.35; //Field offset: 0x0
	private const int DANGER_ENEMIES_AMOUNT = 3; //Field offset: 0x0
	private const float ENEMY_PURSUIT_TIME = 20; //Field offset: 0x0
	private const float KNIFE_ATTACK_PERIOD = 0.1; //Field offset: 0x0
	private const float SAVAGE_CALL_PERIOD = 5; //Field offset: 0x0
	private const float SAVAGE_LAST_ENEMY_SEEN_TIME_TO_BE_FREE = 10; //Field offset: 0x0
	private const float SUPPRESSED_STATE_DURATION = 7; //Field offset: 0x0
	private bool _cachedMeleeAssaultDecision; //Field offset: 0xB0
	private int _closeRuns; //Field offset: 0xB4
	private CustomNavigationPoint _coverInMiddle; //Field offset: 0xB8
	private readonly List _curentInfos; //Field offset: 0xC0
	private bool _nextFindAnyway; //Field offset: 0xC8
	private float _canRefreshSearchAtMiddle; //Field offset: 0xCC
	private float _runCanCalcWay; //Field offset: 0xD0
	private readonly BotDistCheck _botDistCheck; //Field offset: 0xD8
	private readonly BotsConnections _connections; //Field offset: 0xE0
	private float _lastMeleeAttackEndTime; //Field offset: 0xE8
	private Vector3 _lastRunZigZagPos; //Field offset: 0xEC
	private float _cachedMeleeDistToEnemy; //Field offset: 0xF8
	private bool _meleeAssaultInProgress; //Field offset: 0xFC
	private float _pathToEnemyLength; //Field offset: 0x100
	private float _prevComputePathLengthTime; //Field offset: 0x104
	private bool _lastAssaultRollResult; //Field offset: 0x108
	private float _lastAssaultRollTime; //Field offset: 0x10C
	private float _lastSavageCallTime; //Field offset: 0x110
	private bool _savagesCalled; //Field offset: 0x114
	private float _lastSuppressFireTime; //Field offset: 0x118
	private int _cachedCloseEnemies; //Field offset: 0x11C
	private float _prevCloseEnemiesTimeCompute; //Field offset: 0x120
	private float _blockZIgZagUntil; //Field offset: 0x124
	private bool _cachedAnywayAttack; //Field offset: 0x128
	private float _nextPossibleThrow; //Field offset: 0x12C

	private BotGlobalsBossSettings BossSettings
	{
		private get { } //Length: 45
	}

	private float CLOSE_ATTACK_DIST
	{
		private get { } //Length: 9
	}

	public float MIDDLE_ATTACK_DIST
	{
		 get { } //Length: 58
	}

	public BossTagillaAgroFightLayer(BotOwner bot, int priority) { }

	private AICoreActionResult AssaultMode() { }

	private AICoreActionResult CloseDist() { }

	private int CloseEnemiesCount(out bool anywayAttack, bool resetCache = false) { }

	private AICoreActionResult DefenceMode() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	protected virtual AICoreActionEnd EndSuppressGrenade() { }

	private AICoreActionResult FarDist() { }

	private AICoreActionResult FarestDist() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	private BotGlobalsBossSettings get_BossSettings() { }

	private float get_CLOSE_ATTACK_DIST() { }

	public float get_MIDDLE_ATTACK_DIST() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HavePointCloseForSupress(ShootToPoint shootPos, float dist, out CustomNavigationPoint pos) { }

	public Nullable InFightLogicTagilla() { }

	private bool IsBadCover() { }

	private bool IsEnemiesSuppressed() { }

	private bool IsSuppressed(EnemyInfo enemy) { }

	private AICoreActionResult MidDist() { }

	public virtual string Name() { }

	private BotLogicDecision RunIfCan() { }

	private BotLogicDecision RunZigZag() { }

	public virtual bool ShallUseNow() { }

	private AICoreActionResult ShootFromPlaceOrGo() { }

	private AICoreActionResult Suppress(bool grenadePriority, BotLogicDecision doThisIfCant) { }

	private bool TryThrowAmbushGrenade(ThrowWeapType grenadeType, out AICoreActionResult decision) { }

	private bool WantFinishPursuit() { }

	private bool WantSprintToNextCover() { }

	private bool WantSuppressEnemy() { }

	private bool WantThrowGrenade(int closeEnemies) { }

}

