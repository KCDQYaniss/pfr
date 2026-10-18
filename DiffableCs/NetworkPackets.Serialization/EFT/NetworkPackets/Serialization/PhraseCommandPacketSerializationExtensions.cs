namespace EFT.NetworkPackets.Serialization;

[Extension]
public static class PhraseCommandPacketSerializationExtensions
{
	private const int MAX_PHRASE_ID = 255; //Field offset: 0x0

	[Extension]
	public static void Serialize(IBitStream stream, ref PhraseCommandPacket current) { }

}

