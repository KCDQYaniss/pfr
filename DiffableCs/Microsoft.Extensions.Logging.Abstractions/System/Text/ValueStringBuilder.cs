namespace System.Text;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct ValueStringBuilder
{
	private char[] _arrayToReturnToPool; //Field offset: 0x0
	private Span _chars; //Field offset: 0x8
	private int _pos; //Field offset: 0x18

	public ValueStringBuilder(Span initialBuffer) { }

	[NullableContext(2)]
	public void Append(string s) { }

	public void Append(ReadOnlySpan value) { }

	private void AppendSlow(string s) { }

	public void Dispose() { }

	private void Grow(int additionalCapacityBeyondPos) { }

	[NullableContext(1)]
	public virtual string ToString() { }

}

