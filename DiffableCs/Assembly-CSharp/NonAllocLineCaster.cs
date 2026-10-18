//Type is in global namespace

public static class NonAllocLineCaster
{
	private const int MIN_HITS_COUNT = 3; //Field offset: 0x0
	private static RaycastHit _nearestHit; //Field offset: 0x0
	private static readonly RaycastHit[] _nearestRayHits; //Field offset: 0x30
	private static RaycastHit[] _allRayHits; //Field offset: 0x38

	private static NonAllocLineCaster() { }

	public static RaycastHit[] GetAllHits(Vector3 startPos, Vector3 endPos, int layerMask, int maxHits = 5) { }

	public static bool GetNearestHit(Vector3 startPos, Vector3 endPos, out RaycastHit hitInfo, int layerMask) { }

	public static bool GetNearestHit(Vector3 startPos, Vector3 endPos, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool TryGetComponentFromRaycast(Vector3 startPos, Vector3 endPos, float maxDistance, int layerMask, out T component) { }

}

