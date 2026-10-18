//Type is in global namespace

public class PatrolStayAtPositionLayer : BaseLogicLayer
{
	public const float SDIST_TREE_CLOSE = 900; //Field offset: 0x0
	protected Vector3 _corePosition; //Field offset: 0x90
	protected CustomNavigationPoint _cachedPoint; //Field offset: 0xA0
	private readonly float GOOD_SDIST; //Field offset: 0xA8
	protected bool _shallRecheck; //Field offset: 0xAC
	private bool _usePeriodForceReched; //Field offset: 0xAD
	private float _nextCheckPoint; //Field offset: 0xB0
	private float _nextCheckForcePoint; //Field offset: 0xB4
	protected bool _tryFinGreenFirst; //Field offset: 0xB8
	private AIPeriodAction _tryReloadUnderballer; //Field offset: 0xC0
	private CoverLevel _minGreenPointCoverLevel; //Field offset: 0xC8

	public PatrolStayAtPositionLayer(BotOwner bot, int priority, bool tryFinGreenFirst, CoverLevel minGreenPointCoverLevel = 2, bool usePeriodForceReched = false) { }

	protected virtual AICoreActionEnd EndAlternativePatrol() { }

	protected virtual AICoreActionEnd EndFollowerPatrolItem() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	private CustomNavigationPoint FindNextPoint() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	protected override CustomNavigationPoint GetPoint() { }

	protected override bool IsPointGood(CustomNavigationPoint cachedPoint) { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	public virtual void OnDrawGizmos() { }

	protected override CustomNavigationPoint PointBetter(CustomNavigationPoint b, CustomNavigationPoint a) { }

	protected void RecheckPositions() { }

	public void SetCorePosition(Vector3 corePosition) { }

	public virtual bool ShallUseNow() { }

	protected bool TryFindGreenPoint(Nullable friendClose, out CustomNavigationPoint point) { }

	protected bool TryFindSimplePoint(out CustomNavigationPoint cachedPoint) { }

	private void TryReloadUnderballer() { }

}

