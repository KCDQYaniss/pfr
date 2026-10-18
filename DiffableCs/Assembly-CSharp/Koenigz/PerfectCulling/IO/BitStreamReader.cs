namespace Koenigz.PerfectCulling.IO;

public class BitStreamReader
{
	private const int NumberOfBitsInByte = 8; //Field offset: 0x0
	private byte[] m_buffer; //Field offset: 0x10
	private int m_currentBits; //Field offset: 0x18
	private int m_bufPos; //Field offset: 0x1C

	public int Position
	{
		 get { } //Length: 4
	}

	public BitStreamReader() { }

	public int get_Position() { }

	public uint Read(int bits) { }

	private uint ReadBit() { }

	public void Reset(byte[] buffer) { }

	public void SetOffset(int offset) { }

}

