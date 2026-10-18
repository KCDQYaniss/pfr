namespace Audio.SpatialSystem;

[Flags]
public enum EAudioRoomTypeMask
{
	None = 0,
	OutdoorGeneric = 1,
	OutdoorVehicle = 2,
	IndoorGeneric = 4,
	IndoorIsolated = 8,
	IndoorVehicle = 16,
	IndoorStairs = 32,
	OutdoorCommon = 64,
	IndoorBasement = 128,
	IndoorTransparent = 256,
	IndoorMetalThin = 512,
	IndoorWoodThick = 1024,
	IndoorBrick = 2048,
	IndoorConcrete = 4096,
	IndoorPlasterBoard = 8192,
	IndoorWoodThin = 16384,
	IndoorFabric = 32768,
	IndoorMetalThick = 65536,
	Outdoor = 67,
	Indoor = 131004,
	Isolated = 136,
}

