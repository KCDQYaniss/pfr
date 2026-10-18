namespace Audio.SpatialSystem;

public sealed class AudioRoomStorage
{
	private sealed class RoomSizeThenIdComparer : IComparer
	{

		public RoomSizeThenIdComparer() { }

		public override int Compare(ISpatialAudioRoom x, ISpatialAudioRoom y) { }

	}

	private const short ALLOWED_PROPOSED_ROOMS = 5; //Field offset: 0x0
	private const float ROOM_EXPAND_MARGIN = 0.1; //Field offset: 0x0
	private static readonly RoomSizeThenIdComparer _roomSizeThenIdComparer; //Field offset: 0x0
	private readonly List _validSpatialAudioRooms; //Field offset: 0x10
	private readonly List _outdoorAudioRooms; //Field offset: 0x18
	private readonly Dictionary _orderedConnections; //Field offset: 0x20
	private readonly List _proposedRooms; //Field offset: 0x28
	private readonly List _listenerCurrentIndoorRooms; //Field offset: 0x30
	private readonly List _listenerCurrentOutdoorRooms; //Field offset: 0x38
	private readonly Dictionary _playerCurrentIndoorRooms; //Field offset: 0x40
	private readonly Dictionary _playerCurrentOutdoorRooms; //Field offset: 0x48
	private readonly ISpatialAudioRoom _emptyRoom; //Field offset: 0x50
	private ISpatialAudioRoom _temporaryListenerRoomOverride; //Field offset: 0x58
	private EAudioRoomTypeMask _currentPlayerRoomTypeMask; //Field offset: 0x60
	private Octree _roomOctree; //Field offset: 0x68
	private readonly List _octreeCandidates; //Field offset: 0x70
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"emitterId", "listenerId"})]
	private readonly Dictionary _roomPairCache; //Field offset: 0x78
	[CompilerGenerated]
	private bool <IsTemporaryListenerOverrideActive>k__BackingField; //Field offset: 0x80

	public private bool IsTemporaryListenerOverrideActive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public int ListenerCurrentOutdoorRoomID
	{
		 get { } //Length: 168
	}

	public ISpatialAudioRoom ListenerCurrentRoom
	{
		 get { } //Length: 190
	}

	public int ListenerCurrentRoomID
	{
		 get { } //Length: 112
	}

	private static AudioRoomStorage() { }

	public AudioRoomStorage() { }

	private void AddListenerCurrentRoom(SpatialAudioRoom room) { }

	public void AddPlayerCurrentRoom(SpatialAudioRoom room, IPlayer player) { }

	private void BuildOctree() { }

	private bool CheckBoundsIntersectRoom(ISpatialAudioRoom room, in SourceBoundsCache sourceCache) { }

	private bool CheckPositionInsideRoom(ISpatialAudioRoom room, Vector3 position) { }

	private void CheckValidRooms(List audioRooms) { }

	public void Clear() { }

	public void ClearTemporaryListenerRoom() { }

	private void FillData() { }

	private void FillOrderedConnection(SpatialAudioRoom room) { }

	public ISpatialAudioRoom FindActualCurrentRoom(ISpatialAudioRoom previouslyKnownRoom, in SourceBoundsCache sourceCache) { }

	private static List FindAllConnectedRooms(SpatialAudioRoom startingRoom) { }

	public ISpatialAudioRoom FindInitialRoomOptimized(Vector3 position) { }

	private ISpatialAudioRoom FindMinSizeRoom(ISpatialAudioRoom roomA, ISpatialAudioRoom roomB) { }

	private ISpatialAudioRoom FindProposedRoom(List roomsToCheck, Vector3 position) { }

	private ISpatialAudioRoom FindProposedRoom(List connectionsToCheck, Vector3 position) { }

	private ISpatialAudioRoom FindSmallestRoomRecursively(IReadOnlyList proposedRooms, int roomsCount) { }

	[CompilerGenerated]
	public bool get_IsTemporaryListenerOverrideActive() { }

	public int get_ListenerCurrentOutdoorRoomID() { }

	public ISpatialAudioRoom get_ListenerCurrentRoom() { }

	public int get_ListenerCurrentRoomID() { }

	public ISpatialAudioRoom GetOtherPlayerCurrentRoom(int playerId) { }

	private void Initialize() { }

	private void InsertRoomBySize(List rooms, ISpatialAudioRoom room) { }

	private void InvokeMyPlayerRoomChangeEvent(EPlayerRoomInteractionState targetState) { }

	private void RemoveListenerCurrentRoom(SpatialAudioRoom room) { }

	public void RemovePlayerCurrentRoom(SpatialAudioRoom room, IPlayer player) { }

	private static ISpatialAudioRoom SelectSmallestByRoomSize(List rooms) { }

	[CompilerGenerated]
	private void set_IsTemporaryListenerOverrideActive(bool value) { }

	public void SetTemporaryListenerRoom(ISpatialAudioRoom room) { }

	public bool TryGetMatchingRoomPair(ISpatialAudioRoom emitterRoom, ISpatialAudioRoom listenerRoom, out RoomPair roomPair, out bool isReversed) { }

	private static bool TryIntersectRoomUsingColliderWorldBounds(ISpatialAudioRoom room, in Bounds sourceBounds) { }

	private bool ValidateProposedRooms(Vector3 sourcePos) { }

}

