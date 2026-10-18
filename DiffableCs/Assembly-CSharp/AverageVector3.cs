//Type is in global namespace

public class AverageVector3 : AbstractAverage
{

	public AverageVector3(int count) { }

	protected virtual Vector3 Difference(Vector3 minuend, Vector3 subtrahend) { }

	protected virtual Vector3 Division(Vector3 dividend, int divisor) { }

	protected virtual Vector3 Summation(Vector3 summandL, Vector3 summandR) { }

}

