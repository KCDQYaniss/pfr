//Type is in global namespace

public abstract class AbstractMinMaxAverage`1 : AbstractAverage
{
	private int _maxId; //Field offset: 0x0
	private int _minId; //Field offset: 0x0

	public TValue Max
	{
		 get { } //Length: 44
	}

	public TValue Min
	{
		 get { } //Length: 44
	}

	protected AbstractMinMaxAverage`1(int count) { }

	public virtual void AddValue(TValue val) { }

	public TValue get_Max() { }

	public TValue get_Min() { }

	public abstract bool IsGreaterOrEqual(TValue rhs, TValue lhs) { }

	public abstract bool IsLessOrEqual(TValue rhs, TValue lhs) { }

}

