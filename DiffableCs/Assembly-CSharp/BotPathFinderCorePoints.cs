//Type is in global namespace

public class BotPathFinderCorePoints : BotData
{
	[CompilerGenerated]
	private struct <>c__DisplayClass6_0
	{
		public Action errorCallback; //Field offset: 0x0
		public Vector3 from; //Field offset: 0x8
		public GroupPoint coverFrom; //Field offset: 0x18
		public IAICorePointLink coverTo; //Field offset: 0x20

	}

	private const int PATHFIND_ERRORS_LIMIT_BEFORE_TELEPORT = 5; //Field offset: 0x0
	private const int FAIL_CALC_PATH_TIMES = 10; //Field offset: 0x0
	private static float _lastPrintErrorLog; //Field offset: 0x0
	public int StartsFromDebug; //Field offset: 0x18
	public float StartsDiffDebug; //Field offset: 0x1C
	private int _pathFindErrorsInRow; //Field offset: 0x20
	private BotMover botMover; //Field offset: 0x28
	private readonly BotPathController _pathController; //Field offset: 0x30
	private readonly AICoversData _covers; //Field offset: 0x38
	private readonly BotMoverLogicCollector _errorCollector; //Field offset: 0x40
	private int _failNavmeshTimes; //Field offset: 0x48
	private readonly BotMover _mover; //Field offset: 0x50
	private int _remainLogErrorTimes; //Field offset: 0x58
	[CompilerGenerated]
	private bool <SlowAtTheEnd>k__BackingField; //Field offset: 0x5C

	public private bool SlowAtTheEnd
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotPathFinderCorePoints(BotOwner owner, BotMover botMover, BotPathController pathController, AICoversData covers) { }

	[CompilerGenerated]
	internal static void <CalculatePathFull>g__PrintErrorLog|6_0(string sub, ref <>c__DisplayClass6_0 unnamed_param_1) { }

	public static EPathCalcResult CalculatePathFull(int connectionGroup, Vector3 from, IAICorePointLink coverTo, AICoversData covers, out Vector3[] path, Action errorCallback, bool mustHaveWay) { }

	public static EPathCalcResult CalculatePathFull(int connectionGroup, Vector3 from, Vector3 to, AICoversData covers, out Vector3[] path, bool onlyShortTrie = false, Action errorCallback = null, bool mustHaveWay = true) { }

	protected void CantFindWayErrorTraceLog() { }

	private NavMeshPathStatus CheckFails(Vector3 pos, bool mustHaveWay) { }

	private void ErrorLogCallback() { }

	public static bool FindPath(Vector3 f, Vector3 t, out Vector3[] corners) { }

	private static void FindPathBetweenCoreTest(AICorePoint coreFrom, AICorePoint coreTo) { }

	public static bool FindPathOfCores(AICorePoint from, AICorePoint to, out AICorePoint[] way) { }

	private static bool FindPathOfCoresByPoints(AICorePoint from, AICorePoint to, out Vector3[] way) { }

	public static void FindPathOfCoresTest(Vector3 f, Vector3 t) { }

	[CompilerGenerated]
	public bool get_SlowAtTheEnd() { }

	public static GroupPoint GetClosestPoint(AICoversData covers, Vector3 from, int connectionGroup) { }

	public static GroupPoint GetClosestPointWithWay(AICoversData covers, Vector3 from, int connectionGroup, out Vector3[] corners) { }

	public NavMeshPathStatus GoToPosition(IAICorePointLink target, bool slowAtTheEnd, float reachDist, bool getUpWithCheck, bool mustHaveWay) { }

	public NavMeshPathStatus GoToPosition(Vector3 target, bool slowAtTheEnd, float reachDist, bool getUpWithCheck, bool mustHaveWay, bool onlyShortTrie = false, bool force = false, bool slowCalcUsingNativeNavMesh = false) { }

	public static Vector3[] LinkWays(List ways) { }

	private bool PreStartWay(Vector3 pos, bool slowAtTheEnd, bool getUpWithCheck) { }

	[CompilerGenerated]
	private void set_SlowAtTheEnd(bool value) { }

	private static int SortByCost(AICorePoint x, AICorePoint y) { }

}

