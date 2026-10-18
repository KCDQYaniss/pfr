namespace Interpolation;

public abstract class InterpolatorBase`2 : AbstractInterpolator
{
	private readonly IInterpolationStrategy _interpolationStrategy; //Field offset: 0x0
	private readonly LoopedQueue _values; //Field offset: 0x0

	protected InterpolatorBase`2(IInterpolationStrategy interpolationStrategy, int queueSize) { }

	public virtual void Clear() { }

	public virtual void Dispose() { }

	public virtual float GetLeftTime(float currentTime) { }

	public int GetReservedSize() { }

	public virtual float GetTimeStamp(int index) { }

	public virtual TimeStampedValue GetTimeStampedValue(int index) { }

	public virtual int GetValuesCount() { }

	protected virtual void InternalAdd(float time, in TValue value) { }

	public virtual int Interpolate(SpanBound start, SpanBound end, DynamicArray result) { }

	public virtual TValue InterpolateThroughRange(in SpanBound start, in SpanBound end) { }

	public void OverrideValue(int index, TValue value) { }

	public TimeStampedValue PeekLastValue() { }

	public virtual void RemoveValues(int count) { }

}

