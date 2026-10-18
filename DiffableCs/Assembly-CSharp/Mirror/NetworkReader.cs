namespace Mirror;

public class NetworkReader
{
	internal ArraySegment buffer; //Field offset: 0x10
	public int Position; //Field offset: 0x20
	internal readonly UTF8Encoding encoding; //Field offset: 0x28

	public int Capacity
	{
		 get { } //Length: 89
	}

	public int Remaining
	{
		 get { } //Length: 92
	}

	public NetworkReader(ArraySegment segment) { }

	public int get_Capacity() { }

	public int get_Remaining() { }

	public T Read() { }

	internal T ReadBlittable() { }

	internal Nullable ReadBlittableNullable() { }

	public byte ReadByte() { }

	public byte[] ReadBytes(byte[] bytes, int count) { }

	public ArraySegment ReadBytesSegment(int count) { }

	public void SetBuffer(ArraySegment segment) { }

	public virtual string ToString() { }

}

