//Type is in global namespace

public class CustomNavigationPoint : IPositionPoint, IAICorePointLink
{
	public const float MAX_DEFENCE_LEVEL_SIDE = 8; //Field offset: 0x0
	public const int MAX_HIDE_VAL = 100; //Field offset: 0x0
	public bool CanIShootToEnemy; //Field offset: 0x10
	public bool lastCanShoot; //Field offset: 0x11
	private float _startBaseWeight; //Field offset: 0x14
	private float _coveringWeight; //Field offset: 0x18
	private float _decreasedWeightCoef; //Field offset: 0x1C
	private float _nextCheckCanShootTime; //Field offset: 0x20
	private GroupPoint _groupPoint; //Field offset: 0x28

	public Vector3 AltPosition
	{
		 get { } //Length: 106
	}

	public bool AlwaysGood
	{
		 get { } //Length: 27
	}

	public Vector3 BasePosition
	{
		 get { } //Length: 41
	}

	public float BaseWeight
	{
		 get { } //Length: 6
		 set { } //Length: 25
	}

	public bool BordersLightHave
	{
		 get { } //Length: 27
	}

	public bool CanLookLeft
	{
		 get { } //Length: 27
	}

	public bool CanLookRight
	{
		 get { } //Length: 27
	}

	public override AICorePoint CorePointInGame
	{
		 get { } //Length: 30
	}

	public private float CoveringWeight
	{
		 get { } //Length: 6
		private set { } //Length: 6
	}

	public CoverLevel CoverLevel
	{
		 get { } //Length: 26
	}

	public CoverType CoverType
	{
		 get { } //Length: 26
	}

	public CoverPointDefenceInfo DefenceInfo
	{
		 get { } //Length: 27
	}

	public int EnvironmentId
	{
		 get { } //Length: 26
	}

	public EnvironmentType EnvironmentType
	{
		 get { } //Length: 26
	}

	public Vector3 FirePosition
	{
		 get { } //Length: 41
	}

	public GroupPoint GroupPoint
	{
		 get { } //Length: 5
	}

	public bool HaveAltPosition
	{
		 get { } //Length: 66
	}

	public int HideLevel
	{
		 get { } //Length: 26
	}

	public int Id
	{
		 get { } //Length: 26
	}

	public int IdPoint
	{
		 get { } //Length: 26
	}

	public bool IsGoodInsideBuilding
	{
		 get { } //Length: 30
	}

	public bool IsSpotted
	{
		 get { } //Length: 29
	}

	public Vector3 LeftBorderLight
	{
		 get { } //Length: 44
	}

	public int Owner
	{
		 get { } //Length: 38
	}

	public int ParentGroupPointId
	{
		 get { } //Length: 26
	}

	public int PlaceId
	{
		 get { } //Length: 29
	}

	public override Vector3 Position
	{
		 get { } //Length: 41
	}

	public Vector3 RightBorderLight
	{
		 get { } //Length: 47
	}

	public ECoverPointSpecial Special
	{
		 get { } //Length: 26
	}

	public PointWithNeighborType StrategyType
	{
		 get { } //Length: 26
	}

	public BotTiltType TiltType
	{
		 get { } //Length: 29
	}

	public Vector3 ToWallVector
	{
		 get { } //Length: 41
	}

	public CustomNavigationPoint(GroupPoint groupPoint) { }

	public void Block() { }

	public bool CanIHide(IEnumerable positionsIMustCare, float minSDistToEnemy, bool useRaycast, bool useAng = true) { }

	public bool CanIHideFromPos(float minSDistToEnemy, bool useRaycast, bool useAng, Vector3 pos) { }

	public bool CanShootToTargetCast(BotOwner shooter, float deltaLastTimeVision) { }

	private void DrawHideLvl() { }

	private void DrawInsideRoom() { }

	public Vector3 get_AltPosition() { }

	public bool get_AlwaysGood() { }

	public Vector3 get_BasePosition() { }

	public float get_BaseWeight() { }

	public bool get_BordersLightHave() { }

	public bool get_CanLookLeft() { }

	public bool get_CanLookRight() { }

	public override AICorePoint get_CorePointInGame() { }

	public float get_CoveringWeight() { }

	public CoverLevel get_CoverLevel() { }

	public CoverType get_CoverType() { }

	public CoverPointDefenceInfo get_DefenceInfo() { }

	public int get_EnvironmentId() { }

	public EnvironmentType get_EnvironmentType() { }

	public Vector3 get_FirePosition() { }

	public GroupPoint get_GroupPoint() { }

	public bool get_HaveAltPosition() { }

	public int get_HideLevel() { }

	public int get_Id() { }

	public int get_IdPoint() { }

	public bool get_IsGoodInsideBuilding() { }

	public bool get_IsSpotted() { }

	public Vector3 get_LeftBorderLight() { }

	public int get_Owner() { }

	public int get_ParentGroupPointId() { }

	public int get_PlaceId() { }

	public override Vector3 get_Position() { }

	public Vector3 get_RightBorderLight() { }

	public ECoverPointSpecial get_Special() { }

	public PointWithNeighborType get_StrategyType() { }

	public BotTiltType get_TiltType() { }

	public Vector3 get_ToWallVector() { }

	public bool IsDangerPositionFarEnough(IEnumerable positionsIMustCare, float minSDistToEnemy) { }

	public bool IsFreeById(int ownerId) { }

	public bool IsGoodForGrenade(GrenadeDangerPoint grenadeDangerPoint, BotOwner owner) { }

	public void OnDrawGizmosAsAmbush(Nullable cameraPos = null, float sDist = 0, bool drawSides = true) { }

	public void OnDrawGizmosFullAsCover(Nullable cameraPos = null, float sDist = 0, bool drawSides = true) { }

	public void set_BaseWeight(float value) { }

	private void set_CoveringWeight(float value) { }

	public void SetClose() { }

	public void SetDecreasedWeight(bool val) { }

	public void SetFree() { }

	public void SetLong() { }

	public void SetOwner(BotOwner owner) { }

	public void SetWeight(float v, bool withBaseWeight = true) { }

	public void Spotted(float period) { }

	public void Unblock() { }

}

