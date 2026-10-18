namespace EFT.NetworkPackets.Serialization;

[Extension]
public static class EmptyHandPacketSerializationExtensions
{

	[Extension]
	public static void Serialize(IBitStream stream, ref EmptyHandPacket current) { }

}

