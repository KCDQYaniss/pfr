namespace EFT.VolumePropagation;

public class VolumeCollisionHandler
{
	private const int COLLIDER_BUFFER_SIZE = 8; //Field offset: 0x0
	private const int RAYCAST_BUFFER_SIZE = 8; //Field offset: 0x0
	private const int DOOR_DISCOVERY_BUFFER_SIZE = 128; //Field offset: 0x0
	private readonly Collider[] _buffer; //Field offset: 0x10
	private readonly Collider[] _doorDiscoveryBuffer; //Field offset: 0x18
	private readonly RaycastHit[] _raycastHits; //Field offset: 0x20
	private readonly Dictionary _doorCache; //Field offset: 0x28
	private readonly Dictionary _windowCache; //Field offset: 0x30
	private readonly HashSet _doorDiscoveryDedup; //Field offset: 0x38
	private readonly LayerMask _doorLayerMask; //Field offset: 0x40
	private readonly LayerMask _geometryLayerMask; //Field offset: 0x44

	public VolumeCollisionHandler() { }

	public void DiscoverDoorsInRadius(Vector3 center, float radius, DoorVoxelTracker doorTracker, Vector3 sourcePosition, float unitSize) { }

	public bool Evaluate(Vector3 childWorldCenter, Vector3 parentWorldCenter, int gridX, int gridY, int gridZ, Vector3 sourcePosition, float unitSize, DoorVoxelTracker doorTracker, WindowBreakerTracker windowTracker, out Door doorHit, out WindowBreaker windowHit) { }

	private static bool IsDoorInMask(Door door, int gridX, int gridY, int gridZ, Vector3 sourcePosition, float unitSize, DoorVoxelTracker doorTracker) { }

	private static bool IsDoorOpen(Door door) { }

	private bool IsRayBlocked(Vector3 from, Vector3 to, float unitSize, int gridX, int gridY, int gridZ, Vector3 sourcePosition, DoorVoxelTracker doorTracker, WindowBreakerTracker windowTracker, out Door doorHit, out WindowBreaker windowHit) { }

	private static bool IsWindowInMask(WindowBreaker window, int gridX, int gridY, int gridZ, Vector3 sourcePosition, float unitSize, WindowBreakerTracker windowTracker) { }

	private bool TryResolveDoor(Collider collider, out Door door) { }

	private void TryResolveDoorOrWindow(Collider col, ref Door door, ref WindowBreaker window) { }

	private bool TryResolveWindow(Collider collider, out WindowBreaker window) { }

}

