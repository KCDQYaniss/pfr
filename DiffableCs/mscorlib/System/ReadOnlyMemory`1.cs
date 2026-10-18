namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView`1))]
[IsReadOnly]
public struct ReadOnlyMemory`1 : IEquatable
{
	internal const int RemoveFlagsBitMask = 2147483647; //Field offset: 0x0
	private readonly object _object; //Field offset: 0x0
	private readonly int _index; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public static ReadOnlyMemory Empty
	{
		 get { } //Length: 10
	}

	public bool IsEmpty
	{
		 get { } //Length: 11
	}

	public int Length
	{
		 get { } //Length: 8
	}

	public ReadOnlySpan Span
	{
		 get { } //Length: 1004
	}

	public ReadOnlyMemory`1(T[] array) { }

	public ReadOnlyMemory`1(T[] array, int start, int length) { }

	internal ReadOnlyMemory`1(object obj, int start, int length) { }

	private static int CombineHashCodes(int left, int right) { }

	private static int CombineHashCodes(int h1, int h2, int h3) { }

	public override bool Equals(ReadOnlyMemory other) { }

	public virtual bool Equals(object obj) { }

	public static ReadOnlyMemory get_Empty() { }

	public bool get_IsEmpty() { }

	public int get_Length() { }

	public ReadOnlySpan get_Span() { }

	public virtual int GetHashCode() { }

	internal object GetObjectStartLength(out int start, out int length) { }

	public static ReadOnlyMemory op_Implicit(T[] array) { }

	public MemoryHandle Pin() { }

	public ReadOnlyMemory Slice(int start, int length) { }

	public virtual string ToString() { }

}

