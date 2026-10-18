//Type is in global namespace

public class BossTagillaAgroFightLayerClose : BossTagillaAbstractLayer
{
	private const int DANGER_ENEMIES_AMOUNT = 2; //Field offset: 0x0
	private const float ENEMY_PURSUIT_TIME = 20; //Field offset: 0x0
	private const float SUPPRESSED_STATE_DURATION = 7; //Field offset: 0x0
	private CustomNavigationPoint _coverInMiddle; //Field offset: 0xB0
	private readonly List _curentInfos; //Field offset: 0xB8
	private bool _nextFindAnyway; //Field offset: 0xC0
	private readonly BotsConnections _connections; //Field offset: 0xC8
	private float _lastSuppressFireTime; //Field offset: 0xD0
	private float MELEE_ATTACK_DIST; //Field offset: 0xD4
	private float CLOSE_ATTACK_DIST; //Field offset: 0xD8
	private float PERIOD_HELPER_SEEN_TO_MELEE; //Field offset: 0xDC
	private float _nextCheckCoverInMiddle; //Field offset: 0xE0
	private float _nextPossibleHeal; //Field offset: 0xE4

	private BotGlobalsBossSettings BossSettings
	{
		private get { } //Length: 45
	}

	public BossTagillaAgroFightLayerClose(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToCoverZigZag() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndSearch() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	protected virtual AICoreActionEnd EndSuppressGrenade() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	private BotGlobalsBossSettings get_BossSettings() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsBadCover() { }

	private bool IsCoverReliable(CustomNavigationPoint point) { }

	private bool IsEnemiesSuppressed() { }

	private bool IsMeleeBcloked() { }

	private bool IsSuppressed(EnemyInfo enemy) { }

	public virtual string Name() { }

	protected void RecheckCoverAtMiddle() { }

	public virtual bool ShallUseNow() { }

	protected CoverSearchData ShootData() { }

	private AICoreActionResult ShootFromPlaceOrGo() { }

	private bool WantFinishPursuit() { }

	private bool WantMeleeAssault() { }

	private bool WantSprintToNextCover() { }

	private bool WantSuppressEnemy() { }

}

