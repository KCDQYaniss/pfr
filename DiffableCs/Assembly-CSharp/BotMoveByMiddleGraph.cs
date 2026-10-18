//Type is in global namespace

public class BotMoveByMiddleGraph : BotData
{
	private const float CornerMergeSqrEpsilon = 0.0001; //Field offset: 0x0
	private const float GoRoundEnemyRecalcMinInterval = 10; //Field offset: 0x0
	private const float SD_CLOSEST_TO_TARGET_POINT = 225; //Field offset: 0x0
	private readonly NavMeshPath _navPathScratch; //Field offset: 0x18
	private bool _hasStoredSuccessfulGoRoundPath; //Field offset: 0x20
	private BotMoveByMiddleGraphPathResult _storedGoRoundPath; //Field offset: 0x28
	private int _storedEnemyNearestGraphPointId; //Field offset: 0x60
	private float _lastGoRoundPathCalculatedTime; //Field offset: 0x64
	private float _nextPossibelCalc; //Field offset: 0x68
	private bool _trackingGoRoundMoveActive; //Field offset: 0x6C
	[CompilerGenerated]
	private float <LastGoRoundPathCompletedTime>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <TotalyBlocked>k__BackingField; //Field offset: 0x74

	public bool IsTrackingGoRoundMove
	{
		 get { } //Length: 5
	}

	public private float LastGoRoundPathCompletedTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private bool TotalyBlocked
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotMoveByMiddleGraph(BotOwner owner) { }

	public void Activate() { }

	private static MiddleGraphPoint FindNearestPointInConnectionGroup(IReadOnlyList points, Vector3 worldPosition, int connectionGroupId) { }

	public bool get_IsTrackingGoRoundMove() { }

	[CompilerGenerated]
	public float get_LastGoRoundPathCompletedTime() { }

	[CompilerGenerated]
	public bool get_TotalyBlocked() { }

	public BotMoveByMiddleGraphPathResult GoToPoint(Vector3 pos) { }

	private bool HasAnyGraphVertexInBotConnectionGroup() { }

	[CompilerGenerated]
	private void set_LastGoRoundPathCompletedTime(float value) { }

	[CompilerGenerated]
	private void set_TotalyBlocked(bool value) { }

	private bool TryAppendNavMeshSegment(Vector3 from, Vector3 to, List cornersAcc) { }

	public bool TryGetStoredSuccessfulGoRoundPath(out BotMoveByMiddleGraphPathResult path) { }

	public void TryGoRoundEnemy() { }

}

