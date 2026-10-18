namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView`1))]
[DefaultMember("Item")]
[IsByRefLike]
[IsReadOnly]
[NonVersionable]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct Span`1
{
	internal readonly ByReference _pointer; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public bool IsEmpty
	{
		[NonVersionable]
		 get { } //Length: 8
	}

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

	public Span`1(T[] array) { }

	public Span`1(T[] array, int start, int length) { }

	[CLSCompliant(False)]
	public Span`1(void* pointer, int length) { }

	internal Span`1(ref T ptr, int length) { }

	public void Clear() { }

	public void CopyTo(Span destination) { }

	[Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
	public virtual bool Equals(object obj) { }

	public void Fill(T value) { }

	[NonVersionable]
	public bool get_IsEmpty() { }

	[Intrinsic]
	[NonVersionable]
	public T get_Item(int index) { }

	[NonVersionable]
	public int get_Length() { }

	[Obsolete("GetHashCode() on Span will always throw an exception.")]
	public virtual int GetHashCode() { }

	public T GetPinnableReference() { }

	public static Span op_Implicit(T[] array) { }

	public static ReadOnlySpan op_Implicit(Span span) { }

	public Span Slice(int start) { }

	public Span Slice(int start, int length) { }

	public T[] ToArray() { }

	public virtual string ToString() { }

	public bool TryCopyTo(Span destination) { }

}

