//Type is in global namespace

public class NavGraphVoxel : NavGraphVoxelBase
{
	public List Points; //Field offset: 0x28
	public List Pathes; //Field offset: 0x30
	public List Neightbourhoods; //Field offset: 0x38
	public NavMeshDoorLink[] DoorLinks; //Field offset: 0x40
	public NavMeshDoorLink[] DoorLinksAffected; //Field offset: 0x48
	public List PointsIds; //Field offset: 0x50
	public List NeightbourhoodsIds; //Field offset: 0x58

	public NavGraphVoxel(Vector3 pos, int indexX, int indexY, int indexZ, int id) { }

	public void AddNeightbourhood(NavGraphVoxel voxeles) { }

	public void AddPoint(NavGraphEditorPoint newPoint) { }

	public NavGraphEditorPoint GetClosestPoint(Vector3 crn, out float sDist, int excuedPoint = -1) { }

	public Vector3 GetSize() { }

	public void OnDrawGizmos(Color color, float sizeCoef = 1) { }

	public void RemovePoint(NavGraphEditorPoint point) { }

	public virtual string ToString() { }

}

