//Type is in global namespace

public class BossWedge : ABossLogic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_1; //Field offset: 0x8
		public static Func <>9__30_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__17_1(AIPlaceInfo x) { }

		internal string <InitStopAmbushSubscriptions>b__30_0(AIPlaceInfoWedgeStopAmbush z) { }

	}

	private const float CHEAT_VISION_DIST = 30; //Field offset: 0x0
	private const int DEAD_NEED_TO_CHEAT_VISION = -1; //Field offset: 0x0
	private const float STOP_AMBUSH_RADIUS = 50; //Field offset: 0x0
	[CompilerGenerated]
	private bool <PeriodHold>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <AmbushPossible>k__BackingField; //Field offset: 0x21
	private AIPeriodAction _periodCheckVision; //Field offset: 0x28
	private List _allWedgeZones; //Field offset: 0x30
	private readonly List _stopAmbushPlaces; //Field offset: 0x38
	private int _myPartyDead; //Field offset: 0x40
	private bool _useCheatVision; //Field offset: 0x44
	private readonly BossWedgeFlankNavMetrics _flankNavMetrics; //Field offset: 0x48
	private float _nextChangeLook; //Field offset: 0x50

	public bool AmbushPossible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool PeriodHold
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public BossWedge(BotOwner owner, BotBoss bossLogic, bool useCheatVision) { }

	[CompilerGenerated]
	private bool <.ctor>b__17_0(AIPlaceInfo x) { }

	public virtual void Activate() { }

	private void AddDelays() { }

	public virtual void BossLogicUpdate() { }

	public void ChangeHold(float nextHold, float nextLook) { }

	private static float ComputeEnemyProximityRisk01(float distToEnemy) { }

	private static float ComputePassRisk01(float minDistToEnemySqr) { }

	private static float ComputeTowardEnemyRisk01(Vector3 ownerPos, Vector3 zonePos, Vector3 enemyPos) { }

	public virtual void CopyData(ABossLogic bossBossLogic) { }

	public virtual void Dispose() { }

	private static float DistancePointToSegmentSqrXZ(Vector3 p, Vector3 a, Vector3 b) { }

	public AIPlaceInfo FindClosesPlaceExecpt(AIPlaceInfo enemyZone) { }

	[CompilerGenerated]
	public bool get_AmbushPossible() { }

	[CompilerGenerated]
	public bool get_PeriodHold() { }

	private static Vector3 GetStopAmbushPlaceCenter(AIPlaceInfoWedgeStopAmbush place) { }

	private WedgesController GetWedgesController() { }

	private static Vector3 GetZoneCenter(AIPlaceInfo zone) { }

	private void InitStopAmbushSubscriptions() { }

	public bool IsEnemyAtMyZone(IPlayer enemy, out AIPlaceInfo place) { }

	private static float MinDistanceSqrToPolylineXZ(Vector3 point, Vector3[] corners) { }

	private void OnMemberRemove(BotOwner obj) { }

	private void OnStopAmbushZonePlayerEnter(Player player) { }

	private void PeriodSetInfo() { }

	private void PlantOneRandomRewarmMine() { }

	private static bool PolylineIntersectsBoundsXZ(Vector3[] corners, Bounds bounds) { }

	public void RegisterAttackMovingFlankToPointStarted(BotOwner starter) { }

	public void RegisterGoToEnemyStarted(BotOwner starter) { }

	private static bool SegmentIntersectsBoundsXZ(Vector3 a, Vector3 b, Bounds bounds) { }

	[CompilerGenerated]
	public void set_AmbushPossible(bool value) { }

	[CompilerGenerated]
	public void set_PeriodHold(bool value) { }

	public virtual void SetPatrolMode() { }

	public bool ShallDeferFlankBecauseRecentGroupFlank(BotOwner requestingBot, out BotLogicDecision substituteDecision) { }

	public bool ShallHoldBecauseRecentGroupGoToEnemy(BotOwner requestingBot) { }

	private static bool TryCalcNavMeshPath(Vector3 from, Vector3 to, NavMeshPath path) { }

	private void UnsubscribeStopAmbushPlaces() { }

	public bool WannaChangeLook(bool isShootFromCover) { }

	public bool WannaHelp() { }

}

