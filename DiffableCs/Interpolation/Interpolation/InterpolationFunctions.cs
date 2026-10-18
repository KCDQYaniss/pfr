namespace Interpolation;

public static class InterpolationFunctions
{
	internal enum ERangeType
	{
		Start = 0,
		End = 1,
		Between = 2,
	}


	public static TValue DiscreteInterpolationFunction(in TimeBound startTimeInfo, in TimeBound endTimeInfo, in TValue startValue, in TValue endValue, float relativeTime) { }

	public static ERangeType GetDiscreteBounds(in TimeBound startTimeInfo, in TimeBound endTimeInfo, float relativeTime) { }

	public static ERangeType GetImpulseBounds(in TimeBound startTimeInfo, in TimeBound endTimeInfo, float relativeTime) { }

	public static TValue ImpulseInterpolationFunction(in TimeBound startTimeInfo, in TimeBound endTimeInfo, in TValue startValue, in TValue endValue, float relativeTime, TValue valueBetweenIndexes) { }

}

