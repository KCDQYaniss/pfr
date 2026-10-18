namespace Audio.SpatialSystem;

public class AsyncRaycaster
{
	private readonly int _maxRaysCount; //Field offset: 0x10
	private readonly int _maxHitsCount; //Field offset: 0x14
	private NativeArray _raycastCommands; //Field offset: 0x18
	private NativeArray _raycastResults; //Field offset: 0x28
	private RaycastAllCommand _raycastAllCommand; //Field offset: 0x38
	private JobHandle _rayCastJobHandle; //Field offset: 0x60
	[CompilerGenerated]
	private readonly Dictionary <HitsData>k__BackingField; //Field offset: 0x70
	private bool _dataStored; //Field offset: 0x78
	private bool _multiHit; //Field offset: 0x79
	private readonly QueryParameters _queryParameters; //Field offset: 0x7C

	public Dictionary HitsData
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool IsCompleted
	{
		 get { } //Length: 93
	}

	public AsyncRaycaster(int maxBufferSize, int maxHits = 1, QueryParameters queryParameters = null) { }

	public void AddRaycastCommand(Vector3 startPoint, Vector3 direction, float distance, int index) { }

	public void ClearHitData() { }

	public void Dispose() { }

	public void Execute() { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public Dictionary get_HitsData() { }

	public bool get_IsCompleted() { }

	public void StoreResults() { }

}

