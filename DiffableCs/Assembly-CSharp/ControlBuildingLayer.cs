//Type is in global namespace

public class ControlBuildingLayer : BaseLogicLayer
{
	public const float PERIOD_NO_VISION = 1; //Field offset: 0x0
	public const float WAIT_PERIOD_SEC = 900; //Field offset: 0x0
	private const bool ENTRANCE_CLOSE_TO_TARGET = True; //Field offset: 0x0
	private float _nextCheckBetter; //Field offset: 0x90
	private float _nextTryThrowGrenade; //Field offset: 0x94
	protected float _nextClosestsError; //Field offset: 0x98
	private float _periodRecheck; //Field offset: 0x9C

	protected override int TargetEnvironmentId
	{
		 get { } //Length: 187
	}

	protected override Nullable TargetPosition
	{
		 get { } //Length: 212
	}

	public ControlBuildingLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndRunToEnemyZigZag() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	protected virtual AICoreActionEnd EndSuppressGrenade() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	protected override int get_TargetEnvironmentId() { }

	protected override Nullable get_TargetPosition() { }

	public virtual AICoreActionResult GetDecision() { }

	protected CoverSearchData GetSearchData() { }

	private bool IsCurCoverGood() { }

	protected bool IsGoodPoint(GroupPoint point) { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	private void PeriodicCheckWantThrowGrenade() { }

	private bool RefreshTryFindBetter() { }

	public virtual bool ShallUseNow() { }

}

