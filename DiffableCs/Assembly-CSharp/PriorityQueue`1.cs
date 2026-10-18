//Type is in global namespace

public class PriorityQueue`1
{
	private struct InnerNote`1
	{
		public readonly T data; //Field offset: 0x0
		public readonly float priority; //Field offset: 0x0

		public InnerNote`1(float pr, T d) { }

	}

	private readonly List _queue; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 26
	}

	public PriorityQueue`1() { }

	public void Clear() { }

	public T Dequeue() { }

	public PriorityQueueDequeuedItem DequeueWithPriority() { }

	public void Enqueue(float priority, T item) { }

	public int get_Count() { }

	public void Log() { }

}

