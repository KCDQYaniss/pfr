namespace Audio.SpatialSystem;

public class OutdoorPortalsDataContainer : IDataContainer
{
	[IsReadOnly]
	internal struct NeighborRoomInfo
	{
		public readonly short roomID; //Field offset: 0x0
		public readonly BaseSpatialAudioPortal[] connectingPortals; //Field offset: 0x8

		public NeighborRoomInfo(short roomID, BaseSpatialAudioPortal[] connectingPortals) { }

	}

	private readonly Dictionary _outPortalsByOutRoomID; //Field offset: 0x10
	private readonly Dictionary _outPortalsDictByOutRoomID; //Field offset: 0x18
	private readonly Dictionary _outPortalDataByOutRoomID; //Field offset: 0x20
	private readonly Dictionary _indoorRoomsIdsByOutRoomID; //Field offset: 0x28
	private readonly HashSet _containedIndoorRooms; //Field offset: 0x30
	private readonly Dictionary _portalIndexesByID; //Field offset: 0x38
	private readonly Dictionary _neighborRoomInfoByRoomID; //Field offset: 0x40

	public OutdoorPortalsDataContainer() { }

	private PortalData CreatePortalData(BaseSpatialAudioPortal portal, short startIndex, short indoorRoomsCount) { }

	public void FillData(List audioRooms) { }

	public bool FillOpenNeighborRoomIDs(short roomID, List output) { }

	private void FillOutdoorPortalsData() { }

	private void FillPortalsDataByRelativeOutdoor(SpatialAudioRoom room) { }

	private void FindPortalRelatedIndoorRooms(BaseSpatialAudioPortal portal, short startIndex, int outRoomID, out short indoorRoomsCount) { }

	public void FullUpdatePortalsData(int outRoomID) { }

	private void PrecomputeRoomNeighbors(List audioRooms) { }

	private void ProcessConnection(int rootRoomID, RoomConnection connection, ref int portalIndex) { }

	private short[] ResizeIndoorRoomsArray(int outRoomID, int newSize) { }

	private bool TryAddPortal(int roomID, BaseSpatialAudioPortal portal, int portalIndex) { }

	public bool TryGetIndoorRoomsIdsByOutRoomID(int roomID, out short[] ids) { }

	public bool TryGetOutdoorPortalData(int roomID, out PortalData[] data) { }

	public bool TryGetPortalsByRelativeOutdoorRoomID(int roomID, out List portals) { }

	public bool TryUpdateConcretePortalData(int portalID) { }

}

