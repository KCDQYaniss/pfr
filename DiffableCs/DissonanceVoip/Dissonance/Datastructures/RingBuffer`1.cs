namespace Dissonance.Datastructures;

internal class RingBuffer`1
{
	private readonly T[] _items; //Field offset: 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x0
	private int _end; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 26
	}

	public private int Count
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public RingBuffer`1(uint size) { }

	public Nullable Add(T item) { }

	public void Clear() { }

	public int get_Capacity() { }

	[CompilerGenerated]
	public int get_Count() { }

	[CompilerGenerated]
	private void set_Count(int value) { }

}

