namespace Interpolation;

[IsReadOnly]
public struct TimeStampedValue`1
{
	public readonly TimeBound TimeInfo; //Field offset: 0x0
	public readonly T Value; //Field offset: 0x0

	public TimeStampedValue`1(TimeBound timeInfo, T value) { }

	public virtual string ToString() { }

}

