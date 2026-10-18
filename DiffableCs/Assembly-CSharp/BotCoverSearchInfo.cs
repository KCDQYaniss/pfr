//Type is in global namespace

public class BotCoverSearchInfo : BotData, ICoverSearchBot
{
	private DebugCoverFindGraphSearchData _lastDebug; //Field offset: 0x18
	private DebugCoverFindGraphClosests _lastDebugClosests; //Field offset: 0x20
	public int DebugLastCoverDrawSteps; //Field offset: 0x28
	public int DebugLastCoverDrawClosests; //Field offset: 0x2C

	public override IBossToFollow BossToFollow
	{
		 get { } //Length: 39
	}

	public override BotGrenadeController BotGrenadeController
	{
		 get { } //Length: 39
	}

	public override StandartBotBrain Brain
	{
		 get { } //Length: 30
	}

	public override int ConnectionGroupId
	{
		 get { } //Length: 38
	}

	public override ICoversData Covers
	{
		 get { } //Length: 30
	}

	public override CustomNavigationPoint CurCustomCoverPoint
	{
		 get { } //Length: 45
	}

	public override EnemyInfo GoalEnemy
	{
		 get { } //Length: 36
	}

	public override int Id
	{
		 get { } //Length: 29
	}

	public override bool IsDamaged
	{
		 get { } //Length: 114
	}

	public override CustomNavigationPoint LastCover
	{
		 get { } //Length: 45
	}

	public DebugCoverFindGraphClosests LastDebugClosest
	{
		 get { } //Length: 5
	}

	public DebugCoverFindGraphSearchData LastDebugFunc
	{
		 get { } //Length: 5
	}

	public override LayerMask LookSensorMask
	{
		 get { } //Length: 41
	}

	public override Vector3 Position
	{
		 get { } //Length: 95
	}

	public override BotSettingsComponents Settings
	{
		 get { } //Length: 36
	}

	public override WildSpawnType Type
	{
		 get { } //Length: 71
	}

	public BotCoverSearchInfo(BotOwner owner) { }

	public override HashSet CarePositions() { }

	public override IBossToFollow get_BossToFollow() { }

	public override BotGrenadeController get_BotGrenadeController() { }

	public override StandartBotBrain get_Brain() { }

	public override int get_ConnectionGroupId() { }

	public override ICoversData get_Covers() { }

	public override CustomNavigationPoint get_CurCustomCoverPoint() { }

	public override EnemyInfo get_GoalEnemy() { }

	public override int get_Id() { }

	public override bool get_IsDamaged() { }

	public override CustomNavigationPoint get_LastCover() { }

	public DebugCoverFindGraphClosests get_LastDebugClosest() { }

	public DebugCoverFindGraphSearchData get_LastDebugFunc() { }

	public override LayerMask get_LookSensorMask() { }

	public override Vector3 get_Position() { }

	public override BotSettingsComponents get_Settings() { }

	public override WildSpawnType get_Type() { }

	public override GroupPoint GetClosest(Vector3 pos, int botCGid) { }

	public override GroupPoint GetClosestsPointVoxelesExtended(Vector3 pos, int r, int connectionGroup, bool withFoliage) { }

	public override List GetVoxelesExtended(Vector3 pos, int r, bool onlyWithPoints = false) { }

	public override List GetVoxelesInRadius(int step) { }

	public override NavGraphVoxelSimple GetVoxelSafe(Vector3 centerPos) { }

	public override bool IsCurrentPointGood(CoverSearchType dataSearchType, CoverSearchData data, out CustomNavigationPoint point) { }

	public override float MaxShootDist() { }

	public void SetLastSearchClosestsDebug(NetCalcSortedList list, Vector3 startPos, CustomNavigationPoint taken) { }

	public override void SetLastSearchDebug(DebugCoverFindGraphSearchData debug) { }

	public void TryDrawGizmosLastSearchDebugByFull() { }

	public void TryDrawGizmosLastSearchDebugClosest() { }

}

