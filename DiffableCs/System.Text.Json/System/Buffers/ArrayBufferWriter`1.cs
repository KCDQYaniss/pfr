namespace System.Buffers;

internal sealed class ArrayBufferWriter`1 : IBufferWriter
{
	private T[] _buffer; //Field offset: 0x0
	private int _index; //Field offset: 0x0

	public int FreeCapacity
	{
		 get { } //Length: 29
	}

	public int WrittenCount
	{
		 get { } //Length: 4
	}

	public ReadOnlyMemory WrittenMemory
	{
		 get { } //Length: 137
	}

	public override void Advance(int count) { }

	private void CheckAndResizeBuffer(int sizeHint) { }

	public void Clear() { }

	public int get_FreeCapacity() { }

	public int get_WrittenCount() { }

	public ReadOnlyMemory get_WrittenMemory() { }

	public override Memory GetMemory(int sizeHint = 0) { }

	public override Span GetSpan(int sizeHint = 0) { }

	private static void ThrowInvalidOperationException_AdvancedTooFar(int capacity) { }

	private static void ThrowOutOfMemoryException(uint capacity) { }

}

