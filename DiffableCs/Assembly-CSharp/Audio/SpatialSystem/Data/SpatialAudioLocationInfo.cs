namespace Audio.SpatialSystem.Data;

public class SpatialAudioLocationInfo : ScriptableObject
{
	public string relativeBakeDataPath; //Field offset: 0x18
	public LocationBakeSettings bakeSettings; //Field offset: 0x20
	public uint roomsCount; //Field offset: 0x28
	public uint portalsCount; //Field offset: 0x2C
	public uint routesCount; //Field offset: 0x30
	public uint roomPairsCount; //Field offset: 0x34
	public uint maxRoutesCount; //Field offset: 0x38
	public uint maxRoutePortalsCount; //Field offset: 0x3C

	public SpatialAudioLocationInfo() { }

}

