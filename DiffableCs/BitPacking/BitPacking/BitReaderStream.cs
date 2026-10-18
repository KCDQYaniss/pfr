namespace BitPacking;

public class BitReaderStream : IBitReaderStream, IBitStream
{
	private readonly IBitReader _reader; //Field offset: 0x10

	public override int BitsCount
	{
		 get { } //Length: 78
	}

	public override int BitsRead
	{
		 get { } //Length: 78
	}

	public override int BitsRemain
	{
		 get { } //Length: 154
	}

	public override byte[] Buffer
	{
		 get { } //Length: 75
	}

	public override int BytesRead
	{
		 get { } //Length: 78
	}

	public override bool IsOverflow
	{
		 get { } //Length: 78
	}

	public override EBitStreamMode StreamMode
	{
		 get { } //Length: 3
	}

	public BitReaderStream(byte[] buffer) { }

	public override int get_BitsCount() { }

	public override int get_BitsRead() { }

	public override int get_BitsRemain() { }

	public override byte[] get_Buffer() { }

	public override int get_BytesRead() { }

	public override bool get_IsOverflow() { }

	public override EBitStreamMode get_StreamMode() { }

	public override void ReadAlign() { }

	public override uint ReadBits(int bits) { }

	public override bool ReadBool() { }

	public override byte ReadByte() { }

	public override void ReadBytes(byte[] destinationBytes, int destinationStartIndex, int length) { }

	public override byte[] ReadBytesAlloc(Nullable maxSize) { }

	public override char ReadChar() { }

	public override bool ReadCheck(uint magic, string message = null) { }

	public override double ReadDouble() { }

	public override TEnum ReadEnum() { }

	public override float ReadFloat() { }

	public override short ReadInt16() { }

	public override int ReadInt32() { }

	public override long ReadInt64() { }

	public override float ReadLimitedFloat(float min, float max, float res) { }

	public override int ReadLimitedInt32(int min, int max) { }

	public override string ReadLimitedString(char min, char max, Nullable maxSize = null) { }

	public override Quaternion ReadQuaternion() { }

	public override string ReadString(Nullable maxSize) { }

	public override ushort ReadUInt16() { }

	public override uint ReadUInt32() { }

	public override uint ReadUInt32UsingBitRange(int[] rangeBits) { }

	public override ulong ReadUInt64() { }

	public override Vector2 ReadVector2() { }

	public override Vector3 ReadVector3() { }

	public override void Reset() { }

	public override void Serialize(ref long value) { }

	public override void Serialize(ref uint value) { }

	public override void Serialize(ref int value) { }

	public override void Serialize(ref ushort value) { }

	public override void Serialize(ref short value) { }

	public override void Serialize(ref byte value) { }

	public override void Serialize(ref char value) { }

	public override void Serialize(ref Vector2 value) { }

	public override void Serialize(ref string value, Nullable maxSize) { }

	public override void Serialize(ref Vector3 value) { }

	public override void Serialize(ref Quaternion value) { }

	public override void Serialize(ref bool value) { }

	public override void Serialize(ref ulong value) { }

	public override void Serialize(ref TEnum value) { }

	public override void Serialize(ref double value) { }

	public override void Serialize(ref float value) { }

	public override void SerializeAlign() { }

	public override void SerializeBits(ref uint value, int bits) { }

	public override void SerializeBytes(ref byte[] data, int startIndex, int length) { }

	public override void SerializeBytesAndSize(ref byte[] data, Nullable maxSize) { }

	public override bool SerializeCheck(uint checkNumber, string message = null) { }

	public override void SerializeLimitedFloat(ref float value, float min, float max, float res, BitPackingTag tag) { }

	public override void SerializeLimitedInt32(ref int value, int min, int max, BitPackingTag tag) { }

	public override void SerializeLimitedString(ref string value, char min, char max, BitPackingTag tag, Nullable maxSize = null) { }

	public override void SerializeUInt32UsingBitRange(ref uint value, int[] rangeBits, BitPackingTag tag) { }

}

