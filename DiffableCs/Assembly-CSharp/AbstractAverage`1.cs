//Type is in global namespace

public abstract class AbstractAverage`1
{
	protected readonly TValue[] _values; //Field offset: 0x0
	protected readonly int _valuesCount; //Field offset: 0x0
	private TValue _sum; //Field offset: 0x0
	private TValue _average; //Field offset: 0x0
	protected int _head; //Field offset: 0x0
	protected bool _wasOverflow; //Field offset: 0x0

	public TValue Average
	{
		 get { } //Length: 6
	}

	protected AbstractAverage`1(int count) { }

	public override void AddValue(TValue val) { }

	protected abstract TValue Difference(TValue minuend, TValue subtrahend) { }

	protected abstract TValue Division(TValue dividend, int divisor) { }

	public TValue get_Average() { }

	protected abstract TValue Summation(TValue summandL, TValue summandR) { }

}

