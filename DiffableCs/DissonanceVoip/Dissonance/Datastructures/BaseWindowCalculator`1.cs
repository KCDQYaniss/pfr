namespace Dissonance.Datastructures;

internal abstract class BaseWindowCalculator`1
{
	private readonly RingBuffer _buffer; //Field offset: 0x0

	protected int Capacity
	{
		 get { } //Length: 35
	}

	protected int Count
	{
		 get { } //Length: 26
	}

	protected BaseWindowCalculator`1(uint size) { }

	public override void Clear() { }

	protected int get_Capacity() { }

	protected int get_Count() { }

	public void Update(T added) { }

	protected abstract void Updated(Nullable removed, T added) { }

}

