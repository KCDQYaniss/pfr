namespace EFT.HealthSystem;

[Extension]
public static class SyncHealthPacketSerialization
{
	[CompilerGenerated]
	private static class <>O
	{
		public static SerializeDelegate <0>__SerializePacket; //Field offset: 0x0
		public static DeserializeDelegate <1>__DeserializeSyncHealthPacket; //Field offset: 0x8

	}

	private const float HEAL_RATE_MIN = 0; //Field offset: 0x0
	private const float HEAL_RATE_MAX = 3000; //Field offset: 0x0
	private const float DAMAGE_RATE_MIN = -1000; //Field offset: 0x0
	private const float DAMAGE_RATE_MAX = 0; //Field offset: 0x0

	[Extension]
	public static Nullable DeserializeSyncHealthPacket(IBitReaderStream reader) { }

	public static void SerializeCommon(IBitStream serializer, ref SyncHealthPacket packet) { }

	[Extension]
	public static void SerializePacket(IBitWriterStream writer, ref Nullable packet) { }

}

