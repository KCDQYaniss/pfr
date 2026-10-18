namespace Audio.SpatialSystem;

public class SerializableAudioRoutesBakeData
{
	public RoomPairItem[] RoomPairsItems; //Field offset: 0x10
	public RoutesAwareRoomItem[] RoutesAwareRoomItems; //Field offset: 0x18
	public RoutesByRoomPairIDItem[] RoutesByRoomPairIDItems; //Field offset: 0x20
	public LocationBakeSettings BakeSettings; //Field offset: 0x28
	public uint RoomPairMaxRoutesCapacity; //Field offset: 0x30
	public uint RoomPairMaxPortalsCapacity; //Field offset: 0x34

	public SerializableAudioRoutesBakeData() { }

}

