namespace Interpolation;

[IsReadOnly]
public struct TimeBound
{
	public readonly float TimeStamp; //Field offset: 0x0
	public readonly EBoundType BoundType; //Field offset: 0x4

	public TimeBound(float timeStamp, EBoundType boundType) { }

	public static int Compare(TimeBound lv, TimeBound rv) { }

	[Pure]
	public bool Equals(TimeBound other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

