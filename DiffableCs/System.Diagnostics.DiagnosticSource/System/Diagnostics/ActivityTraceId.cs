namespace System.Diagnostics;

[IsReadOnly]
public struct ActivityTraceId : IEquatable
{
	private readonly string _hexString; //Field offset: 0x0

	internal ActivityTraceId(string hexString) { }

	public static ActivityTraceId CreateFromString(ReadOnlySpan idData) { }

	public override bool Equals(ActivityTraceId traceId) { }

	[NullableContext(2)]
	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	internal static byte HexByteFromChars(char char1, char char2) { }

	internal static bool IsLowerCaseHexAndNotAllZeros(ReadOnlySpan idData) { }

	[NullableContext(1)]
	public string ToHexString() { }

	[NullableContext(1)]
	public virtual string ToString() { }

}

