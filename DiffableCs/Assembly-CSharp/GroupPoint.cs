//Type is in global namespace

public class GroupPoint : IClosePoint, IPositionPoint, IAICorePointLink
{
	public const float GROUP_POINT_NAV_SAMPLE_DIST = 1; //Field offset: 0x0
	public const int BASE_HIDE_VAL = 51; //Field offset: 0x0
	public const float CHECK_CAN_HIDE_STAY = 1.272; //Field offset: 0x0
	public const float LIGHT_WALL_ANG = 57; //Field offset: 0x0
	[SerializeField]
	public Vector3 FirePosition; //Field offset: 0x10
	[SerializeField]
	public int Index; //Field offset: 0x1C
	[SerializeField]
	public PointWithNeighborType PointWithNeighborType; //Field offset: 0x20
	[SerializeField]
	private Vector3 _position; //Field offset: 0x24
	public bool AlwaysGood; //Field offset: 0x30
	public CoverLevel CoverLevel; //Field offset: 0x34
	public int Id; //Field offset: 0x38
	public CoverPointDefenceInfo DefenceInfo; //Field offset: 0x40
	public Nullable AltPosition; //Field offset: 0x48
	public Vector3 WallDirection; //Field offset: 0x58
	public CoverType CoverType; //Field offset: 0x64
	public ECoverPointSpecial Special; //Field offset: 0x68
	public EnvironmentType EnvironmentType; //Field offset: 0x6C
	public int IdEnvironment; //Field offset: 0x70
	public int ConnectionGroup; //Field offset: 0x74
	public bool CanLookLeft; //Field offset: 0x78
	public bool CanLookRight; //Field offset: 0x79
	public bool BordersLightHave; //Field offset: 0x7A
	public Vector3 LeftBorderLight; //Field offset: 0x7C
	public Vector3 RightBorderLight; //Field offset: 0x88
	public BotTiltType TiltType; //Field offset: 0x94
	public bool IsGoodInsideBuilding; //Field offset: 0x98
	public List NeighbourhoodsWays; //Field offset: 0xA0
	public List NeighbourhoodsWaysIds; //Field offset: 0xA8
	public int ParentNavPoint; //Field offset: 0xB0
	public int CorePointId; //Field offset: 0xB4
	private Dictionary _childs; //Field offset: 0xB8
	private GroupPointInaGame _inGame; //Field offset: 0xC0
	public int PlaceId; //Field offset: 0xC8
	[CompilerGenerated]
	private float <MagnitudeForSort>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	private int <CounterId>k__BackingField; //Field offset: 0xD0
	private AICorePoint _corePoint; //Field offset: 0xD8

	public override AICorePoint CorePointInGame
	{
		 get { } //Length: 8
	}

	public int CounterId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public float DefenceLevel
	{
		 get { } //Length: 28
	}

	public int HideLevel
	{
		 get { } //Length: 6
	}

	public bool IsSpotted
	{
		 get { } //Length: 141
	}

	public float MagnitudeForSort
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public int OwnerInGame
	{
		 get { } //Length: 29
	}

	public override Vector3 Position
	{
		 get { } //Length: 19
	}

	public GroupPoint(int id, NavPoint point, Vector3 position, Nullable altPos, AICorePoint corePoint, CoverLevel coverLevel = 1, bool alwaysGood = false, Vector3 wallDirection = null, Vector3 firePosition = null, PointWithNeighborType pointWithNeighborType = 0) { }

	public void AddConnectedGroupPoint(GroupPointWay way) { }

	public void Block() { }

	public void CalcDefenceLevel() { }

	private bool CheckSideToHoles(Nullable sidePos) { }

	public CustomNavigationPoint CreateCustomNavigationPoint(int botOwnerId) { }

	public void DrawGizmos(bool withEdges, bool withCore, float upRay = -1) { }

	public override AICorePoint get_CorePointInGame() { }

	[CompilerGenerated]
	public int get_CounterId() { }

	public float get_DefenceLevel() { }

	public int get_HideLevel() { }

	public bool get_IsSpotted() { }

	[CompilerGenerated]
	public float get_MagnitudeForSort() { }

	public int get_OwnerInGame() { }

	public override Vector3 get_Position() { }

	public CustomNavigationPoint GetById(int botId) { }

	public void InitForGame(AICorePointHolder corePointHolder) { }

	public void InitLightBorders() { }

	private void InitLookSides() { }

	private void InitTilt() { }

	public bool IsFreeById(int botId) { }

	public override bool IsSameMeaning(IClosePoint p1, float sDist, out IClosePoint worst) { }

	public void RemoveWay(GroupPointWay target) { }

	public void ResetNeighborhoodsLists() { }

	[CompilerGenerated]
	public void set_CounterId(int value) { }

	[CompilerGenerated]
	public void set_MagnitudeForSort(float value) { }

	public void SetOwner(int owner) { }

	public void SetPlaceId(int placeId) { }

	public void SetPosition(Vector3 position) { }

	public void Spotted(float period) { }

	public void Unblock() { }

}

