namespace BitPacking;

public interface IBitStream
{

	public int BitsCount
	{
		 get { } //Length: 0
	}

	public int BitsRemain
	{
		 get { } //Length: 0
	}

	public byte[] Buffer
	{
		 get { } //Length: 0
	}

	public bool IsOverflow
	{
		 get { } //Length: 0
	}

	public EBitStreamMode StreamMode
	{
		 get { } //Length: 0
	}

	public int get_BitsCount() { }

	public int get_BitsRemain() { }

	public byte[] get_Buffer() { }

	public bool get_IsOverflow() { }

	public EBitStreamMode get_StreamMode() { }

	public void Reset() { }

	public void Serialize(ref long value) { }

	public void Serialize(ref TEnum value) { }

	public void Serialize(ref bool value) { }

	public void Serialize(ref Quaternion value) { }

	public void Serialize(ref Vector2 value) { }

	public void Serialize(ref Vector3 value) { }

	public void Serialize(ref string value, Nullable maxSize = null) { }

	public void Serialize(ref double value) { }

	public void Serialize(ref float value) { }

	public void Serialize(ref ulong value) { }

	public void Serialize(ref uint value) { }

	public void Serialize(ref ushort value) { }

	public void Serialize(ref short value) { }

	public void Serialize(ref byte value) { }

	public void Serialize(ref char value) { }

	public void Serialize(ref int value) { }

	public void SerializeAlign() { }

	public void SerializeBits(ref uint value, int bits) { }

	public void SerializeBytes(ref byte[] data, int startIndex, int length) { }

	public void SerializeBytesAndSize(ref byte[] data, Nullable maxSize = null) { }

	public bool SerializeCheck(uint checkNumber, string message = null) { }

	public void SerializeLimitedFloat(ref float value, float min, float max, float res, BitPackingTag tag) { }

	public void SerializeLimitedInt32(ref int value, int min, int max, BitPackingTag tag) { }

	public void SerializeLimitedString(ref string value, char min, char max, BitPackingTag tag, Nullable maxSize = null) { }

	public void SerializeUInt32UsingBitRange(ref uint value, int[] rangeBits, BitPackingTag tag) { }

}

