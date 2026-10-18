//Type is in global namespace

public interface ICoversData
{

	public int ConnectionGroupId
	{
		 get { } //Length: 0
	}

	public CustomNavigationPoint LastCustomNavigationPoint
	{
		 get { } //Length: 0
	}

	public CustomNavigationPoint FindClosestPoint(Vector3 dataCenterPos, bool noRestrictions = false, Func goodFunc = null) { }

	public int get_ConnectionGroupId() { }

	public CustomNavigationPoint get_LastCustomNavigationPoint() { }

	public GroupPoint GetClosest(Vector3 center, int connectionGroupId) { }

	public GroupPoint GetClosestByClosestsVoxeles(Vector3 center) { }

	public CustomNavigationPoint GetFreeClosePoint(Vector3 pos, float minSDistToEnemy) { }

}

