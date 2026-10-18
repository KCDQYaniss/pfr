//Type is in global namespace

[Extension]
public static class AIUtility
{
	public const int DIRS_COUNT = 8; //Field offset: 0x0
	public static List BaseDirections; //Field offset: 0x0
	public static List BaseDirections8; //Field offset: 0x8
	public static readonly List AllBaseSides; //Field offset: 0x10
	private static bool isShuffled; //Field offset: 0x18
	private static readonly Dictionary shuffledDirections; //Field offset: 0x20

	private static AIUtility() { }

	private static void AddShuffledDirections(Vector3 startDir, int[] indexOfDirs) { }

	public static bool CanShoot(BotOwner bot, EnemyInfo enemyInfo) { }

	public static bool CanShoot(Vector3 from, EnemyInfo enemyInfo) { }

	public static bool CanShootToTarget(ShootToPoint shootToPoint, CustomNavigationPoint point, LayerMask mask, bool doubleSide = false) { }

	public static bool CanShootToTarget(ShootToPoint shootToPoint, GroupPointSearchData point, LayerMask mask, bool doubleSide = false) { }

	public static bool CanShootToTarget(ShootToPoint shootToPoint, Vector3 firePos, LayerMask mask, bool doubleSide = false) { }

	private static Vector3[] ClosestDirs(Vector3 dir) { }

	public static List CovnertToSave(List points) { }

	public static BotWeaponScattering[] DebugBotScatterings() { }

	public static void DebugDrawArc(Vector3 p1, Vector3 p2, float height, float duration, Color color) { }

	public static void DebugDrawWay(Vector3[] way, Vector3 offset, Color c, float duration = 10) { }

	public static void DebugDrawWay(T[] way, Vector3 offset, Color c, float duration = 10) { }

	public static void DrawGroups(List nearGroups, Vector3 CenterPos, CoverPointSaveData betterPoint, HashSet cantHide = null) { }

	public static void DrawGroups(List nearGroups, Vector3 CenterPos, CustomNavigationPoint betterPoint) { }

	[Extension]
	public static void ExceptWith(List thisList, List other) { }

	public static Nullable GetCrossPoint(SegmentPoints p1, SegmentPoints p2) { }

	public static Nullable GetCrossPoint(Vector3 a1, Vector3 b1, Vector3 a2, Vector3 b2) { }

	public static int GetNearEntity(Vector3 susPoint, List points) { }

	public static int GetNearEntity(Vector3 susPoint, IPositionPoint[] points) { }

	public static int GetNearEntity(int count, Func getSegment) { }

	public static int GetNearEntity(Vector3 susPoint, List points) { }

	public static Vector3 GetProjectionPoint(Vector3 p, Vector3 p1, Vector3 p2) { }

	public static bool HaveWall(Vector3 from, Vector3 to, float dist = 4) { }

	public static void Init() { }

	[Extension]
	public static bool IsDisabledAtLocalGame(WildSpawnType t) { }

	public static bool IsPointInside(Vector3 point, Vector3 s, Vector3 e) { }

	public static bool IsPointInsideDangerZone(BotOwner bot, Vector3 point) { }

	public static bool IsPointOnWay(Vector3[] path, Vector3 p, float distToBeClose, int startIndex, int maxPointToCheck = 5) { }

	public static Vector3 LerpPointWithControl(Vector3 start, Vector3 trg, Vector3 control, float time) { }

	public static float MaxRayDist8HorizontalSides(Vector3 startPos, out RaycastHit rayMax, float maxDist = 200) { }

	public static string ParentsLog(GameObject go) { }

	public static bool PointInOABB(Vector3 point, BoxCollider box) { }

	public static bool PointInOABB(Vector3 point, Vector3 boxPos, Vector3 boxSize) { }

	public static bool PointInOABB(Vector3 point, Transform boxPos, Vector3 boxSize, Vector3 centerOffset) { }

	private static Point PointOfIntersection(Point p1, Point p2, Point p3, Point p4) { }

	public static float SDistHorizontal(Vector3 v) { }

	public static Vector3 Test4Sides(Vector3 dir, Vector3 headPos) { }

	public static bool TestDir(Vector3 headPos, Vector3 dir, float dist) { }

	public static bool TestDir(Vector3 headPos, Vector3 dir, float dist, out Nullable outPos) { }

	[Extension]
	public static string WideLog(Vector3 v) { }

}

