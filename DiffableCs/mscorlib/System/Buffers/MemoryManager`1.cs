namespace System.Buffers;

public abstract class MemoryManager`1
{

	public abstract Span GetSpan() { }

	public abstract MemoryHandle Pin(int elementIndex = 0) { }

	protected private override bool TryGetArray(out ArraySegment segment) { }

}

