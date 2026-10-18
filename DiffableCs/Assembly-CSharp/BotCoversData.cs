//Type is in global namespace

public class BotCoversData : BotData, ICoversData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public BotCoversData <>4__this; //Field offset: 0x10
		public float minSDistToEnemy; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal bool <GetFreeClosePoint>b__0(GroupPoint p) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass11_0
	{
		public Vector3 pos; //Field offset: 0x0
		public float sDist; //Field offset: 0xC
		public List list; //Field offset: 0x10
		public BotCoversData <>4__this; //Field offset: 0x18

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public BotCoversData <>4__this; //Field offset: 0x10
		public CoverLevel coverLvl; //Field offset: 0x18
		public bool checkPlaceID; //Field offset: 0x1C
		public Nullable placeId; //Field offset: 0x20
		public Nullable friendCover; //Field offset: 0x28
		public bool checksDistMinToTarget; //Field offset: 0x3C
		public Nullable trg; //Field offset: 0x40
		public float sDistMinToTarget; //Field offset: 0x50

		public <>c__DisplayClass12_0() { }

		internal bool <ClosestGreenPoint>b__0(GroupPoint p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Nullable placeId; //Field offset: 0x10
		public bool onlyWithInsideCover; //Field offset: 0x18
		public float minLvl; //Field offset: 0x1C
		public Nullable friednData; //Field offset: 0x20
		public BotCoversData <>4__this; //Field offset: 0x38

		public <>c__DisplayClass14_0() { }

		internal bool <FindHidePoint>b__0(GroupPoint point) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public BotCoversData <>4__this; //Field offset: 0x10
		public Vector3 trg; //Field offset: 0x18
		public float sMinDist; //Field offset: 0x24
		public Func isGood; //Field offset: 0x28

		public <>c__DisplayClass15_0() { }

		internal bool <FindClosestPoint>b__0(GroupPoint point) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Vector3 botPos; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <CarePositions>b__0(Vector3 position) { }

	}

	public IBotOwner LastClosestFriend; //Field offset: 0x18
	public float LastClosestFriendSDist; //Field offset: 0x20
	public CoverFinderAnalyzer CoverFinderAnalyzer; //Field offset: 0x28
	private readonly CoverFindGraphFunc _аFindByGraph; //Field offset: 0x30
	[CompilerGenerated]
	private CoverSearchData <LastSearchData>k__BackingField; //Field offset: 0x38

	public override int ConnectionGroupId
	{
		 get { } //Length: 38
	}

	public override CustomNavigationPoint LastCustomNavigationPoint
	{
		 get { } //Length: 45
	}

	public private CoverSearchData LastSearchData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotCoversData(BotOwner owner) { }

	[CompilerGenerated]
	private void <GetClosePoints>g__AddFromVoxel|11_0(NavGraphVoxelSimple voxel, ref <>c__DisplayClass11_0 unnamed_param_1) { }

	public override HashSet CarePositions() { }

	public Nullable ClosestFriendCoverPoint(Vector3 closeToPoint) { }

	public Nullable ClosestFriendCoverPoint() { }

	public CustomNavigationPoint ClosestGreenPoint(Vector3 pos, out float sDist, float minDistToTarget = 0, Nullable trg = null, Nullable placeId = null, Nullable friendCover = null, CoverLevel coverLvl = 0, bool printErrorLogsIfFail = false) { }

	public void Dispose() { }

	public float DistToClosestFriend() { }

	[CanBeNull]
	public CustomNavigationPoint FindClosestPoint(Vector3 pos, float minDistToTarget, Vector3 trg, bool noRestrictions = false, Func isGood = null, bool printErrorLogsIfFail = false) { }

	[CanBeNull]
	public CustomNavigationPoint FindHidePoint(Vector3 pos, float minLvl, Nullable friednData = null, bool onlyWithInsideCover = false, Nullable placeId = null, bool printErrorLogsIfFail = false) { }

	public override int get_ConnectionGroupId() { }

	public override CustomNavigationPoint get_LastCustomNavigationPoint() { }

	[CompilerGenerated]
	public CoverSearchData get_LastSearchData() { }

	public List GetClosePoints(Vector3 pos, float dist) { }

	public override GroupPoint GetClosest(Vector3 center, int connectionGroupId) { }

	public override GroupPoint GetClosestByClosestsVoxeles(Vector3 center) { }

	[CanBeNull]
	public IBotOwner GetClosestFriend(out float sqrDist) { }

	public CustomNavigationPoint GetClosestPoint(Vector3 pos, Func goodFunc = null, bool printErrorLogsIfFail = false, int maxIterations = 1000) { }

	public CustomNavigationPoint GetFreeClosePoint(Vector3 pos, float minSDistToEnemy, bool printErrorLogsIfFail = false) { }

	[CanBeNull]
	public List GetVoxelesInRadius(int step) { }

	private override CustomNavigationPoint ICoversData.FindClosestPoint(Vector3 pos, bool noRestrictions, Func goodFunc) { }

	private override CustomNavigationPoint ICoversData.GetFreeClosePoint(Vector3 pos, float minSDistToEnemy) { }

	public void Init() { }

	private bool IsGoodBushPoint(GroupPoint point, CoverLevel minCoverLevel) { }

	[CompilerGenerated]
	private void set_LastSearchData(CoverSearchData value) { }

	public void SetClose() { }

	public void SetLastCoverSearchInfo(CoverSearchData data) { }

	public void SetLong() { }

}

