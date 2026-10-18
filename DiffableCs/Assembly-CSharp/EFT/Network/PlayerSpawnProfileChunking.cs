namespace EFT.Network;

public static class PlayerSpawnProfileChunking
{
	public const int MAX_CHUNK_PAYLOAD_SIZE = 59312; //Field offset: 0x0
	private const int SPAWN_MESSAGE_RESERVE_SIZE = 8192; //Field offset: 0x0
	public const int MAX_INLINE_COMPRESSED_PROFILE_SIZE = 57327; //Field offset: 0x0

	public static bool ShouldSendAsChunks(int compressedProfileSize) { }

}

