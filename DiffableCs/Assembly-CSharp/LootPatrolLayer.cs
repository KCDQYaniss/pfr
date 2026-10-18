//Type is in global namespace

public class LootPatrolLayer : BaseLogicLayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__30_0; //Field offset: 0x8
		public static Func <>9__30_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <FindPointFromFullMapPatrolLayer>b__30_0(GroupPoint point) { }

		internal bool <FindPointFromFullMapPatrolLayer>b__30_1(GroupPoint point) { }

	}

	private const int LARGE_GROUP_SEPARATION_LIMIT = 5; //Field offset: 0x0
	private const float LOOTING_TIME = 120; //Field offset: 0x0
	private bool haveUnlootedClustersCache; //Field offset: 0x90
	private bool _clusterReached; //Field offset: 0x91
	private float _recalcCacheTime; //Field offset: 0x94
	private bool _waitGroup; //Field offset: 0x98
	private bool _holdNoLoot; //Field offset: 0x99
	private bool _waitLeader; //Field offset: 0x9A
	private bool _gotoLootCluster; //Field offset: 0x9B
	private float _lastDistanceToTarget; //Field offset: 0x9C
	private float _lastDistanceToTargetUpdateTime; //Field offset: 0xA0
	private bool _stuckedInTacticalMove; //Field offset: 0xA4
	private float _lastLootPatrolDecisionTime; //Field offset: 0xA8
	private int _emptyClusterSwitchCount; //Field offset: 0xAC
	private CustomNavigationPoint _targetCoverPointToMoveTactical; //Field offset: 0xB0
	private CustomNavigationPoint _point; //Field offset: 0xB8
	private AICorePoint _lastCore; //Field offset: 0xC0
	private float _lastTimeSetPoint; //Field offset: 0xC8

	private AILootPointsCluster TargetLootCluster
	{
		private get { } //Length: 48
	}

	public LootPatrolLayer(BotOwner bot, int priority) { }

	private bool CheckCanLootCluster(AILootPointsCluster cluster) { }

	protected virtual AICoreActionEnd EndDeadBody() { }

	protected virtual AICoreActionEnd EndGoToCoverPointTactical() { }

	protected virtual AICoreActionEnd EndGoToLootPointNode() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public CustomNavigationPoint FindPointFromFullMapPatrolLayer(CoverSearchData data, Func p, bool checkCurrent) { }

	private AILootPointsCluster get_TargetLootCluster() { }

	public virtual AICoreActionResult GetDecision() { }

	public IBotOwner GetLeader() { }

	public IBotOwner GetLeader(IBotOwner target) { }

	private AILootPointsCluster GetNearestLootCluster(IBotOwner leader) { }

	private List GetNearestLootClusters(IBotOwner leader, int amount) { }

	private bool GroupStillLootsCluster(AILootPointsCluster cluster) { }

	private bool HaveUnlootedClusters(int connectionGroup) { }

	public bool IAmLeader() { }

	private bool InLootClusterRadius(float sqrRadiusMultiplier = 1) { }

	private bool IsBadCluster(AILootPointsCluster cluster) { }

	private bool LootingTimeExpired() { }

	public virtual string Name() { }

	private bool ShallKeepZoneOnSpawn() { }

	public virtual bool ShallUseNow() { }

	private void SyncTargetLootClusterWithLeader() { }

	private bool TrySelectLootCluster(out AICoreActionResult earlyDecision) { }

}

