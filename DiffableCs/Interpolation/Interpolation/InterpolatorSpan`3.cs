namespace Interpolation;

[IsReadOnly]
public struct InterpolatorSpan`3
{
	public static readonly InterpolatorSpan NOT_INITIALIZED_SPAN; //Field offset: 0x0
	public readonly SpanBound Start; //Field offset: 0x0
	public readonly SpanBound End; //Field offset: 0x0
	private readonly AbstractInterpolator _interpolator; //Field offset: 0x0

	private static InterpolatorSpan`3() { }

	public InterpolatorSpan`3(SpanBound start, SpanBound end, AbstractInterpolator interpolator) { }

	public bool Equals(InterpolatorSpan other) { }

	public virtual bool Equals(object obj) { }

	public float GetDeltaTime() { }

	public virtual int GetHashCode() { }

	public InterpolatorSpan GetSubSpan(in SpanBound start, in SpanBound end) { }

	public InterpolatorSpan GetSubSpanFromHeadUntil(in SpanBound headBound) { }

	public float GetTimeStamp(int index) { }

	public int GetValuesCount() { }

	public TValueShortData GetValuesShortData(int index) { }

	public int Interpolate(DynamicArray result) { }

	public TValue InterpolateThroughRange() { }

	public virtual string ToString() { }

}

