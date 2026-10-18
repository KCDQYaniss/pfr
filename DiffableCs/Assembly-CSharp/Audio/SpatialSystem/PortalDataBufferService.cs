namespace Audio.SpatialSystem;

public class PortalDataBufferService : IDisposable
{
	private struct PendingUpdate
	{
		public short portalID; //Field offset: 0x0
		public AudioPortalData data; //Field offset: 0x4

	}

	private NativeList _buffer0; //Field offset: 0x10
	private NativeList _buffer1; //Field offset: 0x18
	private Dictionary _indexMap; //Field offset: 0x20
	private bool _usingBuffer0; //Field offset: 0x28
	private readonly List _pending0; //Field offset: 0x30
	private readonly List _pending1; //Field offset: 0x38

	public bool HasPendingUpdates
	{
		 get { } //Length: 92
	}

	public PortalDataBufferService(int initialCapacity = 0) { }

	public void AddPortal(short portalID, AudioPortalData data) { }

	public void Clear() { }

	public override void Dispose() { }

	public bool get_HasPendingUpdates() { }

	public NativeList GetActiveList() { }

	public int GetIndex(short portalID) { }

	public void SwapBuffers() { }

	public void UpdatePortalData(short portalID, AudioPortalData data) { }

}

