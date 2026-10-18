namespace Interpolation;

public interface IInterpolationStrategy`1
{

	public TValue Interpolate(in TimeBound startTimeInfo, in TimeBound endTimeInfo, in TValue startValue, in TValue endValue, float relativeTime) { }

}

