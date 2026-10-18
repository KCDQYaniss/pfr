namespace Koenigz.PerfectCulling.IO;

public class BitStreamWriter
{
	private const uint SingleBitMask = 1; //Field offset: 0x0
	private byte[] _buf; //Field offset: 0x10
	private byte _currentByte; //Field offset: 0x18
	private int _currentBitPos; //Field offset: 0x1C
	private int _currentBufPos; //Field offset: 0x20

	public byte[] Buffer
	{
		 get { } //Length: 5
	}

	public int Length
	{
		 get { } //Length: 4
	}

	public BitStreamWriter() { }

	private void AppendCurrentByte() { }

	public void Flush() { }

	public byte[] get_Buffer() { }

	public int get_Length() { }

	public void Reset() { }

	public int Write(uint value, int bits) { }

	private void WriteBit(uint singleBit) { }

}

