namespace Dissonance.Datastructures;

internal struct Union32
{
	private uint _uint; //Field offset: 0x0
	private byte _byte1; //Field offset: 0x0
	private byte _byte2; //Field offset: 0x1
	private byte _byte3; //Field offset: 0x2
	private byte _byte4; //Field offset: 0x3

	public uint UInt32
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public uint get_UInt32() { }

	public void GetBytesInNetworkOrder(out byte b1, out byte b2, out byte b3, out byte b4) { }

	public void set_UInt32(uint value) { }

	public void SetBytesFromNetworkOrder(byte b1, byte b2, byte b3, byte b4) { }

}

