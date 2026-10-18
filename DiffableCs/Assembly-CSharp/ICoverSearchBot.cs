//Type is in global namespace

public interface ICoverSearchBot
{

	public IBossToFollow BossToFollow
	{
		 get { } //Length: 0
	}

	public BotGrenadeController BotGrenadeController
	{
		 get { } //Length: 0
	}

	public StandartBotBrain Brain
	{
		 get { } //Length: 0
	}

	public int ConnectionGroupId
	{
		 get { } //Length: 0
	}

	public ICoversData Covers
	{
		 get { } //Length: 0
	}

	public CustomNavigationPoint CurCustomCoverPoint
	{
		 get { } //Length: 0
	}

	public EnemyInfo GoalEnemy
	{
		 get { } //Length: 0
	}

	public int Id
	{
		 get { } //Length: 0
	}

	public bool IsDamaged
	{
		 get { } //Length: 0
	}

	public CustomNavigationPoint LastCover
	{
		 get { } //Length: 0
	}

	public LayerMask LookSensorMask
	{
		 get { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public BotSettingsComponents Settings
	{
		 get { } //Length: 0
	}

	public WildSpawnType Type
	{
		 get { } //Length: 0
	}

	public HashSet CarePositions() { }

	public IBossToFollow get_BossToFollow() { }

	public BotGrenadeController get_BotGrenadeController() { }

	public StandartBotBrain get_Brain() { }

	public int get_ConnectionGroupId() { }

	public ICoversData get_Covers() { }

	public CustomNavigationPoint get_CurCustomCoverPoint() { }

	public EnemyInfo get_GoalEnemy() { }

	public int get_Id() { }

	public bool get_IsDamaged() { }

	public CustomNavigationPoint get_LastCover() { }

	public LayerMask get_LookSensorMask() { }

	public Vector3 get_Position() { }

	public BotSettingsComponents get_Settings() { }

	public WildSpawnType get_Type() { }

	public GroupPoint GetClosest(Vector3 pos, int botCGid) { }

	public GroupPoint GetClosestsPointVoxelesExtended(Vector3 pos, int rad, int connectionGroup, bool withFoliage = true) { }

	public List GetVoxelesExtended(Vector3 pos, int r, bool onlyWithPoints = false) { }

	public List GetVoxelesInRadius(int step) { }

	public NavGraphVoxelSimple GetVoxelSafe(Vector3 centerPos) { }

	public bool IsCurrentPointGood(CoverSearchType dataSearchType, CoverSearchData data, out CustomNavigationPoint point) { }

	public float MaxShootDist() { }

	public void SetLastSearchDebug(DebugCoverFindGraphSearchData debug) { }

}

