namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView`1))]
[DefaultMember("Item")]
[IsByRefLike]
[IsReadOnly]
[NonVersionable]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct ReadOnlySpan`1
{
	internal readonly ByReference _pointer; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public static ReadOnlySpan Empty
	{
		 get { } //Length: 10
	}

	public bool IsEmpty
	{
		[NonVersionable]
		 get { } //Length: 8
	}

	[IsReadOnly]
	public T Item
	{
		[Intrinsic]
		[NonVersionable]
		 get { } //Length: 31
	}

	public int Length
	{
		[NonVersionable]
		 get { } //Length: 4
	}

	public ReadOnlySpan`1(T[] array) { }

	public ReadOnlySpan`1(T[] array, int start, int length) { }

	[CLSCompliant(False)]
	public ReadOnlySpan`1(void* pointer, int length) { }

	internal ReadOnlySpan`1(ref T ptr, int length) { }

	public void CopyTo(Span destination) { }

	[Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
	public virtual bool Equals(object obj) { }

	public static ReadOnlySpan get_Empty() { }

	[NonVersionable]
	public bool get_IsEmpty() { }

	[Intrinsic]
	[NonVersionable]
	public T get_Item(int index) { }

	[NonVersionable]
	public int get_Length() { }

	[Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
	public virtual int GetHashCode() { }

	public T GetPinnableReference() { }

	public static ReadOnlySpan op_Implicit(T[] array) { }

	public ReadOnlySpan Slice(int start) { }

	public ReadOnlySpan Slice(int start, int length) { }

	public T[] ToArray() { }

	public virtual string ToString() { }

	public bool TryCopyTo(Span destination) { }

}

