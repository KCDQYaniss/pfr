namespace EFT.VolumePropagation;

public sealed class DoorVoxelTracker
{
	private readonly Dictionary _doorVoxels; //Field offset: 0x10
	private readonly Dictionary _doorMasks; //Field offset: 0x18
	private readonly Queue _events; //Field offset: 0x20
	private readonly HashSet _subscribed; //Field offset: 0x28

	public bool HasEvents
	{
		 get { } //Length: 69
	}

	public IReadOnlyDictionary Masks
	{
		 get { } //Length: 5
	}

	public DoorVoxelTracker() { }

	public HashSet CollectVoxelsInsideMask(Door door, Vector3 sourcePosition, float unitSize) { }

	public Queue DequeueEvents() { }

	public void Dispose() { }

	public void EnsureTracked(Door door) { }

	public bool get_HasEvents() { }

	public IReadOnlyDictionary get_Masks() { }

	private HashSet GetOrBuildMask(Door door, Vector3 sourcePosition, float unitSize) { }

	public HashSet GetVoxelsFor(Door door) { }

	private void HandleDoorStateChanged(WorldInteractiveObject obj, EDoorState prev, EDoorState next) { }

	public void RegisterVoxel(Door door, long packedPos) { }

	private static bool TryComputeClosedBounds(Door door, out Bounds bounds) { }

	public bool TryRegisterIfInsideAnyDoor(int x, int y, int z, Door candidateDoor, Vector3 sourcePosition, float unitSize) { }

}

