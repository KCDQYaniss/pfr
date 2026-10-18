namespace Interpolation;

public sealed class LinearInterpolationStrategy`1 : IInterpolationStrategy
{
	internal sealed class LinearInterpolationDelegate : MulticastDelegate
	{

		public LinearInterpolationDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(in TValue startValue, in TValue endValue, float relativeTime, AsyncCallback callback, object object) { }

		public override TValue EndInvoke(in TValue startValue, in TValue endValue, IAsyncResult result) { }

		public override TValue Invoke(in TValue startValue, in TValue endValue, float relativeTime) { }

	}

	private readonly LinearInterpolationDelegate _linearInterpolationFunction; //Field offset: 0x0

	public LinearInterpolationStrategy`1(LinearInterpolationDelegate linearInterpolationFunction) { }

	public TValue Interpolate(in TimeBound startTimeInfo, in TimeBound endTimeInfo, in TValue startValue, in TValue endValue, float relativeTime) { }

	private override TValue Interpolation.IInterpolationStrategy<TValue>.Interpolate(in TimeBound startTimeInfo, in TimeBound endTimeInfo, in TValue startValue, in TValue endValue, float relativeTime) { }

}

