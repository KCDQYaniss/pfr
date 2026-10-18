namespace Interpolation;

[IsReadOnly]
public struct SpanBound
{
	public readonly TimeBound TimeBound; //Field offset: 0x0
	public readonly int Index; //Field offset: 0x8

	public SpanBound(int index, TimeBound timeBound) { }

	[Pure]
	public bool Equals(SpanBound other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

