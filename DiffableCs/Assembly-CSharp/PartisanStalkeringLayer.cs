//Type is in global namespace

public class PartisanStalkeringLayer : BaseLogicLayer
{
	private const float NO_PROVOCATION_SDIST_CAUSE_FAR_FROM_MINES = 2500; //Field offset: 0x0
	private const float PROVOCATION_DIST = 60; //Field offset: 0x0
	private const float PerfectDist = 50; //Field offset: 0x0
	private const float LARGE_DIST = 70; //Field offset: 0x0
	private const float WAIT_IN_COVER_TO_DO_NEXT_MINES = 90; //Field offset: 0x0
	private bool _isMinesPlanted; //Field offset: 0x90
	private CustomNavigationPoint _lastChoose; //Field offset: 0x98
	private float _provocationHold; //Field offset: 0xA0
	private float _lastShootToProvocation; //Field offset: 0xA4
	private float _lastTimeChoose; //Field offset: 0xA8
	private float _nextProvocationPeriod; //Field offset: 0xAC

	public PartisanStalkeringLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private bool <RefreshNewPoint>b__16_0(GroupPoint x) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndMoveStealthy() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	private bool FarFromLastMine(Vector3 groupPoint) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsCloseTooLastChoose() { }

	public virtual string Name() { }

	private void OnMinesCacheCompleted() { }

	private void OnMinesStartCache() { }

	private void RefreshNewPoint() { }

	protected void SayProvocaionPeriod() { }

	public virtual bool ShallUseNow() { }

	private bool TryRefreshPoint(out AICoreActionEnd aiCoreActionEnd) { }

	private bool WanProvocationShoot() { }

}

