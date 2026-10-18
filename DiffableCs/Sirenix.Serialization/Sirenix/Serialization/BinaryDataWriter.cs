namespace Sirenix.Serialization;

public class BinaryDataWriter : BaseDataWriter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__72_0(byte[] b, int i, char v) { }

		internal void <.cctor>b__72_1(byte[] b, int i, byte v) { }

		internal void <.cctor>b__72_2(byte[] b, int i, sbyte v) { }

		internal void <.cctor>b__72_3(byte[] b, int i, bool v) { }

	}

	private struct OneTwentyEightBitValueToByteUnion
	{
		public byte b0; //Field offset: 0x0
		public Guid guidValue; //Field offset: 0x0
		public decimal decimalValue; //Field offset: 0x0
		public byte b1; //Field offset: 0x1
		public byte b2; //Field offset: 0x2
		public byte b3; //Field offset: 0x3
		public byte b4; //Field offset: 0x4
		public byte b5; //Field offset: 0x5
		public byte b6; //Field offset: 0x6
		public byte b7; //Field offset: 0x7
		public byte b8; //Field offset: 0x8
		public byte b9; //Field offset: 0x9
		public byte b10; //Field offset: 0xA
		public byte b11; //Field offset: 0xB
		public byte b12; //Field offset: 0xC
		public byte b13; //Field offset: 0xD
		public byte b14; //Field offset: 0xE
		public byte b15; //Field offset: 0xF

	}

	private struct SixtyFourBitValueToByteUnion
	{
		public byte b0; //Field offset: 0x0
		public double doubleValue; //Field offset: 0x0
		public ulong ulongValue; //Field offset: 0x0
		public long longValue; //Field offset: 0x0
		public byte b1; //Field offset: 0x1
		public byte b2; //Field offset: 0x2
		public byte b3; //Field offset: 0x3
		public byte b4; //Field offset: 0x4
		public byte b5; //Field offset: 0x5
		public byte b6; //Field offset: 0x6
		public byte b7; //Field offset: 0x7

	}

	private struct Struct256Bit
	{
		public decimal d1; //Field offset: 0x0
		public decimal d2; //Field offset: 0x10

	}

	private static readonly Dictionary PrimitiveGetBytesMethods; //Field offset: 0x0
	private static readonly Dictionary PrimitiveSizes; //Field offset: 0x8
	private static readonly Dictionary PrimitiveArrayWriters; //Field offset: 0x10
	private readonly byte[] small_buffer; //Field offset: 0x30
	private readonly byte[] buffer; //Field offset: 0x38
	private int bufferIndex; //Field offset: 0x40
	private readonly Dictionary types; //Field offset: 0x48
	public bool CompressStringsTo8BitWhenPossible; //Field offset: 0x50

	private static BinaryDataWriter() { }

	public BinaryDataWriter() { }

	public BinaryDataWriter(Stream stream, SerializationContext context) { }

	public virtual void BeginArrayNode(long length) { }

	public virtual void BeginReferenceNode(string name, Type type, int id) { }

	public virtual void BeginStructNode(string name, Type type) { }

	public virtual void Dispose() { }

	public virtual void EndArrayNode() { }

	public virtual void EndNode(string name) { }

	private void EnsureBufferSpace(int space) { }

	public virtual void FlushToStream() { }

	public virtual string GetDataDump() { }

	public virtual void PrepareNewSerializationSession() { }

	private bool TryEnsureBufferSpace(int space) { }

	private void UNSAFE_WriteToBuffer_16_Decimal(decimal value) { }

	private void UNSAFE_WriteToBuffer_16_Guid(Guid value) { }

	private void UNSAFE_WriteToBuffer_2_Char(char value) { }

	private void UNSAFE_WriteToBuffer_2_Int16(short value) { }

	private void UNSAFE_WriteToBuffer_2_UInt16(ushort value) { }

	private void UNSAFE_WriteToBuffer_4_Float32(float value) { }

	private void UNSAFE_WriteToBuffer_4_Int32(int value) { }

	private void UNSAFE_WriteToBuffer_4_UInt32(uint value) { }

	private void UNSAFE_WriteToBuffer_8_Float64(double value) { }

	private void UNSAFE_WriteToBuffer_8_Int64(long value) { }

	private void UNSAFE_WriteToBuffer_8_UInt64(ulong value) { }

	public virtual void WriteBoolean(string name, bool value) { }

	public virtual void WriteByte(string name, byte value) { }

	public virtual void WriteChar(string name, char value) { }

	public virtual void WriteDecimal(string name, decimal value) { }

	public virtual void WriteDouble(string name, double value) { }

	public virtual void WriteExternalReference(string name, string id) { }

	public virtual void WriteExternalReference(string name, int index) { }

	public virtual void WriteExternalReference(string name, Guid guid) { }

	public virtual void WriteGuid(string name, Guid value) { }

	public virtual void WriteInt16(string name, short value) { }

	public virtual void WriteInt32(string name, int value) { }

	public virtual void WriteInt64(string name, long value) { }

	public virtual void WriteInternalReference(string name, int id) { }

	public virtual void WriteNull(string name) { }

	public virtual void WritePrimitiveArray(T[] array) { }

	private static void WritePrimitiveArray_bool(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_byte(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_char(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_decimal(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_double(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_float(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_Guid(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_int(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_long(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_sbyte(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_short(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_uint(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_ulong(BinaryDataWriter writer, object o) { }

	private static void WritePrimitiveArray_ushort(BinaryDataWriter writer, object o) { }

	public virtual void WriteSByte(string name, sbyte value) { }

	public virtual void WriteSingle(string name, float value) { }

	public virtual void WriteString(string name, string value) { }

	private void WriteStringFast(string value) { }

	private void WriteType(Type type) { }

	public virtual void WriteUInt16(string name, ushort value) { }

	public virtual void WriteUInt32(string name, uint value) { }

	public virtual void WriteUInt64(string name, ulong value) { }

}

