namespace EFT;

[Extension]
public static class GameWorldPacketExtension
{
	[CompilerGenerated]
	private static class <>O
	{
		public static SerializeDelegate <0>__SerializePacket; //Field offset: 0x0
		public static DeserializeDelegate <1>__DeserializeUpdateExfiltrationPointPacket; //Field offset: 0x8
		public static SerializeDelegate <2>__SerializePacket; //Field offset: 0x10
		public static DeserializeDelegate <3>__DeserializeLampChangeStatePacket; //Field offset: 0x18
		public static SerializeDelegate <4>__SerializePacket; //Field offset: 0x20
		public static DeserializeDelegate <5>__DeserializeWindowHitPacket; //Field offset: 0x28

	}

	public const int LOW_PRIORITY_LIMIT = 5; //Field offset: 0x0
	private const int MAX_GRENADE_COUNT_FOR_SYNC = 32; //Field offset: 0x0
	private const int MAX_ARTILLERY_COUNT_FOR_SYNC = 32; //Field offset: 0x0
	private const int MAX_LOOT_COUNT_FOR_SYNC = 64; //Field offset: 0x0
	private const int _maxCorpseCountForSync = 32; //Field offset: 0x0

	[Extension]
	public static void DeserializeArtillerySyncPackets(IBitReaderStream reader, List packets) { }

	[Extension]
	private static void DeserializeCorpseSyncPackets(IBitReaderStream reader, List packets) { }

	[Extension]
	public static GameWorldPacket DeserializeGameWorldPacket(IBitReaderStream reader) { }

	[Extension]
	private static void DeserializeGrenadeSyncPackets(IBitReaderStream reader, List packets) { }

	[Extension]
	private static Nullable DeserializeInteractiveObjectsStatusPacket(IBitReaderStream reader) { }

	[Extension]
	private static Nullable DeserializeLampChangeStatePacket(IBitReaderStream reader) { }

	[Extension]
	private static void DeserializeLootSyncPackets(IBitReaderStream reader, List packets) { }

	[Extension]
	private static void DeserializePackets(IBitReaderStream reader, List packets) { }

	[Extension]
	private static void DeserializePackets(IBitReaderStream reader, List packets) { }

	[Extension]
	private static Nullable DeserializeUpdateExfiltrationPointPacket(IBitReaderStream reader) { }

	[Extension]
	private static Nullable DeserializeWindowHitPacket(IBitReaderStream reader) { }

	private static bool FindArtillerySyncPacket(List packets, int id, out ArtilleryProjectileSyncPacket found) { }

	[Extension]
	private static bool IsCritical(IReadOnlyList list) { }

	[Extension]
	private static bool IsCritical(IReadOnlyList list) { }

	[Extension]
	private static bool IsCritical(IReadOnlyList list) { }

	[Extension]
	private static void Serialize(IBitStream stream, List packets) { }

	[Extension]
	private static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	private static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	private static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	private static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref GameWorldPacket packet, GameWorld gameWorld) { }

	[Extension]
	private static void SerializePackets(IBitWriterStream writer, List packets) { }

	[Extension]
	private static void SerializePackets(IBitWriterStream writer, List packets) { }

	[Extension]
	public static void SerializePackets(IBitWriterStream writer, List packets) { }

	[Extension]
	private static void SerializePackets(IBitWriterStream writer, List packets, NetworkAdapter[] platformAdapters) { }

	[Extension]
	private static void SerializePackets(IBitWriterStream writer, List packets, BorderZone[] borderZones) { }

	[Extension]
	private static void SerializePackets(IBitWriterStream writer, List packets) { }

	public static void UpdatePriority(ref GameWorldPacket packet, GameWorldPacket previousPacket) { }

}

