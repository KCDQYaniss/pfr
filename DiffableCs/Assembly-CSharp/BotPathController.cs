//Type is in global namespace

public class BotPathController : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		public Vector3 centerAvoid; //Field offset: 0x10
		public List subAvoids; //Field offset: 0x20

		public <>c__DisplayClass72_0() { }

		internal float <TryReplacePathAround>g__ClosetsToAvoidMany|1(List path) { }

		internal float <TryReplacePathAround>g__ClosetsToAvoidSingle|0(List path) { }

	}

	private const float SDIST_FROM_MINE = 25; //Field offset: 0x0
	private static NavMeshPath path1; //Field offset: 0x0
	private static NavMeshPath path2; //Field offset: 0x8
	private static NavMeshPath path3; //Field offset: 0x10
	private static NavMeshPath path1_2; //Field offset: 0x18
	private static NavMeshPath path2_2; //Field offset: 0x20
	public Action onPathCornerChanged; //Field offset: 0x18
	private string _pathStack; //Field offset: 0x20
	[CompilerGenerated]
	private string <CallstackPathComeFrom>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private float <PlayerRemainingDist>k__BackingField; //Field offset: 0x30
	private readonly DebugPathController _debugPathController; //Field offset: 0x38
	private AbstractBotPath _lastPath; //Field offset: 0x40
	private AbstractBotPath _curPath; //Field offset: 0x48
	private Vector3 _lastDestination; //Field offset: 0x50
	private Vector3 _prevCorner; //Field offset: 0x5C
	private Vector3 _currentCorner; //Field offset: 0x68
	[CompilerGenerated]
	private float <LastPathSetTime>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private float <LastEndPathTime>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnWayChanged; //Field offset: 0x80
	public Vector3 StopPos; //Field offset: 0x88
	private float OFFSET_TO_AVOID; //Field offset: 0x94
	private float PointTooClose; //Field offset: 0x98

	public event Action OnWayChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private string CallstackPathComeFrom
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private AbstractBotPath CurPath
	{
		 get { } //Length: 5
		private set { } //Length: 659
	}

	public Vector3 CurrentCornerPoint
	{
		 get { } //Length: 19
	}

	public bool HavePath
	{
		 get { } //Length: 9
	}

	public private float LastEndPathTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float LastPathSetTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public string PathStack
	{
		 get { } //Length: 5
	}

	public private float PlayerRemainingDist
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public Vector3 PrevCorner
	{
		 get { } //Length: 19
	}

	public Nullable TargetPoint
	{
		 get { } //Length: 200
	}

	private static BotPathController() { }

	public BotPathController(BotOwner owner) { }

	[CompilerGenerated]
	public void add_OnWayChanged(Action value) { }

	private List BetterPath(NavMeshPath p1, NavMeshPath p2, Vector3 fin, Func avoidFund) { }

	public float CalculatePathLength() { }

	public bool CheckShouldMove() { }

	public Vector3 CurrentCorner() { }

	public void DebugDrawLastWay() { }

	public void DrawSelectedGizmosLastWay() { }

	public void DrawSelectedGizmosWay() { }

	public Nullable FindPointFarThan(float dist, out int index) { }

	[CompilerGenerated]
	public string get_CallstackPathComeFrom() { }

	public AbstractBotPath get_CurPath() { }

	public Vector3 get_CurrentCornerPoint() { }

	public bool get_HavePath() { }

	[CompilerGenerated]
	public float get_LastEndPathTime() { }

	[CompilerGenerated]
	public float get_LastPathSetTime() { }

	public string get_PathStack() { }

	[CompilerGenerated]
	public float get_PlayerRemainingDist() { }

	public Vector3 get_PrevCorner() { }

	public Nullable get_TargetPoint() { }

	public List GetCornersFromIndex(int index) { }

	public Vector3[] GetWayPoints(int maxWayPoints) { }

	public void GoToByWay(Vector3[] way, float reachDist) { }

	public void GoToPointNoWay(Nullable trg) { }

	public bool GoToSamePoint(Vector3 trg) { }

	public void IncCornerIndex() { }

	public bool IsLast() { }

	public bool IsPointOnCurrentWay(Vector3 point, float maxDist) { }

	public bool IsSameWay(IAICorePointLink target, Vector3 ownerPosition) { }

	public bool IsSameWay(Vector3 target, Vector3 ownerPosition) { }

	public Vector3 LastDestination() { }

	public Vector3 LastTargetPoint(float distCoef) { }

	private List Merge(Vector3[] p1, Vector3[] p2) { }

	public void OnEndInteract() { }

	private void PathComplete(IPathTargetPoint obj) { }

	[CompilerGenerated]
	public void remove_OnWayChanged(Action value) { }

	public void ReturnToNavExtra() { }

	[CompilerGenerated]
	private void set_CallstackPathComeFrom(string value) { }

	private void set_CurPath(AbstractBotPath value) { }

	[CompilerGenerated]
	private void set_LastEndPathTime(float value) { }

	[CompilerGenerated]
	private void set_LastPathSetTime(float value) { }

	[CompilerGenerated]
	private void set_PlayerRemainingDist(float value) { }

	private void SetCurPath(VectorTargetBotPath combineBotPath) { }

	public void SetPath(Vector3[] pathCorners) { }

	public void SetReachDist(float reachDist) { }

	public void Stop() { }

	private static Vector3 TooCloseToMyGroup(BotOwner bot, Vector3 p, Vector3 safePoint) { }

	public bool TryReplacePathAround(Vector3 centerAvoid, List subAvoids, out AbstractBotPath curPath) { }

	public static List TryRuildbuildWay(AbstractBotPath curPath, int curPathCurIndex, List firstPath) { }

	private bool UnityEditorPathCheck(Vector3[] pathToCheck) { }

}

