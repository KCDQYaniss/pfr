namespace Dissonance.Audio.Codecs;

public struct EncodedBuffer
{
	public readonly Nullable Encoded; //Field offset: 0x0
	public readonly bool PacketLost; //Field offset: 0x18

	public EncodedBuffer(Nullable encoded, bool packetLost) { }

}

