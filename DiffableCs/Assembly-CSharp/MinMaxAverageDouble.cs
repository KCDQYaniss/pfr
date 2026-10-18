//Type is in global namespace

public class MinMaxAverageDouble : AbstractMinMaxAverage
{

	public MinMaxAverageDouble(int count) { }

	protected virtual double Difference(double minuend, double subtrahend) { }

	protected virtual double Division(double dividend, int divisor) { }

	public virtual bool IsGreaterOrEqual(double rhs, double lhs) { }

	public virtual bool IsLessOrEqual(double rhs, double lhs) { }

	protected virtual double Summation(double summandL, double summandR) { }

}

