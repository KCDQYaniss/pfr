namespace BitPacking;

public interface IBitWriterStream : IBitStream
{

	public int BitsWritten
	{
		 get { } //Length: 0
	}

	public int BytesWritten
	{
		 get { } //Length: 0
	}

	public void Flush() { }

	public int get_BitsWritten() { }

	public int get_BytesWritten() { }

	public void Write(long value) { }

	public void Write(IBitWriterStream value) { }

	public void Write(TEnum value) { }

	public void Write(bool value) { }

	public void Write(Quaternion value) { }

	public void Write(Vector2 value) { }

	public void Write(Vector3 value) { }

	public void Write(string value) { }

	public void Write(double value) { }

	public void Write(float value) { }

	public void Write(ulong value) { }

	public void Write(uint value) { }

	public void Write(int value) { }

	public void Write(ushort value) { }

	public void Write(short value) { }

	public void Write(byte value) { }

	public void Write(char value) { }

	public void WriteAlign() { }

	public void WriteBits(uint value, int bits) { }

	public void WriteBytes(byte[] data, int startIndex, int length) { }

	public void WriteBytesAndSize(byte[] data) { }

	public void WriteCheck(uint checkNumber) { }

	public void WriteLimitedFloat(float value, float min, float max, float res, BitPackingTag tag) { }

	public void WriteLimitedInt32(int value, int min, int max, BitPackingTag tag) { }

	public void WriteLimitedString(string value, char min, char max, BitPackingTag tag, Nullable maxSize) { }

	public void WriteUInt32UsingBitRange(uint value, int[] rangeBits, BitPackingTag tag) { }

}

