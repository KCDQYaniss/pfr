namespace System.Numerics;

public struct Vector2 : IEquatable, IFormattable
{
	public float X; //Field offset: 0x0
	public float Y; //Field offset: 0x4

	[Intrinsic]
	public Vector2(float x, float y) { }

	public virtual bool Equals(object obj) { }

	[Intrinsic]
	public override bool Equals(Vector2 other) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

