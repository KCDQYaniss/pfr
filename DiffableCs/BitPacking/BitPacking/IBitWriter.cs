namespace BitPacking;

public interface IBitWriter
{

	public int BitsCount
	{
		 get { } //Length: 0
	}

	public int BitsWritten
	{
		 get { } //Length: 0
	}

	public byte[] Buffer
	{
		 get { } //Length: 0
	}

	public int BytesWritten
	{
		 get { } //Length: 0
	}

	public bool IsOverflow
	{
		 get { } //Length: 0
	}

	public int TotalBytes
	{
		 get { } //Length: 0
	}

	public void FlushBits() { }

	public int get_BitsCount() { }

	public int get_BitsWritten() { }

	public byte[] get_Buffer() { }

	public int get_BytesWritten() { }

	public bool get_IsOverflow() { }

	public int get_TotalBytes() { }

	public void Reset() { }

	public void WriteBits(uint value, int bits) { }

	public void WriteByteAlign() { }

	public void WriteBytes(byte[] bytes, int startIndex, int length) { }

	public void WriteBytes(byte[] bytes) { }

}

