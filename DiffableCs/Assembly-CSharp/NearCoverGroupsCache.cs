//Type is in global namespace

public class NearCoverGroupsCache
{
	internal sealed class AddPointByDistDelegate : MulticastDelegate
	{

		public AddPointByDistDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CustomNavigationPoint point, CoverSearchData data, AsyncCallback callback, object object) { }

		public override int EndInvoke(IAsyncResult result) { }

		public override int Invoke(CustomNavigationPoint point, CoverSearchData data) { }

	}

	private readonly List _cachedPoints; //Field offset: 0x10
	private readonly List _cachedPointsCount; //Field offset: 0x18
	private readonly List _searchRadius; //Field offset: 0x20
	private readonly HashSet _emptyHashSet; //Field offset: 0x28

	public NearCoverGroupsCache() { }

	private void ComputeRadiusPool(CoverSearchData data) { }

	public void Dispose() { }

	public HashSet GetNearGroups(CustomNavigationPoint[] allCoverPoints, CoverSearchData data, int recursionLevel) { }

	private int GetRadiusIndexByBinarySearch(float sDist, int maxIterations) { }

	public Tuple GetSearchRadius(int iteration) { }

	private int ShallAddPointDist(CustomNavigationPoint point, CoverSearchData data) { }

}

