namespace Audio.SpatialSystem;

public class SpatialAudioDataContainer : IDataContainer, IDisposable
{
	private struct PendingRoutes
	{
		public uint roomPairID; //Field offset: 0x0
		public AudioRouteData[] data; //Field offset: 0x8

	}

	private struct RouteRange
	{
		public int startIndex; //Field offset: 0x0
		public int endExclusive; //Field offset: 0x4

		public int Count
		{
			 get { } //Length: 6
		}

		public int get_Count() { }

	}

	public LocationBakeSettings bakeSettings; //Field offset: 0x10
	public uint roomPairMaxRoutesCapacity; //Field offset: 0x18
	public uint roomPairMaxPortalsCapacity; //Field offset: 0x1C
	private readonly PortalDataBufferService _portalDataBufferService; //Field offset: 0x20
	private readonly List _pendingRoutes; //Field offset: 0x28
	private NativeArray _allRoutesData; //Field offset: 0x30
	private readonly Dictionary _routesRangesByPair; //Field offset: 0x40
	private readonly Dictionary _portalsDataByID; //Field offset: 0x48
	private NativeArray _allRoutesPortalIndices; //Field offset: 0x50
	private readonly Dictionary _portalRangesByPair; //Field offset: 0x60
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"emitterId", "listenerId"})]
	private Dictionary _roomPairIndex; //Field offset: 0x68
	private bool _isDisposed; //Field offset: 0x70
	[CompilerGenerated]
	private readonly Dictionary <PortalsByID>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private readonly Dictionary <InteractivePortalsByID>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private readonly Dictionary <RoomsByID>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private readonly Dictionary <RoomPairsByID>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly Dictionary <RelevantRoomPairsByRoomID>k__BackingField; //Field offset: 0x98

	public bool HasPendingPortalUpdates
	{
		 get { } //Length: 98
	}

	public Dictionary InteractivePortalsByID
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool IsDisposed
	{
		 get { } //Length: 5
	}

	public Dictionary PortalsByID
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Dictionary RelevantRoomPairsByRoomID
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"emitterId", "listenerId"})]
	public IReadOnlyDictionary RoomPairIndex
	{
		 get { } //Length: 5
	}

	public Dictionary RoomPairsByID
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Dictionary RoomsByID
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int RoutesDataCount
	{
		 get { } //Length: 68
	}

	public NativeList StaticPortalDataList
	{
		 get { } //Length: 44
	}

	public SpatialAudioDataContainer() { }

	public void AddRoutesData(uint roomPairID, AudioRouteData[] data) { }

	public void AddStaticPortalData(BaseSpatialAudioPortal portal) { }

	public void BuildRoomPairIndex() { }

	public void Clear() { }

	private AudioPortalData CreatePortalData(BaseSpatialAudioPortal portal) { }

	public override void Dispose() { }

	public void FinalizePortalIndicesData() { }

	public void FinalizeRoutesData() { }

	public bool get_HasPendingPortalUpdates() { }

	[CompilerGenerated]
	public Dictionary get_InteractivePortalsByID() { }

	public bool get_IsDisposed() { }

	[CompilerGenerated]
	public Dictionary get_PortalsByID() { }

	[CompilerGenerated]
	public Dictionary get_RelevantRoomPairsByRoomID() { }

	public IReadOnlyDictionary get_RoomPairIndex() { }

	[CompilerGenerated]
	public Dictionary get_RoomPairsByID() { }

	[CompilerGenerated]
	public Dictionary get_RoomsByID() { }

	public int get_RoutesDataCount() { }

	public NativeList get_StaticPortalDataList() { }

	public void SwapPortalBuffers() { }

	public bool TryGetInteractivePortalById(string id, out BaseSpatialAudioPortal portal) { }

	public bool TryGetPortalById(short id, out BaseSpatialAudioPortal portal) { }

	public bool TryGetPortalIndicesData(uint roomPairID, out NativeArray data) { }

	public bool TryGetRoutesData(uint roomPairID, out NativeArray data) { }

	public void UpdateInitialPortalsData() { }

	public void UpdatePortalData(short portalID, PortalState portalState, float closureLevel, float depth, float traversalCost) { }

	private void UpdatePortalDataInternal(short portalID, float closureLevel, float depth, float traversalCost) { }

}

