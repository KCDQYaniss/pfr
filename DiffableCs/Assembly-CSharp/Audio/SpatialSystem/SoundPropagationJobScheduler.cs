namespace Audio.SpatialSystem;

public class SoundPropagationJobScheduler : IDisposable
{
	private const byte ENDPOINT_NODES_COUNT = 2; //Field offset: 0x0
	private const short MIN_DYNAMIC_ROUTES = 350; //Field offset: 0x0
	private readonly PropagationSettings _settings; //Field offset: 0x10
	private NativeArray _routeNodesData; //Field offset: 0x18
	private NativeArray _routesSettingsData; //Field offset: 0x28
	private NativeArray _routesPortalIndicesData; //Field offset: 0x38
	private NativeList _staticPortalDataList; //Field offset: 0x48
	private NativeArray _lowestCost; //Field offset: 0x50
	private NativeArray _bestCost; //Field offset: 0x60
	private NativeArray _lowestDistance; //Field offset: 0x70
	private NativeArray _bestDistance; //Field offset: 0x80
	private float _propagationScore; //Field offset: 0x90
	[CompilerGenerated]
	private JobHandle <LastHandle>k__BackingField; //Field offset: 0x98

	public bool DataDisposed
	{
		 get { } //Length: 56
	}

	public private JobHandle LastHandle
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public float PropagationScore
	{
		 get { } //Length: 33
	}

	public SoundPropagationJobScheduler(SpatialAudioLocationInfo locationInfo, PropagationSettings settings) { }

	public void Complete() { }

	public void CompleteAndDisposeData() { }

	public override void Dispose() { }

	public void DisposeData() { }

	public bool get_DataDisposed() { }

	[CompilerGenerated]
	public JobHandle get_LastHandle() { }

	public float get_PropagationScore() { }

	public void PrepareData(RoomPair roomPair, bool isGlobalDataNeedUpdate) { }

	public JobHandle Schedule(in Vector3 sourcePosition, in Vector3 listenerPosition, bool isReversed, float qualityFactor = 1) { }

	[CompilerGenerated]
	private void set_LastHandle(JobHandle value) { }

}

