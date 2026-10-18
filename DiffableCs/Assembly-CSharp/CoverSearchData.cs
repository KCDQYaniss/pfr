//Type is in global namespace

public class CoverSearchData
{
	public readonly ICoverSearchBot Bot; //Field offset: 0x10
	public float MinDistSqr; //Field offset: 0x18
	public float MaxDistSqr; //Field offset: 0x1C
	public float MinSDistToCarePos; //Field offset: 0x20
	public CoverSearchType SearchType; //Field offset: 0x24
	public ShootToPoint Shoot2Point; //Field offset: 0x28
	public HashSet CarePositions; //Field offset: 0x30
	public Vector3 CenterPos; //Field offset: 0x38
	public ECheckSHootHide CheckShootHide; //Field offset: 0x44
	public Nullable PointToBeClose; //Field offset: 0x48
	public bool UseLineCastToCover; //Field offset: 0x58
	public bool UseAngCastToCover; //Field offset: 0x59
	public CoverShootType shootType; //Field offset: 0x5C
	public PointsArrayType ArrayType; //Field offset: 0x60
	public bool UseSelfFindPoint; //Field offset: 0x64
	public EditorsCoverPointDebugData EditorsCoverPointDebugData; //Field offset: 0x68
	public DebugCoverPointsLoggerCollector DebugCoverPointsDataCollector; //Field offset: 0x70
	[CanBeNull]
	public Nullable PlaceInfo; //Field offset: 0x78
	[CanBeNull]
	public Nullable EnvironmentId; //Field offset: 0x80
	public ECoverPointSpecial Special; //Field offset: 0x88
	public Nullable CloseFriendCover; //Field offset: 0x8C
	[Obsolete]
	public CoverSearchDefenceData coverSearchDefenceData; //Field offset: 0xA0
	public string searchLabel; //Field offset: 0xA8
	private bool _extraPlacementsDropped; //Field offset: 0xB0
	[CompilerGenerated]
	private int <PointsCheckedTotal>k__BackingField; //Field offset: 0xB4
	[CompilerGenerated]
	private int <PointsCheckedRay>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private int <MaxIterations>k__BackingField; //Field offset: 0xBC
	private int _stepToDropExtraPlacements; //Field offset: 0xC0

	public int MaxIterations
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private int PointsCheckedRay
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int PointsCheckedTotal
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public CoverSearchData(Vector3 centerPos, ICoverSearchBot bot, CoverShootType shootType, float maxDistSqr, float minDistSqr, CoverSearchType searchType, ShootToPoint shoot2point, Nullable closeFriendCover, Nullable pointToBeClose, ECheckSHootHide shootHide, CoverSearchDefenceData coverSearchDefenceData, PointsArrayType arrayType = 0, bool useSelfFindPoint = true, Nullable placeInfo = null, Nullable maxIterations = null, string label = "Default") { }

	private CoverSearchData(Vector3 centerPos, ICoverSearchBot bot, CoverShootType shootType, float maxDistSqr, float minDistSqr, CoverSearchType searchType, ShootToPoint shoot2point, Nullable closeFriendCover, Nullable pointToBeClose, HashSet carePositions, ECheckSHootHide CheckShootHide, bool useLineCastToCover, CoverSearchDefenceData coverSearchDefenceData, float minSDistToCarePos, Nullable placeInfo, EditorsCoverPointDebugData editorsCoverPointDebugData, int maxIterations, string label) { }

	public void AddPointCheckRay() { }

	private float CalcCoef(float distToPoint, float deltaShoot, float preferedDist, float coefLevel, float closeFriendCover) { }

	private float CalcCoef(float distToPos, float defenceLevel) { }

	private float CalcCoefSimple(float distToPoint) { }

	protected float CalcDist(GroupPoint point, float preferedDist) { }

	public override float CalcPowerOnlyDistToBot(GroupPoint point) { }

	public float CalcPowerPoint(GroupPoint point) { }

	private float ClosestFriendCoef(IPositionPoint point) { }

	protected float DistToBot(GroupPoint point) { }

	private float DistToPoint(IPositionPoint point) { }

	[CompilerGenerated]
	public int get_MaxIterations() { }

	[CompilerGenerated]
	public int get_PointsCheckedRay() { }

	[CompilerGenerated]
	public int get_PointsCheckedTotal() { }

	public float GetPower(GroupPoint point) { }

	public void IncreasePointCheckCounter() { }

	public float PowerDistToBot(GroupPoint point) { }

	public float PowerDistToBotAndToTarget(GroupPoint point) { }

	public float PowerDistToCenter(IPositionPoint point, Vector3 p) { }

	public float PowerDistToPoint(GroupPoint point) { }

	public void RefreshCollectionInfo() { }

	[CompilerGenerated]
	public void set_MaxIterations(int value) { }

	[CompilerGenerated]
	private void set_PointsCheckedRay(int value) { }

	[CompilerGenerated]
	private void set_PointsCheckedTotal(int value) { }

	public void SetStepToDropsExtraPlacements(int count) { }

	public void TryDropExtraPlacements(int currentPointChecksCount) { }

}

