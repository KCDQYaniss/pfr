//Type is in global namespace

public class AverageFloat : AbstractAverage
{

	public AverageFloat(int count) { }

	protected virtual float Difference(float minuend, float subtrahend) { }

	protected virtual float Division(float dividend, int divisor) { }

	protected virtual float Summation(float summandL, float summandR) { }

}

