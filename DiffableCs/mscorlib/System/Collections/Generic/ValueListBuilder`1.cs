namespace System.Collections.Generic;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct ValueListBuilder`1
{
	private Span _span; //Field offset: 0x0
	private T[] _arrayFromPool; //Field offset: 0x0
	private int _pos; //Field offset: 0x0

	public int Length
	{
		 get { } //Length: 4
	}

	public ValueListBuilder`1(Span initialSpan) { }

	public void Append(T item) { }

	public ReadOnlySpan AsSpan() { }

	public void Dispose() { }

	public int get_Length() { }

	private void Grow() { }

}

