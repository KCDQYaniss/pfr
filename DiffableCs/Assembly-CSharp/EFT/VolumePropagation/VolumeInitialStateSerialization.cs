namespace EFT.VolumePropagation;

public static class VolumeInitialStateSerialization
{
	public const int MAX_SOURCES = 32; //Field offset: 0x0
	public const int MAX_VOXELS_PER_SOURCE = 65535; //Field offset: 0x0

	public static VolumeInitialStateMessage Deserialize(NetworkReader reader) { }

	public static void Serialize(NetworkWriter writer, in VolumeInitialStateMessage msg) { }

}

