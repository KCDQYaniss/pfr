//Type is in global namespace

public class NavGraphVoxelSimple : NavGraphVoxelBase
{
	[SerializeField]
	private int _closetsPointId; //Field offset: 0x28
	public List LootPoints; //Field offset: 0x30
	public List ExfiltrationPoints; //Field offset: 0x38
	public List Points; //Field offset: 0x40
	public List DoorLinks; //Field offset: 0x48
	public List BotsInside; //Field offset: 0x50
	public List Mines; //Field offset: 0x58
	public List PlacesToAvoid; //Field offset: 0x60
	public bool HaveNavMesh; //Field offset: 0x68
	public List PointsIds; //Field offset: 0x70
	public List EntrancesIds; //Field offset: 0x78
	public List DoorLinksIds; //Field offset: 0x80
	public List LootPointsIds; //Field offset: 0x88
	public List ExfiltrationPointsIds; //Field offset: 0x90
	[CompilerGenerated]
	private GroupPoint <PointStartSearch>k__BackingField; //Field offset: 0x98

	public bool HaveStartPointId
	{
		 get { } //Length: 8
	}

	public private GroupPoint PointStartSearch
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public NavGraphVoxelSimple(Vector3 pos, int indexX, int indexY, int indexZ, int id) { }

	public void AddCover(GroupPoint cover) { }

	public void AddDoor(NavMeshDoorLink link) { }

	public void AddExfiltrationPoint(AIExfiltrationPoint logic) { }

	public void AddLootPoint(AILootPoint logic) { }

	public void AddMine(PlantedMineAIInfo mine) { }

	public void AddNeightbourhood(NavGraphVoxelSimple voxel) { }

	public void AddPlaceToAvoid(IPositionPoint mine) { }

	public void ClearDoors() { }

	public void ClearEntrances() { }

	public void ClearLootPoints() { }

	public void DrawDebug(Color color, float sizeCoef = 1) { }

	public void DrawGizmos(bool drawClosestPoint, bool drawDoorsLinks, float sizeCoef = 1, bool drawPointsInside = false, Nullable color = null) { }

	public GroupPoint FindClosest(int botId, Vector3 pos, bool noRestrictions) { }

	[CanBeNull]
	public GroupPoint FindClosestPoint(int botId, Vector3 pos, bool noRestrictions = false, Func isGood = null) { }

	public bool get_HaveStartPointId() { }

	[CompilerGenerated]
	public GroupPoint get_PointStartSearch() { }

	public GroupPoint GetClosestPoint(Vector3 crn, out float sDist) { }

	public GroupPoint GetClosestPoint(Vector3 crn, out float sDist, int excludedPoint) { }

	public List GetNearestMines() { }

	public List GetNearestPlacesToAvoid() { }

	public Vector3 GetSize() { }

	public void RemoveMine(PlantedMineAIInfo mine) { }

	public void RemovePlaceToAvoid(IPositionPoint mine) { }

	public void RemovePoint(GroupPoint point) { }

	public void Restore(Dictionary data) { }

	[CompilerGenerated]
	private void set_PointStartSearch(GroupPoint value) { }

	public void SetClosestsPoint(GroupPoint closetsPoint) { }

}

