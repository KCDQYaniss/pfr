namespace System.Diagnostics;

[IsReadOnly]
public struct ActivitySpanId : IEquatable
{
	private readonly string _hexString; //Field offset: 0x0

	internal ActivitySpanId(string hexString) { }

	public static ActivitySpanId CreateFromString(ReadOnlySpan idData) { }

	public override bool Equals(ActivitySpanId spanId) { }

	[NullableContext(2)]
	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	[NullableContext(1)]
	public string ToHexString() { }

	[NullableContext(1)]
	public virtual string ToString() { }

}

