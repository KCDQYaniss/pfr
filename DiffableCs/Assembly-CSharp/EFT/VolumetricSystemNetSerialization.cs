namespace EFT;

[Extension]
public static class VolumetricSystemNetSerialization
{
	public const int MAX_VOLUME_SOURCES_PER_SYNC = 32; //Field offset: 0x0
	public const int MAX_VOLUME_VOXEL_COUNT_PER_SYNC = 256; //Field offset: 0x0

	[Extension]
	public static void DeserializeVolumetricSystemDeltaPackets(IBitReaderStream reader, List packets) { }

	[Extension]
	public static void DeserializeVolumetricSystemRemovePackets(IBitReaderStream reader, List packets) { }

	[Extension]
	public static void DeserializeVolumetricSystemSpawnPackets(IBitReaderStream reader, List packets) { }

	[Extension]
	public static void SerializeVolumetricSystemDeltaPackets(IBitWriterStream writer, List packets) { }

	[Extension]
	public static void SerializeVolumetricSystemRemovePackets(IBitWriterStream writer, List packets) { }

	[Extension]
	public static void SerializeVolumetricSystemSpawnPackets(IBitWriterStream writer, List packets) { }

}

