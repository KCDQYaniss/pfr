//Type is in global namespace

public class BossKillaAgroFightLayerClose : BaseLogicLayer
{
	private const float ENEMY_PURSUIT_TIME = 20; //Field offset: 0x0
	private const float SUPPRESSED_STATE_DURATION = 7; //Field offset: 0x0
	private CustomNavigationPoint _coverInMiddle; //Field offset: 0x90
	private readonly List _curentInfos; //Field offset: 0x98
	private bool _nextFindAnyway; //Field offset: 0xA0
	private readonly BotsConnections _connections; //Field offset: 0xA8
	private float _lastSuppressFireTime; //Field offset: 0xB0
	private int _cachedCloseEnemies; //Field offset: 0xB4
	private float _prevCloseEnemiesTimeCompute; //Field offset: 0xB8
	private float _blockZIgZagUntil; //Field offset: 0xBC
	private bool _cachedAnywayAttack; //Field offset: 0xC0
	private float _nextPossibleThrow; //Field offset: 0xC4
	private float _nextCheckCoverInMiddle; //Field offset: 0xC8

	private BotGlobalsBossSettings BossSettings
	{
		private get { } //Length: 45
	}

	private float CLOSE_ATTACK_DIST
	{
		private get { } //Length: 9
	}

	private float MELEE_ATTACK_DIST
	{
		private get { } //Length: 9
	}

	public BossKillaAgroFightLayerClose(BotOwner bot, int priority) { }

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

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	private BotGlobalsBossSettings get_BossSettings() { }

	private float get_CLOSE_ATTACK_DIST() { }

	private float get_MELEE_ATTACK_DIST() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsCoverReliable() { }

	private bool IsEnemiesSuppressed() { }

	private bool IsSuppressed(EnemyInfo enemy) { }

	public virtual string Name() { }

	protected void RecheckCoverAtMiddle() { }

	public virtual bool ShallUseNow() { }

	protected CoverSearchData ShootData() { }

	private AICoreActionResult ShootFromPlaceOrGo() { }

	private bool WantFinishPursuit() { }

	private bool WantSuppressEnemy() { }

}

