namespace ZLogger.Internal;

internal class StreamBufferWriter : IBufferWriter
{
	[Nullable(1)]
	private readonly Stream stream; //Field offset: 0x10
	[Nullable(1)]
	private byte[] buffer; //Field offset: 0x18
	[Nullable(1)]
	private byte[] defaultBuffer; //Field offset: 0x20
	private int written; //Field offset: 0x28

	[NullableContext(1)]
	public StreamBufferWriter(Stream stream) { }

	public override void Advance(int count) { }

	public void Flush() { }

	public override Memory GetMemory(int sizeHint = 0) { }

	public override Span GetSpan(int sizeHint = 0) { }

	[NullableContext(2)]
	public bool TryGetForNewLine(out byte[] rawBuffer, out int rawWritten) { }

}

