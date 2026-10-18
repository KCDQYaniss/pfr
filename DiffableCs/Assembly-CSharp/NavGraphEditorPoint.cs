//Type is in global namespace

public class NavGraphEditorPoint : IPositionPoint
{
	public HashSet ClosestPointsAsPoints; //Field offset: 0x10
	public List ClosestPointsWaysIds; //Field offset: 0x18
	public List ClosestPointsWaysArray; //Field offset: 0x20
	public NavGraphEditorPointReachable Reachable; //Field offset: 0x28
	public int Id; //Field offset: 0x30
	public Vector3 _position; //Field offset: 0x34
	public bool IsInited; //Field offset: 0x40
	public float pathLength; //Field offset: 0x44
	public int _coverId; //Field offset: 0x48
	public NavGraphEditorPoint _parentPointSearchWay; //Field offset: 0x50
	public int SearchWayId; //Field offset: 0x58
	public uint SearchCoverId; //Field offset: 0x5C
	private PatrolPoint PatrolPoint; //Field offset: 0x60
	[CompilerGenerated]
	private GroupPoint <CoverData>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private NavGraphEditorPoint <nodeFrom>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private FloatNavGraphPoint <FloatNavGraphPoint>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private int <ParentPointSearchWayId>k__BackingField; //Field offset: 0x80

	public private GroupPoint CoverData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int CoverDataId
	{
		 get { } //Length: 4
	}

	public FloatNavGraphPoint FloatNavGraphPoint
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool HaveCoverId
	{
		 get { } //Length: 8
	}

	public bool HaveData
	{
		 get { } //Length: 42
	}

	public bool HaveLinkedCover
	{
		 get { } //Length: 9
	}

	public bool HavePatrol
	{
		 get { } //Length: 203
	}

	public NavGraphEditorPoint nodeFrom
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public NavGraphEditorPoint ParentPointSearchWay
	{
		 get { } //Length: 5
		 set { } //Length: 132
	}

	public private int ParentPointSearchWayId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override Vector3 Position
	{
		 get { } //Length: 19
	}

	private NavGraphEditorPoint(Vector3 p, int id, NavGraphEditorPointReachable reachable) { }

	public void AddWay(NavGraphEditorPointWay p1) { }

	public bool CanReach(NavGraphEditorPoint navGraphEditor) { }

	public static void ConnectPoints(NavGraphEditorPoint p1, NavGraphEditorPoint p2) { }

	public void Copy(NavGraphVoxel voxel, NavGraphContainer nContainer) { }

	public static NavGraphEditorPoint Create(Vector3 p, GroupPoint coverPoint, int id, NavGraphVoxel voxel, NavGraphContainer container, NavGraphEditorPointReachable reachable) { }

	public static NavGraphEditorPoint Create(Vector3 p, PatrolPoint pointToAdd, int id, NavGraphVoxel voxel, NavGraphContainer container, NavGraphEditorPointReachable reachable) { }

	public static NavGraphEditorPoint Create(Vector3 p, int id, NavGraphVoxel voxel, NavGraphContainer container, NavGraphEditorPointReachable reachable) { }

	[CompilerGenerated]
	public GroupPoint get_CoverData() { }

	public int get_CoverDataId() { }

	[CompilerGenerated]
	public FloatNavGraphPoint get_FloatNavGraphPoint() { }

	public bool get_HaveCoverId() { }

	public bool get_HaveData() { }

	public bool get_HaveLinkedCover() { }

	public bool get_HavePatrol() { }

	[CompilerGenerated]
	public NavGraphEditorPoint get_nodeFrom() { }

	public NavGraphEditorPoint get_ParentPointSearchWay() { }

	[CompilerGenerated]
	public int get_ParentPointSearchWayId() { }

	public override Vector3 get_Position() { }

	[CompilerGenerated]
	private void set_CoverData(GroupPoint value) { }

	[CompilerGenerated]
	public void set_FloatNavGraphPoint(FloatNavGraphPoint value) { }

	[CompilerGenerated]
	public void set_nodeFrom(NavGraphEditorPoint value) { }

	public void set_ParentPointSearchWay(NavGraphEditorPoint value) { }

	[CompilerGenerated]
	private void set_ParentPointSearchWayId(int value) { }

	public void SetCoverData(GroupPoint point) { }

	private void SetPatrolData(PatrolPoint pointToAdd) { }

}

