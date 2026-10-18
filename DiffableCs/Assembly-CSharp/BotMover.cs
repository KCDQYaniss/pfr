//Type is in global namespace

public abstract class BotMover : BotData
{
	public const float MAX_DIST_PER_FRAME = 0.2; //Field offset: 0x0
	private const float RELINK_SDIST = 0.0025000002; //Field offset: 0x0
	private const float MAX_SUPERFAIL_CASCADE_SDIST = 25; //Field offset: 0x0
	private const float MAX_SUPERFAIL_CASCADE_DIST = 5; //Field offset: 0x0
	private const float STOP_MOVE_SPEED_THRESHOLD = 0.02; //Field offset: 0x0
	private const float MAX_Y_DELTA_PER_STEP = 0.5; //Field offset: 0x0
	private const float LAST_CORRECT_POSITION_MAX_AGE = 5; //Field offset: 0x0
	private const float RELINK_DISTANCE_LIMIT = 2; //Field offset: 0x0
	public const float SlowPeriod = 0.5; //Field offset: 0x0
	public const float SlowEndDist = 0.5; //Field offset: 0x0
	public const float MaxSprintSpeed = 2; //Field offset: 0x0
	public const float MAX_SDIST_PER_FRAME = 0.040000003; //Field offset: 0x0
	private const float MAX_DIST_OUT_OF_NAVMESH = 7; //Field offset: 0x0
	public BotLocalAvoidance LocalAvoidance; //Field offset: 0x18
	private Vector3 _lastNoWayPos; //Field offset: 0x20
	protected readonly Player _player; //Field offset: 0x30
	protected Vector3 _positionOnWay; //Field offset: 0x38
	private float _lastError; //Field offset: 0x44
	private float _lastTimePosChanged; //Field offset: 0x48
	private Vector3 _lastPos; //Field offset: 0x4C
	protected Vector3 _dirCurPoint; //Field offset: 0x58
	protected Vector3 _currentTargetPoint; //Field offset: 0x64
	protected float _endSlowTime; //Field offset: 0x70
	protected float _nextLogForTp; //Field offset: 0x74
	protected bool _startSlowActivated; //Field offset: 0x78
	protected bool _firstTurnComplete; //Field offset: 0x79
	protected bool _firstTurnBigSpeed; //Field offset: 0x7A
	private int _collectedErrors; //Field offset: 0x7C
	protected BotMoverStateMachine _moverStateMachine; //Field offset: 0x80
	protected BotMoverDebug _debugerWay; //Field offset: 0x88
	protected BotMoverDebug _debuger; //Field offset: 0x90
	private readonly Vector3 _offsetCastUp; //Field offset: 0x98
	private readonly float _poseSpeedChangeFactor; //Field offset: 0xA4
	private float _pauseEndTime; //Field offset: 0xA8
	private float _sprintStopEnd; //Field offset: 0xAC
	private float _nextCheckVoxel; //Field offset: 0xB0
	private bool _linkedToNavmeshInitially; //Field offset: 0xB4
	private int _wrongTargetError; //Field offset: 0xB8
	private Vector3 _prevSuccessLinkedFrom; //Field offset: 0xBC
	private float _prevPosLinkedTime; //Field offset: 0xC8
	private string _prevLinkResult; //Field offset: 0xD0
	private readonly BotPathFinderCorePoints _pathFinder; //Field offset: 0xD8
	private Vector3 _prevSuccsesLinkedFrom; //Field offset: 0xE0
	private Vector3 _prevLinkPos; //Field offset: 0xEC
	private readonly BotMoverDebugGameObject DebugHolder; //Field offset: 0xF8
	private Vector3 _lastGoodCastPoint; //Field offset: 0x100
	private float _lastGoodCastPointTime; //Field offset: 0x10C
	private int _navMeshLinkFailAttempts; //Field offset: 0x110
	private Vector3 _superFailCascadeOrigin; //Field offset: 0x114
	private bool _hasSuperFailCascadeOrigin; //Field offset: 0x120
	private NavGraphVoxelSimple _lastVoxel; //Field offset: 0x128
	private Vector3 _positionOnWayCasted; //Field offset: 0x130
	[CompilerGenerated]
	private Action OnPoseChange; //Field offset: 0x140
	[CompilerGenerated]
	private bool <Sprinting>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private float <TargetPose>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private bool <IsMoving>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private Action OnWayChanged; //Field offset: 0x158
	[CompilerGenerated]
	private float <SDistDestination>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private Vector3 <NormDirCurPoint>k__BackingField; //Field offset: 0x164
	[CompilerGenerated]
	private bool <Pause>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private float <MoveSpeed>k__BackingField; //Field offset: 0x174
	private Vector3 _lastCorrectPositionOnWay; //Field offset: 0x178
	private float _lastCorrectPositionOnWayTime; //Field offset: 0x184
	private readonly int terrainMask; //Field offset: 0x188
	private Vector3 _prevFramePos; //Field offset: 0x18C
	private float _prevFrameTime; //Field offset: 0x198
	private float _lastTimeCheckNeedMove; //Field offset: 0x19C
	private Vector3 _prevOffsetGoodCasted; //Field offset: 0x1A0
	private float _prevOffsetGoodCastedTime; //Field offset: 0x1AC
	private float _next; //Field offset: 0x1B0
	private bool _allowTeleport; //Field offset: 0x1B4

	public event Action OnPoseChange
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnWayChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected BotPathController ActualPathController
	{
		 get { } //Length: 39
	}

	protected BotPathFinderCorePoints ActualPathFinder
	{
		 get { } //Length: 39
	}

	public override bool Blocked
	{
		 get { } //Length: 3
	}

	public string CallstackPathComeFrom
	{
		 get { } //Length: 48
	}

	public AbstractBotPath CurPath
	{
		 get { } //Length: 48
	}

	public Vector3 CurrentCornerPoint
	{
		 get { } //Length: 62
	}

	public EBotMoverState CurrentState
	{
		 get { } //Length: 38
	}

	public Vector3 DirCurPoint
	{
		 get { } //Length: 19
	}

	public float DistDestination
	{
		 get { } //Length: 49
	}

	public bool FirstTurnBigSpeed
	{
		 get { } //Length: 5
	}

	public bool FirstTurnComplete
	{
		 get { } //Length: 5
	}

	public bool HasPathAndNoComplete
	{
		 get { } //Length: 52
	}

	public override bool IsImpostorWorks
	{
		 get { } //Length: 3
	}

	public bool IsMoving
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public float LastEndPathTime
	{
		 get { } //Length: 49
	}

	public float LastPathSetTime
	{
		 get { } //Length: 49
	}

	public private float MoveSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private Vector3 NormDirCurPoint
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public bool NoSprint
	{
		 get { } //Length: 93
	}

	public Action onPathCornerChanged
	{
		 get { } //Length: 48
		 set { } //Length: 123
	}

	private string pathStack
	{
		private get { } //Length: 48
	}

	public private bool Pause
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Vector3 PositionOnWay
	{
		 get { } //Length: 19
	}

	protected Vector3 PositionOnWayInner
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public float PrevPosLinkedTime
	{
		 get { } //Length: 9
	}

	public Vector3 PrevSuccessLinkedFrom
	{
		 get { } //Length: 25
	}

	public Vector3 RealDestPoint
	{
		 get { } //Length: 19
	}

	public float RemainPause
	{
		 get { } //Length: 94
	}

	public private float SDistDestination
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public bool ShallSlowAtStart
	{
		 get { } //Length: 5
	}

	public private bool Sprinting
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Nullable TargetPoint
	{
		 get { } //Length: 72
	}

	public private float TargetPose
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	protected BotMover(BotOwner owner, Player player, AICoversData covers) { }

	public override void Activate() { }

	[CompilerGenerated]
	public void add_OnPoseChange(Action value) { }

	[CompilerGenerated]
	public void add_OnWayChanged(Action value) { }

	public void AllowTeleport() { }

	public Vector3[] CalcPath(Vector3 position) { }

	public float CalculatePathLength() { }

	protected override void CantFindWayErrorTraceLog() { }

	private EBotLinkResult CastFromPos(Vector3 posiblePos, bool withExtra) { }

	private void ChangeMoveSpeed() { }

	private void ChangePose() { }

	protected abstract bool CheckCornerIndexByReachDist(float distCur, Vector3 position) { }

	protected override void CheckForRecalcPath() { }

	private void CheckIsIamneedToMove() { }

	protected abstract bool CheckIsOnPoint(Vector3 position) { }

	private void CheckPathAndSetCollidersState() { }

	private void CheckPause() { }

	private void CheckStuck() { }

	public float ComputePathLengthToPoint(Vector3 targetPoint) { }

	public static BotMover Create(BotOwner owner, AICoversData covers) { }

	public NavMeshPathStatus CurrentStateGoToPoint(Vector3 pos, bool slowAtTheEnd, float reachDist, bool getUpWithCheck = false, bool mustHaveWay = true, bool onlyShortTrie = false, bool force = false) { }

	public void DebugDrawLastPath() { }

	private void DebugTestOnWay() { }

	private void DebugTestStep() { }

	public override void Dispose() { }

	public void DoProne(bool val) { }

	public void DrawSelectedGizmosWay() { }

	public void DrawVisionLines() { }

	private bool FindBetterPosition(Vector3 castPoint, out Vector3 betterPosition) { }

	public Nullable FindPointFarThan(float dist, out int index) { }

	private bool FindSamplePoint(Vector3 castPoint, float sampleRad, out Nullable hitPos, out bool onTerrain) { }

	protected BotPathController get_ActualPathController() { }

	protected BotPathFinderCorePoints get_ActualPathFinder() { }

	public override bool get_Blocked() { }

	public string get_CallstackPathComeFrom() { }

	public AbstractBotPath get_CurPath() { }

	public Vector3 get_CurrentCornerPoint() { }

	public EBotMoverState get_CurrentState() { }

	public Vector3 get_DirCurPoint() { }

	public float get_DistDestination() { }

	public bool get_FirstTurnBigSpeed() { }

	public bool get_FirstTurnComplete() { }

	public bool get_HasPathAndNoComplete() { }

	public override bool get_IsImpostorWorks() { }

	[CompilerGenerated]
	public bool get_IsMoving() { }

	public float get_LastEndPathTime() { }

	public float get_LastPathSetTime() { }

	[CompilerGenerated]
	public float get_MoveSpeed() { }

	[CompilerGenerated]
	public Vector3 get_NormDirCurPoint() { }

	public bool get_NoSprint() { }

	public Action get_onPathCornerChanged() { }

	private string get_pathStack() { }

	[CompilerGenerated]
	public bool get_Pause() { }

	public Vector3 get_PositionOnWay() { }

	protected Vector3 get_PositionOnWayInner() { }

	public float get_PrevPosLinkedTime() { }

	public Vector3 get_PrevSuccessLinkedFrom() { }

	public Vector3 get_RealDestPoint() { }

	public float get_RemainPause() { }

	[CompilerGenerated]
	public float get_SDistDestination() { }

	public bool get_ShallSlowAtStart() { }

	[CompilerGenerated]
	public bool get_Sprinting() { }

	public Nullable get_TargetPoint() { }

	[CompilerGenerated]
	public float get_TargetPose() { }

	public List GetCornersFromIndex(int index) { }

	public Vector3[] GetWayPoints(int maxWayPoints) { }

	public override void GoToByWay(Vector3[] way, float reachDist) { }

	public NavMeshPathStatus GoToPoint(Vector3 pos, bool slowAtTheEnd, float reachDist, bool getUpWithCheck = false, bool mustHaveWay = true, bool onlyShortTrie = false, bool force = false) { }

	public NavMeshPathStatus GoToPoint(CustomNavigationPoint targetPoint, bool slowAtTheEnd = false, bool getUpWithCheck = false) { }

	public void GoToPointNoWay(Nullable v) { }

	protected override Vector3 InertionOffset() { }

	protected override void InertionUpdateOnCoef(float coef) { }

	public bool IsComeTo(float dist2check, bool onCover, CustomNavigationPoint p = null) { }

	public bool IsPointOnCurrentWay(Vector3 point, float maxDist) { }

	private bool IsWithinSuperFailCascade(Vector3 position) { }

	public Vector3 LastDestination() { }

	public Vector3 LastTargetPoint(float distCoef) { }

	public void LateFixedUpdate() { }

	public void ManualFixedUpdate() { }

	public override void ManualUpdate() { }

	public Vector3 ModifVectorByWallSide(Vector3 directionLook, Vector3 toWallVector) { }

	public void MovementPause(float pauseTime, bool pauseOnlyIfNot = true) { }

	public void MovementResume() { }

	private void MovePlayer() { }

	private void NavMeshLinker() { }

	public override void OnDrawGizmosPrevWay() { }

	private void OnEndInteract() { }

	private void OnSetPositionFromDebug(Vector3 obj) { }

	private EBotLinkResult PhysicsRaycast(Nullable hitPos) { }

	public Vector3 PrevCorner() { }

	public void RecalcWay() { }

	[CompilerGenerated]
	public void remove_OnPoseChange(Action value) { }

	[CompilerGenerated]
	public void remove_OnWayChanged(Action value) { }

	[CompilerGenerated]
	protected void set_IsMoving(bool value) { }

	[CompilerGenerated]
	private void set_MoveSpeed(float value) { }

	[CompilerGenerated]
	private void set_NormDirCurPoint(Vector3 value) { }

	public void set_onPathCornerChanged(Action value) { }

	[CompilerGenerated]
	private void set_Pause(bool value) { }

	protected void set_PositionOnWayInner(Vector3 value) { }

	[CompilerGenerated]
	private void set_SDistDestination(float value) { }

	[CompilerGenerated]
	private void set_Sprinting(bool value) { }

	[CompilerGenerated]
	private void set_TargetPose(float value) { }

	protected abstract void SetLastContex(float remainDist, Vector3 directionMove, Vector3 targetPos) { }

	public void SetMoverState(EBotMoverState state) { }

	private void SetMyVoxel(NavGraphVoxelSimple centerVoxel) { }

	protected override EBotLinkResult SetPlayerToNavMesh(Vector3 castPoint, Vector3 deltaMove, out bool onTerrain) { }

	public void SetPointOnWay(Vector3 point) { }

	public override void SetPose(float targetPose) { }

	private EBotLinkResult SetPosition(Vector3 pos) { }

	public void SetReachDist(float reachDist) { }

	private void SetSprintSpeed(float val) { }

	public void SetTargetMoveSpeed(float target) { }

	private void ShiftSuperFailCascadeOrigin(Vector3 newPosition) { }

	public override void Sprint(bool val, bool withDebugCallback = true) { }

	public void SprintPause(float period) { }

	public void Stop() { }

	public bool Teleport(Vector3 rPosition, bool withDropErrors = true) { }

	private bool TryExtraSample(Vector3 castPoint, out EBotLinkResult debugType) { }

	private bool TryFindLinkedTeleportPosition(Vector3 origin, out Vector3 linkedPos, out EBotLinkResult linkRes) { }

	public bool TryRelacePathAround(Vector3 point, List subAvoids, out AbstractBotPath curPath) { }

	private Vector2 TurnMove() { }

	protected float UseFuncAcceleration(float x) { }

	protected override void WayChanged(bool obj) { }

}

