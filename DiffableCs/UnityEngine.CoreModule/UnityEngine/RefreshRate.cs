namespace UnityEngine;

[NativeType("Runtime/Graphics/RefreshRate.h")]
public struct RefreshRate : IEquatable, IComparable
{
	public uint numerator; //Field offset: 0x0
	public uint denominator; //Field offset: 0x4

	public double value
	{
		 get { } //Length: 26
	}

	public override int CompareTo(RefreshRate other) { }

	public override bool Equals(RefreshRate other) { }

	public double get_value() { }

	public virtual string ToString() { }

}

