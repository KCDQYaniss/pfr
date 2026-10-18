namespace FlyingWormConsole3.LiteNetLib.Utils;

public class NetDataReader
{
	protected byte[] _data; //Field offset: 0x10
	protected int _position; //Field offset: 0x18
	protected int _dataSize; //Field offset: 0x1C
	private int _offset; //Field offset: 0x20

	public int AvailableBytes
	{
		 get { } //Length: 7
	}

	public bool EndOfData
	{
		 get { } //Length: 10
	}

	public bool IsNull
	{
		 get { } //Length: 9
	}

	public int Position
	{
		 get { } //Length: 4
	}

	public byte[] RawData
	{
		 get { } //Length: 5
	}

	public int RawDataSize
	{
		 get { } //Length: 4
	}

	public int UserDataOffset
	{
		 get { } //Length: 4
	}

	public int UserDataSize
	{
		 get { } //Length: 7
	}

	public NetDataReader(byte[] source, int offset, int maxSize) { }

	public NetDataReader(byte[] source, int offset) { }

	public NetDataReader(byte[] source) { }

	public NetDataReader(NetDataWriter writer) { }

	public NetDataReader() { }

	public void Clear() { }

	public T Get() { }

	public int get_AvailableBytes() { }

	public bool get_EndOfData() { }

	public bool get_IsNull() { }

	public int get_Position() { }

	public byte[] get_RawData() { }

	public int get_RawDataSize() { }

	public int get_UserDataOffset() { }

	public int get_UserDataSize() { }

	public bool GetBool() { }

	public bool[] GetBoolArray() { }

	public byte GetByte() { }

	public void GetBytes(byte[] destination, int count) { }

	public void GetBytes(byte[] destination, int start, int count) { }

	public byte[] GetBytesWithLength() { }

	public char GetChar() { }

	public double GetDouble() { }

	public double[] GetDoubleArray() { }

	public float GetFloat() { }

	public float[] GetFloatArray() { }

	public int GetInt() { }

	public int[] GetIntArray() { }

	public long GetLong() { }

	public long[] GetLongArray() { }

	public IPEndPoint GetNetEndPoint() { }

	public byte[] GetRemainingBytes() { }

	public ArraySegment GetRemainingBytesSegment() { }

	public sbyte GetSByte() { }

	public sbyte[] GetSBytesWithLength() { }

	public short GetShort() { }

	public short[] GetShortArray() { }

	public string GetString() { }

	public string GetString(int maxLength) { }

	public string[] GetStringArray(int maxStringLength) { }

	public string[] GetStringArray() { }

	public uint GetUInt() { }

	public uint[] GetUIntArray() { }

	public ulong GetULong() { }

	public ulong[] GetULongArray() { }

	public ushort GetUShort() { }

	public ushort[] GetUShortArray() { }

	public bool PeekBool() { }

	public byte PeekByte() { }

	public char PeekChar() { }

	public double PeekDouble() { }

	public float PeekFloat() { }

	public int PeekInt() { }

	public long PeekLong() { }

	public sbyte PeekSByte() { }

	public short PeekShort() { }

	public string PeekString() { }

	public string PeekString(int maxLength) { }

	public uint PeekUInt() { }

	public ulong PeekULong() { }

	public ushort PeekUShort() { }

	public void SetSource(byte[] source) { }

	public void SetSource(byte[] source, int offset, int maxSize) { }

	public void SetSource(byte[] source, int offset) { }

	public void SetSource(NetDataWriter dataWriter) { }

	public void SkipBytes(int count) { }

	public bool TryGetBool(out bool result) { }

	public bool TryGetByte(out byte result) { }

	public bool TryGetBytesWithLength(out byte[] result) { }

	public bool TryGetChar(out char result) { }

	public bool TryGetDouble(out double result) { }

	public bool TryGetFloat(out float result) { }

	public bool TryGetInt(out int result) { }

	public bool TryGetLong(out long result) { }

	public bool TryGetSByte(out sbyte result) { }

	public bool TryGetShort(out short result) { }

	public bool TryGetString(out string result) { }

	public bool TryGetStringArray(out string[] result) { }

	public bool TryGetUInt(out uint result) { }

	public bool TryGetULong(out ulong result) { }

	public bool TryGetUShort(out ushort result) { }

}

