//Type is in global namespace

public class MinMaxAverageFloat : AbstractMinMaxAverage
{

	public MinMaxAverageFloat(int count) { }

	protected virtual float Difference(float minuend, float subtrahend) { }

	protected virtual float Division(float dividend, int divisor) { }

	public virtual bool IsGreaterOrEqual(float rhs, float lhs) { }

	public virtual bool IsLessOrEqual(float rhs, float lhs) { }

	protected virtual float Summation(float summandL, float summandR) { }

}

