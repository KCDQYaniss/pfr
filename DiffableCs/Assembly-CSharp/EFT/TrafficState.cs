namespace EFT;

public struct TrafficState
{
	public uint Packets; //Field offset: 0x0
	public uint Bytes; //Field offset: 0x4
	public uint BytesPerSecond; //Field offset: 0x8

	public virtual string ToString() { }

}

