namespace Interpolation;

public sealed class DiscreteInterpolationStrategy`1 : IInterpolationStrategy
{

	public DiscreteInterpolationStrategy`1() { }

	public TValue Interpolate(in TimeBound startTimeInfo, in TimeBound endTimeInfo, in TValue startValue, in TValue endValue, float relativeTime) { }

	private override TValue Interpolation.IInterpolationStrategy<TValue>.Interpolate(in TimeBound startTimeInfo, in TimeBound endTimeInfo, in TValue startValue, in TValue endValue, float relativeTime) { }

}

