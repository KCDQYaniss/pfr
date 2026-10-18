namespace EFT.NetworkPackets.Serialization;

[Extension]
public static class KnifePacketSerializationExtensions
{
	private const int MAX_HITS_FOR_APPROVEMENT = 7; //Field offset: 0x0

	[Extension]
	public static void Serialize(IBitStream stream, ref KnifePacket current) { }

}

