namespace System.Buffers;

public interface IBufferWriter`1
{

	public void Advance(int count) { }

	public Memory GetMemory(int sizeHint = 0) { }

	public Span GetSpan(int sizeHint = 0) { }

}

