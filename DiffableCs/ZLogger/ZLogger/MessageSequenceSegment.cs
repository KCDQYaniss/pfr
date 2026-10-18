namespace ZLogger;

[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
internal struct MessageSequenceSegment
{
	public readonly string Literal; //Field offset: 0x0
	public readonly byte[] Utf8Bytes; //Field offset: 0x8

	public bool IsLiteral
	{
		 get { } //Length: 8
	}

	public MessageSequenceSegment(string literal, byte[] utf8Bytes) { }

	public bool get_IsLiteral() { }

	public virtual string ToString() { }

}

