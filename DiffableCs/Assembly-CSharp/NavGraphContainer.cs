//Type is in global namespace

public class NavGraphContainer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public NavGraphEditorPoint from; //Field offset: 0x10
		public NavGraphEditorPoint to; //Field offset: 0x18

		public <>c__DisplayClass45_0() { }

		internal bool <HaveSamePath>b__0(NavGraphEditorPath x) { }

	}

	public List DoorLinks; //Field offset: 0x20
	public List Points; //Field offset: 0x28
	public List Path; //Field offset: 0x30
	public List PointWays; //Field offset: 0x38
	public List VoxelsList; //Field offset: 0x40
	public Dictionary DcPoints; //Field offset: 0x48
	public Dictionary DcPath; //Field offset: 0x50
	public Dictionary DcPointWays; //Field offset: 0x58
	public Dictionary DcVoxeles; //Field offset: 0x60
	public NavGraphVoxel[,,] VoxelesArray; //Field offset: 0x68
	public int MaxX; //Field offset: 0x70
	public int MaxY; //Field offset: 0x74
	public int MaxZ; //Field offset: 0x78
	public bool _drawSelected; //Field offset: 0x7C
	public float DistDrawCover; //Field offset: 0x80
	public float DistDrawVoxeles; //Field offset: 0x84
	public bool DrawVoxeles; //Field offset: 0x88
	public bool IsInited; //Field offset: 0x89
	private int _searchId; //Field offset: 0x8C
	private Vector3 min; //Field offset: 0x90
	private Vector3 max; //Field offset: 0x9C
	private int _nextId; //Field offset: 0xA8
	private NavGraphWayAstar _lastWayAstar; //Field offset: 0xB0

	public Vector3 Max
	{
		 get { } //Length: 25
	}

	public Vector3 Min
	{
		 get { } //Length: 25
	}

	public NavGraphContainer() { }

	private void AddNeighbouhoods(int deltaX, int deltaY, int deltaZ) { }

	public void AddPath(NavGraphEditorPath navGraphEditorPath) { }

	public void AddWay(NavGraphEditorPointWay p1) { }

	public void CheckData() { }

	public static List CollectCovers() { }

	private static List CollectPointForMinMax() { }

	public void ConvertDicToList() { }

	public void ConvertListToDic() { }

	public static NavGraphContainer CreateOfFind() { }

	private void CreateVoxeles() { }

	public Vector3 get_Max() { }

	public Vector3 get_Min() { }

	private static NavGraphEditorPoint GetClosestPointRecursion(Vector3 pos, NavGraphVoxel voxel, HashSet used) { }

	public NavGraphEditorPoint GetClosets(Vector3 pos) { }

	public int GetNewId() { }

	public int GetSearchIdInGame() { }

	public NavGraphVoxel GetVoxelByIndex(int i, int j, int k) { }

	public NavGraphVoxel GetVoxelEditor(Vector3 pos) { }

	public NavGraphVoxel GetVoxelSafe(Vector3 pos, bool withLogs = false) { }

	public NavGraphEditorPointWay GetWay(int navGraphEditorPointWay) { }

	private void GizmosDrawGraph() { }

	public bool HaveSamePath(NavGraphEditorPoint from, NavGraphEditorPoint to) { }

	public void InitEditor() { }

	private void InitMinMax(List points) { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	public void RefreshData() { }

	public void RefreshPointsData() { }

	public void RemovePoint(NavGraphEditorPoint point) { }

	public void ResetId() { }

	private void RestoreNeightbourhoods(Dictionary dcVoxeles) { }

	public void SetLastWayAstar(NavGraphWayAstar wayStarCalc) { }

	private void TryDrawVoxeles() { }

}

