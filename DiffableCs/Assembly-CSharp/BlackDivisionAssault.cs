//Type is in global namespace

public class BlackDivisionAssault : BlackDivisionAbstract
{
	public const float ASSAULT_DIST = 30; //Field offset: 0x0
	private float _nextCheckCoverInMiddle; //Field offset: 0x98
	private float _coverPeriodEnds; //Field offset: 0x9C
	private PeriodicCheck _canStartAssault; //Field offset: 0xA0
	private PeriodicCheck _сanMoveToNextCover; //Field offset: 0xA8
	protected CustomNavigationPoint _coverInMiddle; //Field offset: 0xB0
	protected int PERIOD_TO_HEAL; //Field offset: 0xB8
	private float _gotoEnemyStart; //Field offset: 0xBC
	private int _cantFindCoef; //Field offset: 0xC0

	public BlackDivisionAssault(BotOwner bot, int priority) { }

	private bool CanIRunAssault() { }

	private bool CanMoveToNextCover() { }

	private bool CanStartAssault() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsAnyOneSee() { }

	public virtual string Name() { }

	protected void RecheckCoverAtMiddle() { }

	public virtual bool ShallUseNow() { }

	protected CoverSearchData ShootData() { }

	private bool ShouldHeal() { }

}

