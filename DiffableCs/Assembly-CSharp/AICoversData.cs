//Type is in global namespace

public class AICoversData : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__102_0; //Field offset: 0x8
		public static Func <>9__102_1; //Field offset: 0x10
		public static Func <>9__102_2; //Field offset: 0x18
		public static Func <>9__102_3; //Field offset: 0x20
		public static Func <>9__102_4; //Field offset: 0x28
		public static Func <>9__102_5; //Field offset: 0x30
		public static Func <>9__102_6; //Field offset: 0x38
		public static Func <>9__102_7; //Field offset: 0x40
		public static Func <>9__102_8; //Field offset: 0x48
		public static Func <>9__102_9; //Field offset: 0x50
		public static Func <>9__111_0; //Field offset: 0x58
		public static Func <>9__111_1; //Field offset: 0x60
		public static Func <>9__114_0; //Field offset: 0x68
		public static Func <>9__120_3; //Field offset: 0x70
		public static Func <>9__120_4; //Field offset: 0x78
		public static Func <>9__120_6; //Field offset: 0x80

		private static <>c() { }

		public <>c() { }

		internal bool <CalcVoxelesCountTest>b__114_0(NavGraphVoxelSimple x) { }

		internal int <GetNextPathId>b__111_0(GroupPointWay x) { }

		internal int <GetNextPathId>b__111_1(GroupPointPath x) { }

		internal bool <OnDrawGizmosSelected>b__120_3(GroupPoint x) { }

		internal bool <OnDrawGizmosSelected>b__120_4(GroupPoint x) { }

		internal bool <OnDrawGizmosSelected>b__120_6(GroupPoint x) { }

		internal bool <RestoreData>b__102_0(GroupPoint x) { }

		internal bool <RestoreData>b__102_1(GroupPoint x) { }

		internal bool <RestoreData>b__102_2(GroupPoint x) { }

		internal bool <RestoreData>b__102_3(GroupPoint x) { }

		internal bool <RestoreData>b__102_4(GroupPoint x) { }

		internal bool <RestoreData>b__102_5(NavGraphVoxelSimple x) { }

		internal bool <RestoreData>b__102_6(NavGraphVoxelSimple x) { }

		internal bool <RestoreData>b__102_7(NavGraphVoxelSimple x) { }

		internal bool <RestoreData>b__102_8(GroupPoint x) { }

		internal bool <RestoreData>b__102_9(GroupPoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass125_0
	{
		public GroupPoint toClose; //Field offset: 0x10

		public <>c__DisplayClass125_0() { }

		internal int <GetClosests>g__SortGroups|0(GroupPoint x, GroupPoint y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass126_0
	{
		public AICoversData <>4__this; //Field offset: 0x10
		public Vector3 pos; //Field offset: 0x18

		public <>c__DisplayClass126_0() { }

		internal Vector3 <GetClosest>b__0(int i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass127_0
	{
		public int connectionGroupId; //Field offset: 0x10
		public List connectionGroupOnly; //Field offset: 0x18
		public Vector3 pos; //Field offset: 0x20

		public <>c__DisplayClass127_0() { }

		internal bool <GetClosest>b__0(GroupPoint x) { }

		internal Vector3 <GetClosest>b__1(int i) { }

	}

	[SerializeField]
	public List Points; //Field offset: 0x20
	public AIVoxelesData Voxels; //Field offset: 0x28
	public AIPatrolsData Patrols; //Field offset: 0x30
	public AIMiddleGraphContainer MiddleGraph; //Field offset: 0x38
	public AIManualPointsHolder AIManualPointsHolder; //Field offset: 0x40
	public AICorePointHolder AICorePointsHolder; //Field offset: 0x48
	public AIMinesPositionsHolder AIMinesPositions; //Field offset: 0x50
	public AIDangerPlacesHolder AIDangerPlacesHolder; //Field offset: 0x58
	public AIPlaceInfoHolder AIPlaceInfoHolder; //Field offset: 0x60
	public BotZoneEntranceInfo EntranceInfo; //Field offset: 0x68
	public List Pathes; //Field offset: 0x70
	public List Ways; //Field offset: 0x78
	[SerializeField]
	private int _lastId; //Field offset: 0x80
	private int _lastPathId; //Field offset: 0x84
	private AICoversDataCache _cache; //Field offset: 0x88
	public bool DrawPointsWithCore; //Field offset: 0x90
	public bool DrawPointsWays; //Field offset: 0x91
	public bool DrawPoints; //Field offset: 0x92
	public bool DrawPointsOnlyBush; //Field offset: 0x93
	public bool DrawPointsOnlyIsGoodInsideBuilding; //Field offset: 0x94
	public bool DrawPointsOnlyIdEnvironment; //Field offset: 0x95
	public ECoverPointSpecial DrawPointsSpecial; //Field offset: 0x98
	public string SelectedPointsCount; //Field offset: 0xA0
	public int DrawPlaceId; //Field offset: 0xA8
	public int DrawCorePoint; //Field offset: 0xAC
	public int DrawConnectionGroup; //Field offset: 0xB0
	public float GroupPonitUpRay; //Field offset: 0xB4
	public int DistDraw; //Field offset: 0xB8
	[CompilerGenerated]
	private int <BushCovers>k__BackingField; //Field offset: 0xBC
	[CompilerGenerated]
	private int <AlwaysGood>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private int <WallCovers>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private int <ShootCovers>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private int <AmbushCovers>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	private int <VoxelesWithDoorsByObjects>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private int <VoxelesWithDoors>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	private int <VoxelesWithEntrances>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private int <PointsSingleFoliage>k__BackingField; //Field offset: 0xDC
	[CompilerGenerated]
	private int <PointsSingle>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private Dictionary <PointsByConnectionsGroup>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private HashSet <ConnectionsGroupCount>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private HashSet <CorePointsGroupByObjects>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private HashSet <CorePointsGroup>k__BackingField; //Field offset: 0x100
	public string NetSteps; //Field offset: 0x108
	public string UnconnctedMiniGroups; //Field offset: 0x110
	public string CoverByPortals; //Field offset: 0x118

	public private int AlwaysGood
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int AmbushCovers
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int BushCovers
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private HashSet ConnectionsGroupCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private HashSet CorePointsGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private HashSet CorePointsGroupByObjects
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Vector3 MaxVoxelesValues
	{
		 get { } //Length: 41
	}

	public int MaxX
	{
		 get { } //Length: 26
	}

	public int MaxY
	{
		 get { } //Length: 26
	}

	public int MaxZ
	{
		 get { } //Length: 26
	}

	public Vector3 MinVoxelesValues
	{
		 get { } //Length: 41
	}

	public private Dictionary PointsByConnectionsGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int PointsSingle
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int PointsSingleFoliage
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int ShootCovers
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public NavGraphVoxelSimple[,,] VoxelesArray
	{
		 get { } //Length: 27
	}

	public private int VoxelesWithDoors
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int VoxelesWithDoorsByObjects
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int VoxelesWithEntrances
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public List VoxelsList
	{
		 get { } //Length: 27
	}

	public private int WallCovers
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public AICoversData() { }

	[CompilerGenerated]
	private bool <OnDrawGizmosSelected>b__120_0(GroupPoint x) { }

	[CompilerGenerated]
	private bool <OnDrawGizmosSelected>b__120_1(GroupPoint x) { }

	[CompilerGenerated]
	private bool <OnDrawGizmosSelected>b__120_2(GroupPoint x) { }

	[CompilerGenerated]
	private bool <OnDrawGizmosSelected>b__120_5(GroupPoint x) { }

	public void AddFoliagePoint(List grass, AITriangleData triangles) { }

	public void AddPath(GroupPointPath path) { }

	public void AddPortalPoint(GroupPoint point, AITriangleData triangles, NavTriangle triangle) { }

	public void AddRange(List blanketPoints) { }

	public void CachePoints() { }

	public void CalcVoxelesCountTest() { }

	public void Clear() { }

	public void ClearDoors() { }

	public void ClearLootPoints() { }

	private void ConnectPointAndTriangle(NavPoint navPoint, NavTriangle triangle, AITriangleData data) { }

	public static AICoversData CreateOrFind(bool undestandAtGame = false) { }

	public bool DeletePath(GroupPointPath path) { }

	private static NavPoint FindNavPointOfTriangle(AITriangleData triangles, GroupPoint point) { }

	[CompilerGenerated]
	public int get_AlwaysGood() { }

	[CompilerGenerated]
	public int get_AmbushCovers() { }

	[CompilerGenerated]
	public int get_BushCovers() { }

	[CompilerGenerated]
	public HashSet get_ConnectionsGroupCount() { }

	[CompilerGenerated]
	public HashSet get_CorePointsGroup() { }

	[CompilerGenerated]
	public HashSet get_CorePointsGroupByObjects() { }

	public Vector3 get_MaxVoxelesValues() { }

	public int get_MaxX() { }

	public int get_MaxY() { }

	public int get_MaxZ() { }

	public Vector3 get_MinVoxelesValues() { }

	[CompilerGenerated]
	public Dictionary get_PointsByConnectionsGroup() { }

	[CompilerGenerated]
	public int get_PointsSingle() { }

	[CompilerGenerated]
	public int get_PointsSingleFoliage() { }

	[CompilerGenerated]
	public int get_ShootCovers() { }

	public NavGraphVoxelSimple[,,] get_VoxelesArray() { }

	[CompilerGenerated]
	public int get_VoxelesWithDoors() { }

	[CompilerGenerated]
	public int get_VoxelesWithDoorsByObjects() { }

	[CompilerGenerated]
	public int get_VoxelesWithEntrances() { }

	public List get_VoxelsList() { }

	[CompilerGenerated]
	public int get_WallCovers() { }

	public GroupPoint GetClosest(Vector3 pos) { }

	public GroupPoint GetClosest(Vector3 pos, int connectionGroupId) { }

	public static List GetClosests(GroupPoint toClose, int count, List toChoose) { }

	public GroupPoint GetClosestsPointInVoxelesExtended(int x, int y, int z, int rad, Vector3 pos, Nullable cg, bool withFoliage = true) { }

	public List GetCovers(int botId) { }

	public int GetGroupPointNextId() { }

	public Vector3Int GetIndexes(Vector3 pos) { }

	public int GetNextPathId() { }

	public List GetVoxelesExtended(int x, int y, int z, int rad, bool onlyWithPoints) { }

	public NavGraphVoxelSimple GetVoxelSafe(Vector3 pos, bool withLogs = false) { }

	private static NavGraphVoxelSimple GetVoxelSafeAndNear(AICoversData covers, Vector3 from) { }

	public NavGraphVoxelSimple GetVoxelSafeByIndexes(int x, int y, int z) { }

	public void InitForGamePoints() { }

	private void OnDrawGizmosSelected() { }

	public void RemovePoint(GroupPoint point) { }

	public bool RestoreData() { }

	[CompilerGenerated]
	private void set_AlwaysGood(int value) { }

	[CompilerGenerated]
	private void set_AmbushCovers(int value) { }

	[CompilerGenerated]
	private void set_BushCovers(int value) { }

	[CompilerGenerated]
	private void set_ConnectionsGroupCount(HashSet value) { }

	[CompilerGenerated]
	private void set_CorePointsGroup(HashSet value) { }

	[CompilerGenerated]
	private void set_CorePointsGroupByObjects(HashSet value) { }

	[CompilerGenerated]
	private void set_PointsByConnectionsGroup(Dictionary value) { }

	[CompilerGenerated]
	private void set_PointsSingle(int value) { }

	[CompilerGenerated]
	private void set_PointsSingleFoliage(int value) { }

	[CompilerGenerated]
	private void set_ShootCovers(int value) { }

	[CompilerGenerated]
	private void set_VoxelesWithDoors(int value) { }

	[CompilerGenerated]
	private void set_VoxelesWithDoorsByObjects(int value) { }

	[CompilerGenerated]
	private void set_VoxelesWithEntrances(int value) { }

	[CompilerGenerated]
	private void set_WallCovers(int value) { }

}

