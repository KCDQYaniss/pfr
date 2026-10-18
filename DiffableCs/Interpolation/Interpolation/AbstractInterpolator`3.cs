namespace Interpolation;

public abstract class AbstractInterpolator`3 : IDisposable
{

	public bool IsEmpty
	{
		 get { } //Length: 34
	}

	protected AbstractInterpolator`3() { }

	public void Add(float time, TValue value) { }

	public abstract void Clear() { }

	public abstract void Dispose() { }

	private void FindContainingRange(int index, int increment, TimeBound rightSideValue, TimeBound leftSideValue, ref SpanBound resultStartIndex, ref SpanBound resultEndIndex, bool incrementIndexInCaseOfLess) { }

	public bool get_IsEmpty() { }

	public bool GetInterpolatorSpan(in TimeBound start, in TimeBound end, out InterpolatorSpan interpolatorSpan) { }

	public abstract float GetLeftTime(float currentTime) { }

	public abstract float GetTimeStamp(int index) { }

	public abstract TimeStampedValue GetTimeStampedValue(int index) { }

	public abstract int GetValuesCount() { }

	public abstract TValueShortData GetValueShortData(int index) { }

	protected abstract void InternalAdd(float time, in TValue value1) { }

	public abstract int Interpolate(SpanBound start, SpanBound end, DynamicArray result) { }

	public abstract TValue InterpolateThroughRange(in SpanBound start, in SpanBound end) { }

	public void RemoveDataUntil(in TimeBound startRangeTime) { }

	public abstract void RemoveValues(int count) { }

	private bool TryFindContainingRange(in TimeBound start, in TimeBound end, out SpanBound resultStartBound, out SpanBound resultEndBound) { }

}

