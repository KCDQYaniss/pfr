namespace System.Text.Json;

internal sealed class PooledByteBufferWriter : IBufferWriter, IDisposable
{
	private byte[] _rentedBuffer; //Field offset: 0x10
	private int _index; //Field offset: 0x18

	public ReadOnlyMemory WrittenMemory
	{
		 get { } //Length: 182
	}

	private PooledByteBufferWriter() { }

	public PooledByteBufferWriter(int initialCapacity) { }

	public override void Advance(int count) { }

	private void CheckAndResizeBuffer(int sizeHint) { }

	public void ClearAndReturnBuffers() { }

	private void ClearHelper() { }

	public static PooledByteBufferWriter CreateEmptyInstanceForCaching() { }

	public override void Dispose() { }

	public ReadOnlyMemory get_WrittenMemory() { }

	public override Memory GetMemory(int sizeHint = 256) { }

	public override Span GetSpan(int sizeHint = 256) { }

	public void InitializeEmptyInstance(int initialCapacity) { }

}

