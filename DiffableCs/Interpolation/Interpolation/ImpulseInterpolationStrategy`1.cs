namespace Interpolation;

public sealed class ImpulseInterpolationStrategy`1 : IInterpolationStrategy
{
	private readonly TValue _valueBetweenImpulses; //Field offset: 0x0

	public TValue ValueBetweenImpulses
	{
		 get { } //Length: 172
	}

	public ImpulseInterpolationStrategy`1(TValue valueBetweenImpulses) { }

	public TValue get_ValueBetweenImpulses() { }

	public TValue Interpolate(in TimeBound startTimeInfo, in TimeBound endTimeInfo, in TValue startValue, in TValue endValue, float relativeTime) { }

	private override TValue Interpolation.IInterpolationStrategy<TValue>.Interpolate(in TimeBound startTimeInfo, in TimeBound endTimeInfo, in TValue startValue, in TValue endValue, float relativeTime) { }

}

