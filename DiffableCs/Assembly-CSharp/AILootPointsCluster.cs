//Type is in global namespace

public class AILootPointsCluster
{
	private static int NextClusterId; //Field offset: 0x0
	private const float SEPARATE_CLUSTERS_Y_DIST = 6; //Field offset: 0x0
	private List _lootPoints; //Field offset: 0x10
	[SerializeField]
	private int _centralPointId; //Field offset: 0x18
	[SerializeField]
	private Vector3 _centerPosition; //Field offset: 0x1C
	private Vector3 _pointsCoordSum; //Field offset: 0x28
	[CompilerGenerated]
	private bool <CenterRebalanced>k__BackingField; //Field offset: 0x34
	[SerializeField]
	private int _clusterId; //Field offset: 0x38
	[SerializeField]
	private float _squareRadius; //Field offset: 0x3C
	[SerializeField]
	private float _radius; //Field offset: 0x40
	private float _evaluatedCostRuntime; //Field offset: 0x44
	[CompilerGenerated]
	private bool <Inited>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <Looted>k__BackingField; //Field offset: 0x49
	private BotsGroup _reservedForGroup; //Field offset: 0x50
	[SerializeField]
	private int _connectionGroup; //Field offset: 0x58
	[SerializeField]
	private BotZone _botZone; //Field offset: 0x60

	public BotZone BotZone
	{
		 get { } //Length: 5
	}

	public Vector3 CenterPosition
	{
		 get { } //Length: 19
	}

	public private bool CenterRebalanced
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int CentralPointId
	{
		 get { } //Length: 4
	}

	public int ClusterId
	{
		 get { } //Length: 4
	}

	public int ConnectionGroup
	{
		 get { } //Length: 4
	}

	public float EvaluatedCostRuntime
	{
		 get { } //Length: 6
	}

	public private bool Inited
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool Looted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int PointsCount
	{
		 get { } //Length: 65
	}

	public float Radius
	{
		 get { } //Length: 6
	}

	public BotsGroup ReservedForGroup
	{
		 get { } //Length: 5
	}

	public float SquareRadius
	{
		 get { } //Length: 6
	}

	public AILootPointsCluster(int centralPointId, Vector3 centerPosition, float radius, int connectionGroup) { }

	public AILootPointsCluster(AILootPoint centralPoint, float radius) { }

	public void AddPoint(AILootPoint lootPoint) { }

	public int CalcRarityScore() { }

	public bool CheckClusterInBossZone(BotsGroup group) { }

	public void CollectActualSpawnedLoot(List allLoot) { }

	public void DrawGizmos() { }

	public float Evaluate(IBotOwner owner) { }

	private float EvaluatePrice(Item item) { }

	public BotZone get_BotZone() { }

	public Vector3 get_CenterPosition() { }

	[CompilerGenerated]
	public bool get_CenterRebalanced() { }

	public int get_CentralPointId() { }

	public int get_ClusterId() { }

	public int get_ConnectionGroup() { }

	public float get_EvaluatedCostRuntime() { }

	[CompilerGenerated]
	public bool get_Inited() { }

	[CompilerGenerated]
	public bool get_Looted() { }

	public int get_PointsCount() { }

	public float get_Radius() { }

	public BotsGroup get_ReservedForGroup() { }

	public float get_SquareRadius() { }

	public bool IsPointInClusterArea(AILootPoint pointToCheck) { }

	public void LinkToBotZone(BotZone botZone) { }

	public void MarkLooted() { }

	public void RebalanceCluster() { }

	public void ReserveForGroup(BotsGroup group) { }

	[CompilerGenerated]
	private void set_CenterRebalanced(bool value) { }

	[CompilerGenerated]
	private void set_Inited(bool value) { }

	[CompilerGenerated]
	private void set_Looted(bool value) { }

}

