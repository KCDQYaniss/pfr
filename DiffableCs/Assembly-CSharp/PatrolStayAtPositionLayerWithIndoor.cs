//Type is in global namespace

public class PatrolStayAtPositionLayerWithIndoor : PatrolStayAtPositionLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public PatrolStayAtPositionLayerWithIndoor <>4__this; //Field offset: 0x10
		public Nullable placeId; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal bool <FindIndoorPointNearCore>b__0(GroupPoint point) { }

	}

	private const float INDOOR_HOLD_RECHECK_FAIL_PERIOD = 5; //Field offset: 0x0
	private const float INDOOR_HOLD_RECHECK_SUCCESS_PERIOD = 50; //Field offset: 0x0
	private readonly string _name; //Field offset: 0xD0
	private bool _isIndoor; //Field offset: 0xD8
	private bool _useGroupPlacement; //Field offset: 0xD9
	private float _groupPlacementMinSDist; //Field offset: 0xDC
	private float _groupPlacementMaxSDist; //Field offset: 0xE0
	private int _groupPlacementPlaceId; //Field offset: 0xE4
	private float _nextIndoorHoldCheck; //Field offset: 0xE8

	public PatrolStayAtPositionLayerWithIndoor(BotOwner bot, int priority, bool canUseGreenPoints) { }

	[CompilerGenerated]
	private bool <FindGroupPlacementPoint>b__19_0(GroupPoint point) { }

	private void DrawCorePointGizmos() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	private CustomNavigationPoint FindGroupPlacementPoint() { }

	private CustomNavigationPoint FindIndoorPointNearCore() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	private CustomNavigationPoint GetPoint2(CoverSearchData data) { }

	protected virtual bool IsPointGood(CustomNavigationPoint cachedPoint) { }

	public virtual string Name() { }

	public virtual void OnDrawGizmos() { }

	public void SetGroupPlacement(float minDistFromCore, float maxDistFromCore, int placeId) { }

	public void SetInside(bool isIndoorZone) { }

	public virtual bool ShallUseNow() { }

}

