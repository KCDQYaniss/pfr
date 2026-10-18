//Type is in global namespace

public class DebugCoverDataInfo : ICoverSearchBot, ICoversData
{
	public DebugCoverSystemTester Tester; //Field offset: 0x10
	public CustomNavigationPoint[] _coverPoints; //Field offset: 0x18
	public CustomNavigationPoint[] _ambushPoints; //Field offset: 0x20
	public CustomNavigationPoint[] _bushPoints; //Field offset: 0x28
	public CustomNavigationPoint[] _allPoints; //Field offset: 0x30
	public CustomNavigationPoint[] _allPointsWithBush; //Field offset: 0x38
	private NavGraphContainer _container; //Field offset: 0x40
	private DebugCoverFindGraphSearchData _lastDebug; //Field offset: 0x48
	[CompilerGenerated]
	private WildSpawnType <Type>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private BotSettingsComponents <Settings>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private LayerMask <LookSensorMask>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly CustomNavigationPoint <LastCover>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly int <ConnectionGroupId>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private readonly CustomNavigationPoint <LastCustomNavigationPoint>k__BackingField; //Field offset: 0x78

	public CustomNavigationPoint[] AllPoints
	{
		 get { } //Length: 76
	}

	public CustomNavigationPoint[] AllPointsWithBush
	{
		 get { } //Length: 5
	}

	public CustomNavigationPoint[] AmbushPoints
	{
		 get { } //Length: 5
	}

	public override IBossToFollow BossToFollow
	{
		 get { } //Length: 3
	}

	public override BotGrenadeController BotGrenadeController
	{
		 get { } //Length: 3
	}

	public override StandartBotBrain Brain
	{
		 get { } //Length: 3
	}

	public CustomNavigationPoint[] BushPoints
	{
		 get { } //Length: 5
	}

	public override int ConnectionGroupId
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public CustomNavigationPoint[] CoverPoints
	{
		 get { } //Length: 5
	}

	public override ICoversData Covers
	{
		 get { } //Length: 4
	}

	public override CustomNavigationPoint CurCustomCoverPoint
	{
		 get { } //Length: 3
	}

	public bool GetTrulyDist
	{
		 get { } //Length: 3
	}

	public override EnemyInfo GoalEnemy
	{
		 get { } //Length: 23
	}

	public override int Id
	{
		 get { } //Length: 6
	}

	public override bool IsDamaged
	{
		 get { } //Length: 3
	}

	private bool IsPve
	{
		private get { } //Length: 3
	}

	public override CustomNavigationPoint LastCover
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override CustomNavigationPoint LastCustomNavigationPoint
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private override LayerMask LookSensorMask
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override Vector3 Position
	{
		 get { } //Length: 214
	}

	public bool Protecting
	{
		 get { } //Length: 3
	}

	public private override BotSettingsComponents Settings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override WildSpawnType Type
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public DebugCoverDataInfo() { }

	public override HashSet CarePositions() { }

	public override CustomNavigationPoint FindClosestPoint(Vector3 dataCenterPos, bool noRestrictions = false, Func goodFunc = null) { }

	public CustomNavigationPoint[] get_AllPoints() { }

	public CustomNavigationPoint[] get_AllPointsWithBush() { }

	public CustomNavigationPoint[] get_AmbushPoints() { }

	public override IBossToFollow get_BossToFollow() { }

	public override BotGrenadeController get_BotGrenadeController() { }

	public override StandartBotBrain get_Brain() { }

	public CustomNavigationPoint[] get_BushPoints() { }

	[CompilerGenerated]
	public override int get_ConnectionGroupId() { }

	public CustomNavigationPoint[] get_CoverPoints() { }

	public override ICoversData get_Covers() { }

	public override CustomNavigationPoint get_CurCustomCoverPoint() { }

	public bool get_GetTrulyDist() { }

	public override EnemyInfo get_GoalEnemy() { }

	public override int get_Id() { }

	public override bool get_IsDamaged() { }

	private bool get_IsPve() { }

	[CompilerGenerated]
	public override CustomNavigationPoint get_LastCover() { }

	[CompilerGenerated]
	public override CustomNavigationPoint get_LastCustomNavigationPoint() { }

	[CompilerGenerated]
	public override LayerMask get_LookSensorMask() { }

	public override Vector3 get_Position() { }

	public bool get_Protecting() { }

	[CompilerGenerated]
	public override BotSettingsComponents get_Settings() { }

	[CompilerGenerated]
	public override WildSpawnType get_Type() { }

	public override GroupPoint GetClosest(Vector3 center, int connectionGroupId) { }

	public override GroupPoint GetClosestByClosestsVoxeles(Vector3 center) { }

	public override GroupPoint GetClosestsPointVoxelesExtended(Vector3 pos, int rad, int connectionGroup, bool withFoliage) { }

	public override CustomNavigationPoint GetFreeClosePoint(Vector3 pos, float minSDistToEnemy) { }

	public NavGraphContainer GetNavGraphContainer() { }

	public override List GetVoxelesExtended(Vector3 pos, int r, bool onlyWithPoints = false) { }

	public List GetVoxelesExtended(Vector3 pos, int r) { }

	public override List GetVoxelesInRadius(int step) { }

	public override NavGraphVoxelSimple GetVoxelSafe(Vector3 centerPos) { }

	public void Init(DebugCoverSystemTester tester) { }

	public override bool IsCurrentPointGood(CoverSearchType dataSearchType, CoverSearchData data, out CustomNavigationPoint point) { }

	public override float MaxShootDist() { }

	public NavGraphEditorPoint NextPointToGo() { }

	[CompilerGenerated]
	private void set_LookSensorMask(LayerMask value) { }

	[CompilerGenerated]
	private void set_Settings(BotSettingsComponents value) { }

	[CompilerGenerated]
	private void set_Type(WildSpawnType value) { }

	public override void SetLastSearchDebug(DebugCoverFindGraphSearchData debug) { }

	public void SetPathToCover(CustomNavigationPoint resultPoint) { }

}

