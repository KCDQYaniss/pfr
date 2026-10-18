namespace Sirenix.Serialization;

public sealed class Buffer`1 : IDisposable
{
	private static readonly object LOCK; //Field offset: 0x0
	private static readonly List FreeBuffers; //Field offset: 0x0
	private int count; //Field offset: 0x0
	private T[] array; //Field offset: 0x0
	private bool isFree; //Field offset: 0x0

	public T[] Array
	{
		 get { } //Length: 102
	}

	public int Count
	{
		 get { } //Length: 101
	}

	public bool IsFree
	{
		 get { } //Length: 10
	}

	private static Buffer`1() { }

	private Buffer`1(int count) { }

	public static Buffer Claim(int minimumCapacity) { }

	public override void Dispose() { }

	public static void Free(Buffer buffer) { }

	public void Free() { }

	public T[] get_Array() { }

	public int get_Count() { }

	public bool get_IsFree() { }

	private static int NextPowerOfTwo(int v) { }

}

