namespace BitPacking;

public class BitWriterStream : IBitWriterStream, IBitStream
{
	private readonly IBitWriter _writer; //Field offset: 0x10

	public override int BitsCount
	{
		 get { } //Length: 78
	}

	public override int BitsRemain
	{
		 get { } //Length: 154
	}

	public override int BitsWritten
	{
		 get { } //Length: 78
	}

	public override byte[] Buffer
	{
		 get { } //Length: 75
	}

	public override int BytesWritten
	{
		 get { } //Length: 78
	}

	public override bool IsOverflow
	{
		 get { } //Length: 78
	}

	public override EBitStreamMode StreamMode
	{
		 get { } //Length: 6
	}

	public BitWriterStream(byte[] buffer) { }

	public override void Flush() { }

	public override int get_BitsCount() { }

	public override int get_BitsRemain() { }

	public override int get_BitsWritten() { }

	public override byte[] get_Buffer() { }

	public override int get_BytesWritten() { }

	public override bool get_IsOverflow() { }

	public override EBitStreamMode get_StreamMode() { }

	public override void Reset() { }

	public override void Serialize(ref char value) { }

	public override void Serialize(ref byte value) { }

	public override void Serialize(ref short value) { }

	public override void Serialize(ref ushort value) { }

	public override void Serialize(ref int value) { }

	public override void Serialize(ref uint value) { }

	public override void Serialize(ref long value) { }

	public override void Serialize(ref string value, Nullable maxSize) { }

	public override void Serialize(ref float value) { }

	public override void Serialize(ref double value) { }

	public override void Serialize(ref Vector2 value) { }

	public override void Serialize(ref Quaternion value) { }

	public override void Serialize(ref bool value) { }

	public override void Serialize(ref TEnum value) { }

	public override void Serialize(ref ulong value) { }

	public override void Serialize(ref Vector3 value) { }

	public override void SerializeAlign() { }

	public override void SerializeBits(ref uint value, int bits) { }

	public override void SerializeBytes(ref byte[] data, int startIndex, int length) { }

	public override void SerializeBytesAndSize(ref byte[] data, Nullable maxSize) { }

	public override bool SerializeCheck(uint checkNumber, string message = null) { }

	public override void SerializeLimitedFloat(ref float value, float min, float max, float res, BitPackingTag tag) { }

	public override void SerializeLimitedInt32(ref int value, int min, int max, BitPackingTag tag) { }

	public override void SerializeLimitedString(ref string value, char min, char max, BitPackingTag tag, Nullable maxSize = null) { }

	public override void SerializeUInt32UsingBitRange(ref uint value, int[] rangeBits, BitPackingTag tag) { }

	public override void Write(Vector2 value) { }

	public override void Write(long value) { }

	public override void Write(int value) { }

	public override void Write(ushort value) { }

	public override void Write(short value) { }

	public override void Write(byte value) { }

	public override void Write(char value) { }

	public override void Write(uint value) { }

	public override void Write(ulong value) { }

	public override void Write(float value) { }

	public override void Write(double value) { }

	public override void Write(string value) { }

	public override void Write(TEnum value) { }

	public override void Write(bool value) { }

	public override void Write(Quaternion value) { }

	public override void Write(Vector3 value) { }

	public override void Write(IBitWriterStream value) { }

	public override void WriteAlign() { }

	public override void WriteBits(uint value, int bits) { }

	public override void WriteBytes(byte[] data, int startIndex, int length) { }

	public override void WriteBytesAndSize(byte[] data) { }

	public override void WriteCheck(uint checkNumber) { }

	public override void WriteLimitedFloat(float value, float min, float max, float res, BitPackingTag tag) { }

	public override void WriteLimitedInt32(int value, int min, int max, BitPackingTag tag) { }

	public override void WriteLimitedString(string value, char min, char max, BitPackingTag tag, Nullable maxSize) { }

	public override void WriteUInt32UsingBitRange(uint value, int[] rangeBits, BitPackingTag tag) { }

}

