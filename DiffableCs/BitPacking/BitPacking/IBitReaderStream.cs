namespace BitPacking;

public interface IBitReaderStream : IBitStream
{

	public int BitsRead
	{
		 get { } //Length: 0
	}

	public int BytesRead
	{
		 get { } //Length: 0
	}

	public int get_BitsRead() { }

	public int get_BytesRead() { }

	public void ReadAlign() { }

	public uint ReadBits(int bits) { }

	public bool ReadBool() { }

	public byte ReadByte() { }

	public void ReadBytes(byte[] destinationBytes, int destinationStartIndex, int length) { }

	public byte[] ReadBytesAlloc(Nullable maxSize = null) { }

	public char ReadChar() { }

	public bool ReadCheck(uint magic, string message = null) { }

	public double ReadDouble() { }

	public TEnum ReadEnum() { }

	public float ReadFloat() { }

	public short ReadInt16() { }

	public int ReadInt32() { }

	public long ReadInt64() { }

	public float ReadLimitedFloat(float min, float max, float res) { }

	public int ReadLimitedInt32(int min, int max) { }

	public string ReadLimitedString(char min, char max, Nullable maxSize = null) { }

	public Quaternion ReadQuaternion() { }

	public string ReadString(Nullable maxSize = null) { }

	public ushort ReadUInt16() { }

	public uint ReadUInt32() { }

	public uint ReadUInt32UsingBitRange(int[] rangeBits) { }

	public ulong ReadUInt64() { }

	public Vector2 ReadVector2() { }

	public Vector3 ReadVector3() { }

}

