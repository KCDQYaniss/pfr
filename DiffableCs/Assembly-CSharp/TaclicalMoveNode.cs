//Type is in global namespace

public abstract class TaclicalMoveNode : MoveNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__85_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <TryMoveToTarget>b__85_0() { }

	}

	private const float COVER_DIST_GAP = 100; //Field offset: 0x0
	private const float REACH_SDIST = 0.010000001; //Field offset: 0x0
	private const float REACH_DIST = 0.1; //Field offset: 0x0
	private float _nextCoverCheck; //Field offset: 0x28
	private ETacticalMove _sTacticalMove; //Field offset: 0x2C
	private float _lastComeToMiddleCover; //Field offset: 0x30
	private float _extraEndMoveToSub; //Field offset: 0x34
	private float _lastLeaveMiddleCover; //Field offset: 0x38
	private float _lastCheckTryToMoveTactical; //Field offset: 0x3C
	private NavMeshPath _path; //Field offset: 0x40
	private NavMeshPath _pathToNext; //Field offset: 0x48
	private NavMeshPath _startCachPath; //Field offset: 0x50
	private float _goToSubPointTimeRecheck; //Field offset: 0x58
	private float _nextStayAtCoverPeriod; //Field offset: 0x5C
	private float _comeToSubCover; //Field offset: 0x60
	private float _nextPeriodFindSub; //Field offset: 0x64
	private ushort _voxelId; //Field offset: 0x68
	protected bool _nextSubCoverLookFromIt; //Field offset: 0x6A
	protected GroupPoint _middlePoint; //Field offset: 0x70
	protected CustomNavigationPoint _middlePointAsCover; //Field offset: 0x78
	private bool _goToSubPoint; //Field offset: 0x80
	private bool _stopAtSub; //Field offset: 0x81
	private HashSet _usedCovers; //Field offset: 0x88
	private readonly BifacialTransform _ownerTransform; //Field offset: 0x90
	private NavMeshPath _pathCache; //Field offset: 0x98
	private float _chanceToShortStay; //Field offset: 0xA0
	private float _chanceToNextStopShort; //Field offset: 0xA4
	private Vector3[] _cachePathToReturnToMainWay; //Field offset: 0xA8

	protected override float CHANCE_TO_COVER_SPRINT_ON_MAX_DIST_OR_HIGHER
	{
		 get { } //Length: 9
	}

	protected override float CHANCE_TO_COVER_SPRINT_ON_MIN_DIST_OR_LOWER
	{
		 get { } //Length: 4
	}

	protected override float CHANCE_TO_SPRINT
	{
		 get { } //Length: 9
	}

	protected override float CHANCE_TO_SPRINT_SQR_ON_MAX_DIST_OR_HIGHER
	{
		 get { } //Length: 9
	}

	protected override float CHANCE_TO_SPRINT_SQR_ON_MIN_DIST_OR_LOWER
	{
		 get { } //Length: 4
	}

	protected override float CHANCE_TO_STOP_SPRINT_SQR_ON_MAX_DIST_OR_HIGHER
	{
		 get { } //Length: 4
	}

	protected override float CHANCE_TO_STOP_SPRINT_SQR_ON_MIN_DIST_OR_LOWER
	{
		 get { } //Length: 9
	}

	protected override float DIST_TO_COVER_SPRINT_MAX_OR_HIGHER
	{
		 get { } //Length: 9
	}

	protected override float DIST_TO_COVER_SPRINT_MIN
	{
		 get { } //Length: 9
	}

	protected override float DIST_TO_SPRINT
	{
		 get { } //Length: 9
	}

	protected override float DIST_TO_SPRINT_SQR_MAX_OR_HIGHER
	{
		 get { } //Length: 9
	}

	protected override float DIST_TO_SPRINT_SQR_MIN
	{
		 get { } //Length: 9
	}

	protected override float ENEMY_VISIBLE_RECENTLY
	{
		 get { } //Length: 9
	}

	protected override Vector3 MainTargetPosition
	{
		 get { } //Length: 77
	}

	protected override float NEXT_COVER_LONG
	{
		 get { } //Length: 9
	}

	protected override float NEXT_COVER_SHORT
	{
		 get { } //Length: 9
	}

	protected override float SDIST_TOO_CLOSE_TO_FINAL
	{
		 get { } //Length: 9
	}

	protected override float STAY_AT_COVER
	{
		 get { } //Length: 9
	}

	protected override float STAY_AT_COVER_WITH_ENEMY
	{
		 get { } //Length: 9
	}

	protected TaclicalMoveNode(BotOwner bot, float chanceToShortStay, float chanceToNextStopShort) { }

	private void CheckComeToSubCover() { }

	private void CheckSprintOnPathCornerChanged(int pathCornerIndex, Vector3[] path) { }

	private float EvaluateChanceToSprintPathSegment(float lengthSqr) { }

	private float EvaluateChanceToSprintToCover(float length) { }

	private float EvaluateChanceToStopSprintPathSegment(float lengthSqr) { }

	protected override float get_CHANCE_TO_COVER_SPRINT_ON_MAX_DIST_OR_HIGHER() { }

	protected override float get_CHANCE_TO_COVER_SPRINT_ON_MIN_DIST_OR_LOWER() { }

	protected override float get_CHANCE_TO_SPRINT() { }

	protected override float get_CHANCE_TO_SPRINT_SQR_ON_MAX_DIST_OR_HIGHER() { }

	protected override float get_CHANCE_TO_SPRINT_SQR_ON_MIN_DIST_OR_LOWER() { }

	protected override float get_CHANCE_TO_STOP_SPRINT_SQR_ON_MAX_DIST_OR_HIGHER() { }

	protected override float get_CHANCE_TO_STOP_SPRINT_SQR_ON_MIN_DIST_OR_LOWER() { }

	protected override float get_DIST_TO_COVER_SPRINT_MAX_OR_HIGHER() { }

	protected override float get_DIST_TO_COVER_SPRINT_MIN() { }

	protected override float get_DIST_TO_SPRINT() { }

	protected override float get_DIST_TO_SPRINT_SQR_MAX_OR_HIGHER() { }

	protected override float get_DIST_TO_SPRINT_SQR_MIN() { }

	protected override float get_ENEMY_VISIBLE_RECENTLY() { }

	protected override Vector3 get_MainTargetPosition() { }

	protected override float get_NEXT_COVER_LONG() { }

	protected override float get_NEXT_COVER_SHORT() { }

	protected override float get_SDIST_TOO_CLOSE_TO_FINAL() { }

	protected override float get_STAY_AT_COVER() { }

	protected override float get_STAY_AT_COVER_WITH_ENEMY() { }

	private float GetPathLengthByNavMesh(Vector3 from, Vector3 to) { }

	private void LookByHearingFromMiddlePoint() { }

	protected abstract void LookSimple() { }

	protected override void LookStaingAtSub() { }

	protected override void MoverToMainTarget(CustomNavigationPoint navigationPoint) { }

	protected override void MoveToMainTarget() { }

	private void SetState(ETacticalMove st) { }

	private void StayAtSubCover() { }

	private void TryFindSubPointToMove() { }

	private void TryMoveToTarget() { }

	protected bool TryUseCacheWayToGo(Vector3 navigationPoint) { }

	protected override void UpdateLookFromCover() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

	private void UpdateSprintAtEnd() { }

}

