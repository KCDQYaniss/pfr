namespace EFT.NextObservedPlayer;

public sealed class ByteSegmentRingBuffer
{
	[IsReadOnly]
	private struct TimestampedSegment
	{
		public readonly ArraySegment Segment; //Field offset: 0x0
		public readonly double Time; //Field offset: 0x10

		public TimestampedSegment(ArraySegment segment, double time) { }

	}

	private readonly TimestampedSegment[] _buffer; //Field offset: 0x10
	private readonly int _capacity; //Field offset: 0x18
	private int _head; //Field offset: 0x1C
	private int _count; //Field offset: 0x20

	public int Capacity
	{
		 get { } //Length: 4
	}

	public int Count
	{
		 get { } //Length: 4
	}

	public ByteSegmentRingBuffer(int capacity) { }

	public int CopyFirstTo(ArraySegment[] destination, int maxCount) { }

	public int CopyFirstTo(ArraySegment[] destination, double[] destinationTimes, int maxCount) { }

	public int CopyLastTo(ArraySegment[] destination, double[] destinationTimes, int maxCount) { }

	public bool EnqueueOverwriteOldest(ArraySegment segment, double time, out ArraySegment overwritten) { }

	public int get_Capacity() { }

	public int get_Count() { }

	public bool TryDequeue(out ArraySegment segment) { }

	public bool TryEnqueue(ArraySegment segment, double time) { }

}

