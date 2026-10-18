//Type is in global namespace

public class BossTagillaHelpsKillaLayer : BossTagillaAbstractLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public BossTagillaHelpsKillaLayer <>4__this; //Field offset: 0x10
		public float d; //Field offset: 0x18
		public CustomNavigationPoint p; //Field offset: 0x20
		public bool v; //Field offset: 0x28

		public <>c__DisplayClass57_0() { }

		internal void <HavePointCloseForSupress>b__0(CustomNavigationPoint point) { }

	}

	private const int DANGER_ENEMIES_AMOUNT = 3; //Field offset: 0x0
	private const float SUPPRESSED_STATE_DURATION = 7; //Field offset: 0x0
	private const float ENEMY_PURSUIT_TIME = 20; //Field offset: 0x0
	private const float CLOSE_ENEMIES_UPDATE_PERIOD = 3; //Field offset: 0x0
	private BotOwner _killa; //Field offset: 0xB0
	private bool _cachedMeleeAssaultDecision; //Field offset: 0xB8
	private ETagillaBattleLogic _logic; //Field offset: 0xBC
	private int _closeRuns; //Field offset: 0xC0
	private CustomNavigationPoint _coverInMiddle; //Field offset: 0xC8
	private readonly List _curentInfos; //Field offset: 0xD0
	private bool _nextFindAnyway; //Field offset: 0xD8
	private float _runCanCalcWay; //Field offset: 0xDC
	private readonly BotDistCheck _botDistCheck; //Field offset: 0xE0
	private readonly BotsConnections _connections; //Field offset: 0xE8
	private float _lastMeleeAttackEndTime; //Field offset: 0xF0
	private Vector3 _lastRunZigZagPos; //Field offset: 0xF4
	private float _cachedMeleeDistToEnemy; //Field offset: 0x100
	private bool _meleeAssaultInProgress; //Field offset: 0x104
	private float _pathToEnemyLength; //Field offset: 0x108
	private float _prevComputePathLengthTime; //Field offset: 0x10C
	private bool _lastAssaultRollResult; //Field offset: 0x110
	private float _lastAssaultRollTime; //Field offset: 0x114
	private float _lastSavageCallTime; //Field offset: 0x118
	private bool _savagesCalled; //Field offset: 0x11C
	private float _lastSuppressFireTime; //Field offset: 0x120
	private int _cachedCloseEnemies; //Field offset: 0x124
	private float _prevCloseEnemiesTimeCompute; //Field offset: 0x128
	private bool _cachedAnywayAttack; //Field offset: 0x12C

	private BotGlobalsBossSettings BossSettings
	{
		private get { } //Length: 45
	}

	public BossTagillaHelpsKillaLayer(BotOwner bot, int priority) { }

	private AICoreActionResult AssaultMode() { }

	private void CheckKilla() { }

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

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	private AICoreActionResult FarDist() { }

	private AICoreActionResult FarestDist() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	private BotGlobalsBossSettings get_BossSettings() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HavePointCloseForSupress(ShootToPoint shootPos, float dist, out CustomNavigationPoint pos) { }

	public Nullable InFightLogic() { }

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

