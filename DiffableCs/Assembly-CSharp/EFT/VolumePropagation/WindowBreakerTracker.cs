namespace EFT.VolumePropagation;

public sealed class WindowBreakerTracker
{
	private readonly Dictionary _windowVoxels; //Field offset: 0x10
	private readonly Dictionary _windowMasks; //Field offset: 0x18
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

	public WindowBreakerTracker() { }

	public Queue DequeueEvents() { }

	public void Dispose() { }

	public void EnsureTracked(WindowBreaker window) { }

	public bool get_HasEvents() { }

	public IReadOnlyDictionary get_Masks() { }

	private HashSet GetOrBuildMask(WindowBreaker window, Vector3 sourcePosition, float unitSize) { }

	public HashSet GetVoxelsFor(WindowBreaker window) { }

	private void HandleBroken(WindowBreaker window) { }

	public bool IsInsideMask(WindowBreaker window, int x, int y, int z, Vector3 sourcePosition, float unitSize) { }

	private static bool TryGetWindowBounds(WindowBreaker window, out Bounds bounds) { }

	public bool TryRegisterIfInsideWindow(int x, int y, int z, WindowBreaker candidate, Vector3 sourcePosition, float unitSize) { }

}

