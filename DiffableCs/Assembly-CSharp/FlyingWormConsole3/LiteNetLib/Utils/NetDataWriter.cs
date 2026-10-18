namespace FlyingWormConsole3.LiteNetLib.Utils;

public class NetDataWriter
{
	private const int InitialSize = 64; //Field offset: 0x0
	protected byte[] _data; //Field offset: 0x10
	protected int _position; //Field offset: 0x18
	private readonly bool _autoResize; //Field offset: 0x1C

	public int Capacity
	{
		 get { } //Length: 26
	}

	public byte[] Data
	{
		 get { } //Length: 5
	}

	public int Length
	{
		 get { } //Length: 4
	}

	public NetDataWriter() { }

	public NetDataWriter(bool autoResize) { }

	public NetDataWriter(bool autoResize, int initialSize) { }

	public byte[] CopyData() { }

	public static NetDataWriter FromBytes(byte[] bytes, bool copy) { }

	public static NetDataWriter FromBytes(byte[] bytes, int offset, int length) { }

	public static NetDataWriter FromString(string value) { }

	public int get_Capacity() { }

	public byte[] get_Data() { }

	public int get_Length() { }

	public void Put(short value) { }

	public void Put(string value, int maxLength) { }

	public void Put(byte value) { }

	public void Put(byte[] data, int offset, int length) { }

	public void Put(bool value) { }

	public void Put(ushort value) { }

	public void Put(IPEndPoint endPoint) { }

	public void Put(string value) { }

	public void Put(byte[] data) { }

	public void Put(char value) { }

	public void Put(sbyte value) { }

	public void Put(int value) { }

	public void Put(uint value) { }

	public void Put(float value) { }

	public void Put(T obj) { }

	public void Put(long value) { }

	public void Put(double value) { }

	public void Put(ulong value) { }

	public void PutArray(string[] value, int maxLength) { }

	public void PutArray(string[] value) { }

	public void PutArray(bool[] value) { }

	public void PutArray(short[] value) { }

	public void PutArray(ushort[] value) { }

	public void PutArray(uint[] value) { }

	public void PutArray(int[] value) { }

	public void PutArray(ulong[] value) { }

	public void PutArray(float[] value) { }

	private void PutArray(Array arr, int sz) { }

	public void PutArray(long[] value) { }

	public void PutArray(double[] value) { }

	public void PutBytesWithLength(byte[] data) { }

	public void PutBytesWithLength(byte[] data, int offset, int length) { }

	public void PutSBytesWithLength(sbyte[] data) { }

	public void PutSBytesWithLength(sbyte[] data, int offset, int length) { }

	public void Reset() { }

	public void Reset(int size) { }

	public void ResizeIfNeed(int newSize) { }

	public int SetPosition(int position) { }

}

