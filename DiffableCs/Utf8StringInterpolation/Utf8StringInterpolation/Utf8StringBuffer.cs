namespace Utf8StringInterpolation;

public struct Utf8StringBuffer : IDisposable
{
	[Nullable(1)]
	private ArrayBufferWriter innerBuffer; //Field offset: 0x0

	public int WrittenCount
	{
		 get { } //Length: 64
	}

	public ReadOnlyMemory WrittenMemory
	{
		 get { } //Length: 194
	}

	public ReadOnlySpan WrittenSpan
	{
		 get { } //Length: 92
	}

	[NullableContext(1)]
	internal Utf8StringBuffer(ArrayBufferWriter bufferWriter) { }

	[NullableContext(1)]
	public void CopyTo(TBufferWriter bufferWriter) { }

	public override void Dispose() { }

	public int get_WrittenCount() { }

	public ReadOnlyMemory get_WrittenMemory() { }

	public ReadOnlySpan get_WrittenSpan() { }

	[NullableContext(1)]
	public byte[] ToArray() { }

	[NullableContext(1)]
	public virtual string ToString() { }

}

