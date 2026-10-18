//Type is in global namespace

public class BossKolontayFightLayer : BossKolontayBaseFightLayer
{
	private const float TIME_TO_SEE_TO_ATTACK = 5; //Field offset: 0x0
	private const float Y_DELTA = 1; //Field offset: 0x0
	private const float REACT_TO_SHOT_TIME = 1; //Field offset: 0x0
	protected CustomNavigationPoint _coverInMiddle; //Field offset: 0xC0
	private float _endPeriodAttack; //Field offset: 0xC8
	private float _canStopClose; //Field offset: 0xCC
	private readonly BossFinder _bossLogic; //Field offset: 0xD0
	private float _lastMeleeAttackCheckTime; //Field offset: 0xD8
	private bool _cachedMeleeAssaultDecision; //Field offset: 0xDC
	private float _nextCheckCoverInMiddle; //Field offset: 0xE0
	private string _cacheInfo; //Field offset: 0xE8
	private float _lastShotFromLongDistTime; //Field offset: 0xF0

	public BossKolontayFightLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private bool <RecheckCoverAtMiddle>b__22_0(GroupPoint point) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	protected void RecheckCoverAtMiddle() { }

	protected CoverSearchData RecheckCoverData() { }

	private void SetAssaultCanKill() { }

	private void SetMeStartMelee() { }

	public virtual bool ShallUseNow() { }

	private AICoreActionEnd SubEndRunToCover() { }

	public void UpdateLastFarShotTime() { }

	private bool WantHitMelee(bool fromDesicion, out string info) { }

	public bool WantMeleeAssault(out string info) { }

}

