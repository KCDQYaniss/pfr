namespace ZLogger;

[IsReadOnly]
public struct LogCategory
{
	[Nullable(1)]
	private readonly byte[] utf8; //Field offset: 0x0
	[Nullable(1)]
	public readonly string Name; //Field offset: 0x8
	public readonly JsonEncodedText JsonEncoded; //Field offset: 0x10

	public ReadOnlyMemory Utf8Memory
	{
		 get { } //Length: 234
	}

	public ReadOnlySpan Utf8Span
	{
		 get { } //Length: 149
	}

	[NullableContext(1)]
	public LogCategory(string category) { }

	public ReadOnlyMemory get_Utf8Memory() { }

	public ReadOnlySpan get_Utf8Span() { }

	[NullableContext(1)]
	public virtual string ToString() { }

}

