//Type is in global namespace

public class VSRFAssault : BaseLogicLayer
{
	public const float PERIOD_TO_HEAL = 20; //Field offset: 0x0
	public const float GO_TO_ENEMY_PERIOD = 10; //Field offset: 0x0
	public const float GO_TO_ENEMY_REFRESH = 15; //Field offset: 0x0
	private float _nextCheckCoverInMiddle; //Field offset: 0x90
	private float _coverPeriodEnds; //Field offset: 0x94
	private PeriodicCheck _сanMoveToNextRndPos; //Field offset: 0x98
	protected CustomNavigationPoint _coverInMiddle; //Field offset: 0xA0
	private float _endGoToEnemy; //Field offset: 0xA8
	private float _canNextGo; //Field offset: 0xAC
	private float _startShootFromPlace; //Field offset: 0xB0
	private float _shootFromPeriod; //Field offset: 0xB4

	public VSRFAssault(BotOwner bot, int priority) { }

	private bool CanMoveToNextRndPos() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HaveSeenRecently(EnemyInfo enemy) { }

	public virtual string Name() { }

	protected void RecheckCoverAtMiddle() { }

	public virtual bool ShallUseNow() { }

	protected CoverSearchData ShootData() { }

	private bool ShouldHeal() { }

}

