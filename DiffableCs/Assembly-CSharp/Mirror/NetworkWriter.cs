namespace Mirror;

public class NetworkWriter
{
	public const int MaxStringLength = 32768; //Field offset: 0x0
	public const int DefaultCapacity = 1500; //Field offset: 0x0
	internal byte[] buffer; //Field offset: 0x10
	public int Position; //Field offset: 0x18
	internal readonly UTF8Encoding encoding; //Field offset: 0x20

	public int Capacity
	{
		 get { } //Length: 26
	}

	public NetworkWriter() { }

	internal void EnsureCapacity(int value) { }

	public int get_Capacity() { }

	public static ArraySegment op_Implicit(NetworkWriter w) { }

	public void Reset() { }

	public byte[] ToArray() { }

	public ArraySegment ToArraySegment() { }

	public virtual string ToString() { }

	public void Write(T value) { }

	internal void WriteBlittable(T value) { }

	internal void WriteBlittableNullable(Nullable value) { }

	public void WriteByte(byte value) { }

	public void WriteBytes(byte[] array, int offset, int count) { }

	public bool WriteBytes(byte* ptr, int offset, int size) { }

}

