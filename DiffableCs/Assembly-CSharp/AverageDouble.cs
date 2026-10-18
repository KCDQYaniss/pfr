//Type is in global namespace

public class AverageDouble : AbstractAverage
{

	public AverageDouble(int count) { }

	protected virtual double Difference(double minuend, double subtrahend) { }

	protected virtual double Division(double dividend, int divisor) { }

	protected virtual double Summation(double summandL, double summandR) { }

}

