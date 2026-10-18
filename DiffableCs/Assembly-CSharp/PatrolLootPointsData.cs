//Type is in global namespace

public class PatrolLootPointsData : BotData
{
	[CompilerGenerated]
	private struct <StartLooting>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PatrolLootPointsData <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private EBotLootSource <lootSource>5__2; //Field offset: 0x30
		private Task <lootTask>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum EAIDropLootPointCause
	{
		Used = 0,
		Dist = 1,
		NotFree = 2,
		Period = 3,
	}

	private const float MAX_FAR_SDIST = 400; //Field offset: 0x0
	private const int MIN_COUNT_TO_DROP_VISITED = 12; //Field offset: 0x0
	private float _nextCheck; //Field offset: 0x18
	private int _lastRealLootSearchFrame; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <LastLootSearchSkipped>k__BackingField; //Field offset: 0x20
	private float _dropPointTime; //Field offset: 0x24
	private float _lastTimeToPoint; //Field offset: 0x28
	private float _timeDropVisited; //Field offset: 0x2C
	private float _stayAtPointPeriod; //Field offset: 0x30
	private AILootPoint _cachedLootPoint; //Field offset: 0x38
	private AILootPoint _lastCachedLootPoint; //Field offset: 0x40
	private HashSet _visited; //Field offset: 0x48
	private bool _clusterError; //Field offset: 0x50
	private bool _cachedLootPointError; //Field offset: 0x51
	private bool _atPointNow; //Field offset: 0x52
	private EAIDropLootPointCause _cause; //Field offset: 0x54
	private AILootPointsCluster _targetLootCluster; //Field offset: 0x58
	private float _beginLootClusterTime; //Field offset: 0x60
	private CancellationTokenSource _lootingTokenSource; //Field offset: 0x68
	private bool _currentPointHasItemsBeforeLooting; //Field offset: 0x70
	private ItemAddress _replaceTargetEquipmentSlot; //Field offset: 0x78
	private IResult _throwResult; //Field offset: 0x80
	private Item _itemToThrow; //Field offset: 0x88

	public float BeginLootClusterTime
	{
		 get { } //Length: 6
	}

	public AILootPoint CachedLootPoint
	{
		 get { } //Length: 5
	}

	public bool IsAtLootPoint
	{
		 get { } //Length: 5
	}

	public private bool LastLootSearchSkipped
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public AILootPointsCluster TargetLootCluster
	{
		 get { } //Length: 5
	}

	public PatrolLootPointsData(BotOwner owner) { }

	public bool AllGroupWantLootCluster() { }

	public void BeginLootCluster() { }

	public void CancelLootingProcessIfNeeded() { }

	public bool ClusterLootingNow() { }

	public void ComeToLootPoint() { }

	public void Dispose() { }

	private void DropCachedPoint(EAIDropLootPointCause cause) { }

	public float get_BeginLootClusterTime() { }

	public AILootPoint get_CachedLootPoint() { }

	public bool get_IsAtLootPoint() { }

	[CompilerGenerated]
	public bool get_LastLootSearchSkipped() { }

	public AILootPointsCluster get_TargetLootCluster() { }

	private static Item GetLootFromLootPoint(AILootPoint lootPoint) { }

	public bool HaveActions(Vector3 positionToSearch, float maxFarSDist = 400, int voxelsRadius = 1) { }

	public bool HaveActions(float maxFarSDist = 400, int voxelsRadius = 1) { }

	private bool PointHasAnyItems(AILootPoint lootPoint) { }

	[CompilerGenerated]
	private void set_LastLootSearchSkipped(bool value) { }

	public void SetTargetLootCluster(AILootPointsCluster targetCluster) { }

	[AsyncStateMachine(typeof(<StartLooting>d__47))]
	public Task StartLooting() { }

	public void StopLootCluster() { }

	public void UpdateFindNextLootPoint(float maxFarSDist = 400, int voxelsRadius = 1) { }

	public void UpdateFindNextLootPoint(Vector3 pointToSearch, float maxFarSDist = 400, int voxelsRadius = 1) { }

}

